   M S B A M L   `   `   `  ����E  Amanage_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:manage_app
manage_app  5   	       manage_app.PanelGlowny   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:manage_app     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  PanelGlowny��5	   	   $	��600��6   $	��900��6*    � WindowStyle$
 None=�66    � 
ResizeMode$ NoResize=�6J    � WindowStartupLocation$ CenterScreen=�6`   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��40 �6    �� 5       � ColumnDefinitions 5      �� 5      $	��170 �6#   �� 5      .+�5      � $��0��6   $��2��6    $��40��64   $	��Top=�6@   ���	#FF2280D0.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�66   $��Center=�6R   .+�5      �� $��Opcje��6   
�������6,   '  !MaterialDesignThemes.Wpf.PopupBox  5      
�������   PopupContent. 5      �� .+�5      �� -   5         ��Name$ btnKonto��5   %   $��Konto��6N   �� 5      -   5        $ 
btnWyloguj��5   %   $��Wyloguj��6R   �� 5      -   5        $ 
btnZamknij��5   %   $��Zamknij��6R   5      5      5      5       �� 5!      $��0��6   $��1��6&   $ 
Horizontal=�66   .+�5"      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]	   Kind$	 
AccountBox=�6*   $��10,0,5,0q�6<   $��Center=�6N   $
��Left=�6i   
�������$��18��6�   $��23��6�   �� 5#      -   5        
 ��Name$
 txtPokazLogin��5#      $��Center=�63   $
��Left=�6N   
�������6i   5$       � 5%      -   5          �Name$
 Main��5%   1   $��1��6   $��1��6!     � NavigationUIVisibility$ Hidden=�6?   5&      � 5'   
   $	��170��6   $
��Left=�6   ���	#FF3B478F.+�5(      �� .+�5)      �� $	��100��6   
����������	#FF3B478F66   �� 5*      -   5         ��Name$ ListViewMenu��5*      .@�5+      �� ���	#FF2280D0$��50��6:   .��5,      �� $ 
Horizontal=�6%   .+�5-        $	 	Autorenew=�66   $��32��6G   $��34��6S   �� 5.      $��	SYMULACJA��6%   $	��115��69   $��5q�6r   ���	#FF2280D0 J� IsHitTestVisible .  ��6E   Z� ��6[   Z� 6�   5/      50      �� 51      ���	#FF2280D0$��50��6:   .��52      �� $ 
Horizontal=�6%   .+�53        $	 Settings=�66   $��32��6F   $��34��6R   �� 54      $��	PRODUKCJA��6%   $	��115��69   $��5q�6r   ���	#FF2280D0 .  ��6E   Z� ��6[   Z� 6�   55      56      �� 57      ���	#FF2280D0$��50��6:   .��58      �� $ 
Horizontal=�6%   .+�59        $	 GoogleCardboard=�66   $��32��6M   $��34��6Y   �� 5:      $��MONTAŻ��6%   $	��115��66   $��5q�6o   ���	#FF2280D0 .  ��6B   Z� ��6X   Z� 6�   5;      5<      �� 5=      ���	#FF2280D0$��50��6:   .��5>      �� $ 
Horizontal=�6%   .+�5?        $	 Clock=�66   $��32��6C   $��34��6O   �� 5@      $��CZASY��6%   $	��115��65   $��5q�6n   ���	#FF2280D0 .  ��6A   Z� ��6W   Z� 6�   5A      5B      5C      5D      �� 5E      -   5        $
 Zegar��5E      $��20(�6'   $��3,0,0,0q�65   $��Bottom=�6F   $
��Left=�6a   ���	#FF2280D0$
��Bold"�6�   $�� ��6�   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5F      -   5          Name$ TransitioningContentPanel��5F   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.3X�.��5G      � -	   5         �Name$ Panel��5G      $��	0,100,0,0q�6&   ���	#FF2280D0$��Right=�6P   $��50��6l   $	��Top=�6x   $��7��6�   5H      5I      5J      5K      