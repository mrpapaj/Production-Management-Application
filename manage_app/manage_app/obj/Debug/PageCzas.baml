   M S B A M L   `   `   `  ����E  Amanage_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:manage_app
manage_app  5          manage_app.PageCzas   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:manage_app     5      V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  PageCzas��5
      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $	��100 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��Center=�6;   $��Center=�6V   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��ID symulacji:��6   $
��Bold"�60   $��14(�6B   $��Arial)�6P   �� 5      -   5         ��Name$ ComboBoxIDSym��5      $��35��62   ���	#FF2280D0$��Center=�6T   $��Center=�6o   $��Center=�6�   $
��Bold"�6�   $��Arial)�6�   $��14(�6�   6�   5      �� 5      $��20,0,0,0q�6   $ 
Horizontal=�6+   .+�5      �� $��ID łóżka:��6   $
��Bold"�6,   $��14(�6>   $��Arial)�6L   �� 5      -   5        $ ComboBoxIDEnr��5      $��70��62   ���	#FF2280D0$��Center=�6T   $��Center=�6o   $��Center=�6�   $
��Bold"�6�   $��Arial)�6�   $��14(�6�   5      �� 5      -   5         ��Name$ btnOdswiezCzasy��5      $��30,0,0,0q�6L   $��Odśwież czasy��6^   $	��150��6v   ���	#FF2280D0���	#FF673AB7$	��1.5q�6�   $��Arial)�6�   5      �� 5   
   $ Vertical=�6   $��0��6,   $��Bottom=�69   $
��Left=�6T   .+�5      �� $ 
Horizontal=�6   $��0,5,0,0q�62   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  $��10,0,0,0q�6*   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]   Kind$ 
ArrowRight=�6<   $��20��6N   $��25��6Z    J� Opacity$	 0.6Q�6e   $
��Bold"�6s   �� 5       $��Model:��6   $��Arial)�6*   $��13(�6=   $	 0.6Q�6K   $��Center=�6Y   $��Center=�6v   $
��Bold"�6�   �� 5!      -   5         ��Name$ txtPokazIDEnr��5!   -   $��5,0,0,0q�6   $�� ��6D   $��Arial)�6L   $��13(�6_   $	 0.6Q�6m   $��Center=�6{   $��Center=�6�   $
��Bold"�6�   5"      �� 5#      $ 
Horizontal=�6   .+�5$        $��10,0,0,0q�6*   $ 
ArrowRight=�6<   $��20��6N   $��25��6Z   $	 0.6Q�6e   $
��Bold"�6s   �� 5%      $��Ilość:��6   $��Arial)�6*   $��13(�6=   $	 0.6Q�6K   $��Center=�6Y   $��Center=�6v   $
��Bold"�6�   �� 5&      -   5        $ txtPokazIlosc��5&      $��5,0,0,0q�63   $�� ��6D   $��Arial)�6L   $��13(�6_   $	 0.6Q�6m   $��Center=�6{   $��Center=�6�   $
��Bold"�6�   5'      5(      �� 5)   
   $ Vertical=�6   $��1��6,   $��Bottom=�69   $
��Left=�6T   .+�5*      �� $ 
Horizontal=�6   $��0,5,0,0q�62   .+�5+        $��10,0,0,0q�6*   $ 
ArrowRight=�6<   $��20��6N   $��25��6Z   $	 0.6Q�6e   $
��Bold"�6s   �� 5,      $��Łączny czas montażu:��6   $��Arial)�68   $��13(�6K   $	 0.6Q�6Y   $��Center=�6g   $��Center=�6�   $
��Bold"�6�   �� 5-      -   5        $ txtPokazCzasM��5-   -   $��5,0,0,0q�6   $�� ��6D   $��Arial)�6L   $��13(�6_   $	 0.6Q�6m   $��Center=�6{   $��Center=�6�   $
��Bold"�6�   5.      �� 5/      $ 
Horizontal=�6   .+�50        $��10,0,0,0q�6*   $ 	ArrowDown=�6<   $��20��6M   $��25��6Y   $ 1Q�6d   $
��Bold"�6p   �� 51      $��Łączny czas produkcji:��6   $��Arial)�6:   $��13(�6M   $ 1Q�6[   $��Center=�6g   $��Center=�6�   $
��Bold"�6�   �� 52      -   5        $ txtPokazCzasBG��52      $��5,0,0,0q�64   $�� ��6E   $��Arial)�6M   $��13(�6`   $ 1Q�6n   $��Center=�6z   $��Center=�6�   $
��Bold"�6�   53      54      � 55   
   $��2��6   .+�56      &   System.Windows.Controls.DataGrid  -   5          Name$	 dg5��56      $��10q�6$   $
��Left=�60   $	��top=�6K   $	��710��6c   $��Arial)�6o   57      58      59      