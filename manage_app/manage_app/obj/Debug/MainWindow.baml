   M S B A M L   `   `   `  ����E  Amanage_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:manage_app
manage_app  5   	       manage_app.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:manage_app     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  	Logowanie��5	   	   $	��400��6   $	��350��6(    � WindowStyle$
 None=�64    � 
ResizeMode$ NoResize=�6G    � WindowStartupLocation$ CenterScreen=�6]   .��5
      � .+�5   
   �� $��	0,0,0,158q�6   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $ 0.546Q�65   5      5      �� 5   
   -   5         ��Name$ 
btnZamknij��5      $��Right=�6>   $	��Top=�6Z   $��30��6�   $��50��6�   $��0,5,0,0q�6�   ��6r   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]	   Kind$	 	ExitToApp=�6&   $��Center=�67   $��Center=�6R   
 J� Opacity$
 1Q�6o   ���	#FF673AB7$��24��6�   $��28��6�   5      �� 5   
   $	��314��6   $��Bottom=�6!   $��
50,0,50,37q�6<    �� RadiusY$ 10��6P    �� RadiusX$ 10��6]   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      � 5   
   $��50,60,50,47q�6   
�������.+�5      ��  �� Orientation$ Vertical=�6   .+�5        $	 HomeOutline=�6*   $��39��6=   $��50��6I   $	
 0.8Q�6T   $��Center=�6b   $��Center=�6}   ���	#FF673AB76�   �� 5      $��Arial)�6   $��17(�6/   $	
 0.8Q�6=    �� TextAlignment$ Center=�6K   ���	#FF673AB7$
��Bold"�6y   $��29��6�   $��	45,0,45,0q�6�   $��Center=�6�   $��Center=�6�   $	��182��6�   Manage Application6  5       �� 5!      $��Center=�6   $	��244��64   $��0,45,0,0q�6A   $��2��6S   .+�5"      �� $ 
Horizontal=�6   .+�5#        $	 
AccountBox=�6.   $��Center=�6@   $��Stretch=�6]   $	
 0.8Q�6y   ���	#FF673AB7$��	30,70,0,7q�6�   $��24��6�   $��28��6�   �� 5$      -   5         ��Name$ txtLogin��5$      $��
10,70,30,7q�60   
�������$��30��6X   $��15(�6d   $��Arial)�6r   ���	#FF878787$	��134��6�   $��Center=�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Login��6�   5%      �� 5&      $ 
Horizontal=�6   .+�5'        $		 Key=�6.   $��Center=�69   $��Center=�6V   $	
 0.8Q�6q   ���	#FF673AB7$��35,5,0,7q�6�   $��24��6�   $��21��6�   G� 5(      -   5         G�Name$ txtHaslo��5(   "   $��
12,10,30,7q�65   
�������$��30��6]   $��15(�6i   $��Arial)�6w   $��Bottom=�6�   ���	#FF878787$	��134��6�   $ Hasło��6�   5)      �� 5*      -   5        $��
btnZaloguj��5*      $	��134��6D   $��Center=�6P   $��Bottom=�6m   $��10,40,10,10q�6�   $��ZALOGUJ��6�   $��30��6�   $��Arial)�6�    5+        5,      $ 8Q�6+   $ 0Q�6:   $ Quality=�6H   $ 1Q�6`   5.      5/      50      51      52      