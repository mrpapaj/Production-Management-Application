﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace manage_app
{
    /// <summary>
    /// Interaction logic for PageProdukcja.xaml
    /// </summary>
    public partial class PageProdukcja : Page
    {
        public PageProdukcja()
        {
            InitializeComponent();
            Odswiez_ComboBoxIDSym();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-OIOAR14S\MYSQL2017; Initial Catalog=BazaTest; User ID=sa; Password=whatever2424");

        private void Odswiez_ComboBoxIDSym()
        {
            DataTable dt = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_sym FROM t_SymulacjaG", sqlCon);
                sqlDA.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ComboBoxIDSym.Items.Add(dr["id_sym"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void ComboBoxIDSym_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxIDEnr.Items.Clear();
            DataTable dt = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_ez FROM t_Symulacja WHERE id_sym='" + ComboBoxIDSym.SelectedItem + "'", sqlCon);
                sqlDA.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ComboBoxIDEnr.Items.Add(dr["id_ez"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void btnSymulacja_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dtTB = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                if ((ComboBoxIDSym.SelectedItem != null) && (ComboBoxIDEnr.SelectedItem != null))
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT q_Symulacja_MaterialProdukcja_1.id_sym, q_Symulacja_MaterialProdukcja_1.dispo AS Dysponent, q_Symulacja_MaterialProdukcja_1.grupa, q_Symulacja_MaterialProdukcja_1.ID_m, q_Symulacja_MaterialProdukcja_1.SAP, q_Symulacja_MaterialProdukcja_1.nazwa, q_Symulacja_MaterialProdukcja_1.jednostka, ROUND(q_Symulacja_MaterialProdukcja_1.Ilość, 3) AS Ilość, ROUND((COALESCE([q_SumaMagazynSym].[iloscmagazyn], 0)), 3) AS StanMagazynowy FROM(SELECT t_Symulacja.id_sym, t_MaterialyMaster.grupa, t_BaugrupaMaster.ID_m, t_MaterialyMaster.SAP, t_MaterialyMaster.nazwa, t_MaterialyMaster.jednostka, Sum([t_BaugrupaMaster].[ilosc] * [t_BaugrupaMaster].[dlugosc] *[t_Komponenty].[ilosc] *[t_Lozka].[ilosc] *[t_Symulacja].[ilosc]) AS Ilość, t_MaterialyMaster.dispo FROM t_MaterialyMaster INNER JOIN(((t_Lozka INNER JOIN t_Komponenty ON t_Lozka.id_kp = t_Komponenty.id_kp) INNER JOIN t_Symulacja ON t_Lozka.id_enr = t_Symulacja.id_ez) INNER JOIN t_BaugrupaMaster ON t_Komponenty.id_b = t_BaugrupaMaster.ID_b) ON t_MaterialyMaster.ID = t_BaugrupaMaster.ID_m " +
                        "GROUP BY t_Symulacja.id_sym, t_Symulacja.id_ez, t_MaterialyMaster.grupa, t_BaugrupaMaster.ID_m, t_MaterialyMaster.SAP, t_MaterialyMaster.nazwa, t_MaterialyMaster.jednostka, t_MaterialyMaster.dispo " +
                        "HAVING (t_Symulacja.id_sym='" + ComboBoxIDSym.Text + "') AND (t_Symulacja.id_ez='" + ComboBoxIDEnr.Text + "')) q_Symulacja_MaterialProdukcja_1 LEFT JOIN (SELECT t_MagazynStan.ID, Sum(t_MagazynStan.ilosc) AS IloscMagazyn, t_MagazynStan.jednostka, t_MagazynStan.grupa, t_MagazynStan.lokal FROM t_MagazynStan GROUP BY t_MagazynStan.ID, t_MagazynStan.jednostka, t_MagazynStan.grupa, t_MagazynStan.lokal HAVING(((t_MagazynStan.grupa) <> 'stal_sztuki') AND((t_MagazynStan.lokal)Is Null Or(t_MagazynStan.lokal) = 'lokal'))) q_SumaMagazynSym ON q_Symulacja_MaterialProdukcja_1.ID_m = q_SumaMagazynSym.ID " +
                        "GROUP BY q_Symulacja_MaterialProdukcja_1.id_sym, q_Symulacja_MaterialProdukcja_1.dispo, q_Symulacja_MaterialProdukcja_1.grupa, q_Symulacja_MaterialProdukcja_1.ID_m, q_Symulacja_MaterialProdukcja_1.SAP, q_Symulacja_MaterialProdukcja_1.nazwa, q_Symulacja_MaterialProdukcja_1.jednostka, q_Symulacja_MaterialProdukcja_1.Ilość, COALESCE([q_SumaMagazynSym].[iloscmagazyn],0);", sqlCon);
                    sqlDA.Fill(dt);
                    dg4.ItemsSource = dt.DefaultView;

                    //informacja dodatkowa - jaka ilosc zostala przypisana do danego modelu w symulacji
                    SqlDataAdapter sqlDATB = new SqlDataAdapter("SELECT ilosc FROM t_Symulacja WHERE (id_sym='" + ComboBoxIDSym.Text + "') AND (id_ez='" + ComboBoxIDEnr.Text + "')", sqlCon);
                    sqlDATB.Fill(dtTB);
                    txtPokazIlosc.Text = dtTB.Rows[0][0].ToString();
                    txtPokazIDEnr.Text = ComboBoxIDEnr.Text;
                    ComboBoxIDEnr.Text = "";
                }

                else if ((ComboBoxIDSym.SelectedItem != null) && (ComboBoxIDEnr.SelectedItem == null))
                {

                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT q_Symulacja_MaterialProdukcja_1.id_sym, q_Symulacja_MaterialProdukcja_1.dispo AS Dysponent, q_Symulacja_MaterialProdukcja_1.grupa, q_Symulacja_MaterialProdukcja_1.ID_m, q_Symulacja_MaterialProdukcja_1.SAP, q_Symulacja_MaterialProdukcja_1.nazwa, q_Symulacja_MaterialProdukcja_1.jednostka, ROUND(q_Symulacja_MaterialProdukcja_1.Ilość, 3) AS Ilość, ROUND((COALESCE([q_SumaMagazynSym].[iloscmagazyn], 0)), 3) AS StanMagazynowy FROM(SELECT t_Symulacja.id_sym, t_MaterialyMaster.grupa, t_BaugrupaMaster.ID_m, t_MaterialyMaster.SAP, t_MaterialyMaster.nazwa, t_MaterialyMaster.jednostka, Sum([t_BaugrupaMaster].[ilosc] * [t_BaugrupaMaster].[dlugosc] *[t_Komponenty].[ilosc] *[t_Lozka].[ilosc] *[t_Symulacja].[ilosc]) AS Ilość, t_MaterialyMaster.dispo FROM t_MaterialyMaster INNER JOIN(((t_Lozka INNER JOIN t_Komponenty ON t_Lozka.id_kp = t_Komponenty.id_kp) INNER JOIN t_Symulacja ON t_Lozka.id_enr = t_Symulacja.id_ez) INNER JOIN t_BaugrupaMaster ON t_Komponenty.id_b = t_BaugrupaMaster.ID_b) ON t_MaterialyMaster.ID = t_BaugrupaMaster.ID_m " +
                        "GROUP BY t_Symulacja.id_sym, t_MaterialyMaster.grupa, t_BaugrupaMaster.ID_m, t_MaterialyMaster.SAP, t_MaterialyMaster.nazwa, t_MaterialyMaster.jednostka, t_MaterialyMaster.dispo " +
                        "HAVING t_Symulacja.id_sym='" + ComboBoxIDSym.Text + "') q_Symulacja_MaterialProdukcja_1 LEFT JOIN (SELECT t_MagazynStan.ID, Sum(t_MagazynStan.ilosc) AS IloscMagazyn, t_MagazynStan.jednostka, t_MagazynStan.grupa, t_MagazynStan.lokal FROM t_MagazynStan GROUP BY t_MagazynStan.ID, t_MagazynStan.jednostka, t_MagazynStan.grupa, t_MagazynStan.lokal HAVING(((t_MagazynStan.grupa) <> 'stal_sztuki') AND((t_MagazynStan.lokal)Is Null Or(t_MagazynStan.lokal) = 'lokal'))) q_SumaMagazynSym ON q_Symulacja_MaterialProdukcja_1.ID_m = q_SumaMagazynSym.ID " +
                        "GROUP BY q_Symulacja_MaterialProdukcja_1.id_sym, q_Symulacja_MaterialProdukcja_1.dispo, q_Symulacja_MaterialProdukcja_1.grupa, q_Symulacja_MaterialProdukcja_1.ID_m, q_Symulacja_MaterialProdukcja_1.SAP, q_Symulacja_MaterialProdukcja_1.nazwa, q_Symulacja_MaterialProdukcja_1.jednostka, q_Symulacja_MaterialProdukcja_1.Ilość, COALESCE([q_SumaMagazynSym].[iloscmagazyn],0);", sqlCon);
                    sqlDA.Fill(dt);
                    dg4.ItemsSource = dt.DefaultView;

                    SqlDataAdapter sqlDATB = new SqlDataAdapter("SELECT SUM(ilosc) FROM t_Symulacja WHERE id_sym='" + ComboBoxIDSym.Text + "'", sqlCon);
                    sqlDATB.Fill(dtTB);
                    txtPokazIlosc.Text = dtTB.Rows[0][0].ToString();
                    txtPokazIDEnr.Text = "Wszystkie";
                }
                else
                {
                    MessageBox.Show("Wybierz numer symulacji");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
