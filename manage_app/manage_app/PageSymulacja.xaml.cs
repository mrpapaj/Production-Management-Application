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
    /// Interaction logic for PageSymulacja.xaml
    /// </summary>
    public partial class PageSymulacja : Page
    {

        public PageSymulacja()
        {
            InitializeComponent();
            //symulacja calosciowa
            OdswiezanieSymulacjiG();
            Odswiez_ComboBoxIDSym();
            //symulacja szczegolowa
            OdswiezanieSymulacji();
            OdswiezanieLozka();
        }

        SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-OIOAR14S\MYSQL2017; Initial Catalog=BazaTest; User ID=sa; Password=whatever2424");
        DataTable dt_idenr;

        private void btnOdswiezSymulacjeG_Click(object sender, RoutedEventArgs e)
        {
            OdswiezanieSymulacjiG();
            MessageBox.Show("Pomyślnie odświeżono symulacje");
            
        }

        private void OdswiezanieSymulacjiG()
        {
            DataTable dt = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_sym as IDSym , opis as OpisSymulacji, data_w as DataUtworzenia, user_w as Użytkownik, status as Status FROM t_SymulacjaG", sqlCon);
                sqlDA.Fill(dt);
                dg1.ItemsSource = dt.DefaultView;
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

        private void btnDodajSymulacjeG_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                DateTime datetime = Convert.ToDateTime(txtDataUtworzeniaG.Text);
                SqlDataAdapter sqlDA = new SqlDataAdapter("declare @max int; select @max = max(id_sym) from t_SymulacjaG; dbcc checkident(t_SymulacjaG ,reseed, @max); INSERT INTO t_SymulacjaG (opis, data_w, user_w) VALUES ('" + txtOpisSymulacjiG.Text + "','" + datetime.ToString("yyyy-MM-dd HH:mm:ss.fff") + "','" + txtUzytkownikG.Text + "')", sqlCon);
                sqlDA.Fill(dt);
                MessageBox.Show("Pomyślnie dodano symulację");
                txtOpisSymulacjiG.Text = "";
                txtUzytkownikG.Text = "";
                txtDataUtworzeniaG.Text = "";
                OdswiezanieSymulacjiG(); //odswiezenie grida 
                Odswiez_ComboBoxIDSym(); //odswiezenie comboboxa

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

        private void Odswiez_ComboBoxIDSym()
        {
            ComboBoxIDSym.Items.Clear(); //czyszczenie comboboxa przed ponownym uzupelnieniem
            ComboBoxIDSym2.Items.Clear();
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
                    ComboBoxIDSym2.Items.Add(dr["id_sym"].ToString());
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

        private void btnUsunSymulacjeG_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlDataAdapter sqlDA = new SqlDataAdapter("DELETE FROM t_SymulacjaG WHERE id_sym='" + ComboBoxIDSym.Text + "'", sqlCon);
                sqlDA.Fill(dt);
                MessageBox.Show("Pomyślnie usunięto symulację");
                ComboBoxIDSym.Text = "";
                OdswiezanieSymulacjiG();
                Odswiez_ComboBoxIDSym();
                OdswiezanieSymulacji();

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

        private void btnOdswiezLozka_Click(object sender, RoutedEventArgs e)
        {
            OdswiezanieLozka();
            MessageBox.Show("Pomyślnie odświeżono łóżka");
        }

        private void OdswiezanieLozka()
        {
            dt_idenr = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_enr as IDLozka, opis as Opis FROM t_LozkaG", sqlCon);
                sqlDA.Fill(dt_idenr);
                dg3.ItemsSource = dt_idenr.DefaultView;
                txtIDEnr.Text = "";

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

        private void txtIDEnr_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                DataView DV = new DataView(dt_idenr);
                DV.RowFilter = string.Format("IDLozka LIKE '{0}%'", txtIDEnr.Text);
                dg3.ItemsSource = DV;

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

        private void btnOdswiezSymulacje_Click(object sender, RoutedEventArgs e)
        {
            OdswiezanieSymulacji();
            MessageBox.Show("Pomyślnie odświeżono symulacje");
        }

        private void OdswiezanieSymulacji()
        {
            DataTable dt = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_sym as IDSym, id_ez as IDLozka, ilosc as Ilosc, status as Status FROM t_Symulacja", sqlCon);
                sqlDA.Fill(dt);
                dg2.ItemsSource = dt.DefaultView;
               
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

        private void btnZnajdzSymulacje_Click(object sender, RoutedEventArgs e)
        {
            ZnajdzSymulacje();
        }

        private void ZnajdzSymulacje()
        {
            DataTable dt = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                if ((ComboBoxIDSym2.SelectedItem != null) && (txtIDEnr.Text != ""))
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_sym as IDSym, id_ez as IDLozka, ilosc as Ilosc, status as Status FROM t_Symulacja WHERE id_sym='" + ComboBoxIDSym2.Text + "' AND id_ez='" + txtIDEnr.Text + "'", sqlCon);
                    sqlDA.Fill(dt);
                    dg2.ItemsSource = dt.DefaultView;
                    txtIDEnr.Text = "";
                }
                else if ((ComboBoxIDSym2.SelectedItem != null) && (txtIDEnr.Text == ""))
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT id_sym as IDSym, id_ez as IDLozka, ilosc as Ilosc, status as Status FROM t_Symulacja WHERE id_sym='" + ComboBoxIDSym2.Text + "'", sqlCon);
                    sqlDA.Fill(dt);
                    dg2.ItemsSource = dt.DefaultView;
                }
                else
                {
                    MessageBox.Show("Uzupełnij brakujące informacje");
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
    
        private void btnDodajSymulacje_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                if ((ComboBoxIDSym2.SelectedItem != null) && (txtIDEnr.Text != "") && (txtIloscLozek.Text != ""))
                {
                    //warunek sprawdzajacy czy lozko istnieje
                    SqlCommand SzukajIDLozka = new SqlCommand("SELECT count(id_enr) FROM t_LozkaG WHERE id_enr='" + txtIDEnr.Text + "'", sqlCon);
                    int CzyIstnieje = (int)SzukajIDLozka.ExecuteScalar();
                    if (CzyIstnieje == 1) //kazda inna wartosc bedzie zla
                    {
                        SqlDataAdapter sqlDA = new SqlDataAdapter("INSERT INTO t_Symulacja (id_sym, id_ez, ilosc, status) VALUES ('" + ComboBoxIDSym2.Text + "','" + txtIDEnr.Text + "','" + txtIloscLozek.Text + "','" + 0 + "')", sqlCon);
                        sqlDA.Fill(dt);
                        MessageBox.Show("Pomyślnie dodano symulację");
                        txtIloscLozek.Text = "";
                        ZnajdzSymulacje();
                    }
                    else
                    {
                        MessageBox.Show("Model '" + txtIDEnr.Text + "' nie istnieje");
                        txtIloscLozek.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Uzupełnij brakujące informacje");
                }

            }
            catch (Exception)
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter("UPDATE t_Symulacja SET ilosc = ilosc +'" + txtIloscLozek.Text + "' WHERE id_ez='" + txtIDEnr.Text + "'", sqlCon);
                sqlDA.Fill(dt);
                MessageBox.Show("Wybrany model łóżka został już wcześniej dodany do symulacji nr " + ComboBoxIDSym2.Text + ", w związku z czym, zwiększono bieżącą ilość łóżek tej symulacji o " + txtIloscLozek.Text);
                txtIloscLozek.Text = "";
                ZnajdzSymulacje();
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void btnUsunSymulacje_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                if ((ComboBoxIDSym2.SelectedItem != null) && (txtIDEnr.Text != ""))
                {
                    //warunek sprawdzajacy czy lozko jest w wybranej symulacji
                    SqlCommand SzukajIDLozka = new SqlCommand("SELECT count(id_ez) FROM t_Symulacja WHERE (id_sym='" + ComboBoxIDSym2.Text + "') AND (id_ez='" + txtIDEnr.Text + "')", sqlCon);
                    int CzyIstnieje = (int)SzukajIDLozka.ExecuteScalar();
                    if (CzyIstnieje == 1) //kazda inna wartosc bedzie zla
                    {
                        SqlDataAdapter sqlDA = new SqlDataAdapter("DELETE FROM t_Symulacja WHERE (id_sym='" + ComboBoxIDSym2.Text + "') AND (id_ez='" + txtIDEnr.Text + "')", sqlCon);
                        sqlDA.Fill(dt);
                        dg2.ItemsSource = dt.DefaultView;
                        MessageBox.Show("Pomyślnie usunięto model '" + txtIDEnr.Text + "' z symulacji nr " + ComboBoxIDSym2.Text);
                        txtIDEnr.Text = "";
                        ZnajdzSymulacje();
                    }
                    else
                    {
                        MessageBox.Show("Nie można usunąć modelu '" + txtIDEnr.Text + "', ponieważ nie istnieje w wybranej symulacji");
                        txtIloscLozek.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Uzupełnij brakujące informacje");
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
