   M S B A M L   `   `   `  ����E  Amanage_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:manage_app
manage_app  5          manage_app.PageMontaz   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:manage_app     5      V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  
PageMontaz��5
      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��Center=�6;   $��Center=�6V   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��ID symulacji:��6   $
��Bold"�60   $��14(�6B   $��Arial)�6P   �� 5      -   5         ��Name$ ComboBoxIDSym��5      $��35��62   ���	#FF2280D0$��Center=�6T   $��Center=�6o   $��Center=�6�   $
��Bold"�6�   $��Arial)�6�   $��14(�6�   6�   5      �� 5      $��20,0,0,0q�6   $ 
Horizontal=�6+   .+�5      �� $��ID łóżka:��6   $
��Bold"�6,   $��14(�6>   $��Arial)�6L   �� 5      -   5        $ ComboBoxIDEnr��5      $��70��62   ���	#FF2280D0$��Center=�6T   $��Center=�6o   $��Center=�6�   $
��Bold"�6�   $��Arial)�6�   $��14(�6�   5      �� 5      -   5         ��Name$ btnSymulacja��5      $��30,0,0,0q�6F   $��Rozpocznij symulację��6X   $	��170��6w   ���	#FF2280D0���	#FF673AB7$	��1.5q�6�   $��Arial)�6�   5      �� 5   
   $ Vertical=�6   $��Bottom=�6,   $
��Left=�6G   .+�5      �� $ 
Horizontal=�6   $��0,5,0,0q�62   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  $��10,0,0,0q�6*   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]   Kind$ 
ArrowRight=�6<   $��20��6N   $��25��6Z    J� Opacity$	 0.6Q�6e   $
��Bold"�6s   �� 5      $��Model:��6   $��Arial)�6*   $��13(�6=   $	 0.6Q�6K   $��Center=�6Y   $��Center=�6v   $
��Bold"�6�   �� 5       -   5         ��Name$ txtPokazIDEnr��5    -   $��5,0,0,0q�6   $�� ��6D   $��Arial)�6L   $��13(�6_   $	 0.6Q�6m   $��Center=�6{   $��Center=�6�   $
��Bold"�6�   5!      �� 5"      $ 
Horizontal=�6   .+�5#        $��10,0,0,0q�6*   $ 
ArrowRight=�6<   $��20��6N   $��25��6Z   $	 0.6Q�6e   $
��Bold"�6s   �� 5$      $��Ilość:��6   $��Arial)�6*   $��13(�6=   $	 0.6Q�6K   $��Center=�6Y   $��Center=�6v   $
��Bold"�6�   �� 5%      -   5        $ txtPokazIlosc��5%      $��5,0,0,0q�63   $�� ��6D   $��Arial)�6L   $��13(�6_   $	 0.6Q�6m   $��Center=�6{   $��Center=�6�   $
��Bold"�6�   5&      5'      � 5(   
   $��1��6   .+�5)      &   System.Windows.Controls.DataGrid  -   5          Name$	 dg4��5)      $��1��6$   $��10q�61   $
��Left=�6=   $	��top=�6X   $	��710��6p   $��Arial)�6|   5*      5+      5,      