   M S B A M L   `   `   `  ����Q  MP1-AP1-Alvaro-20190269, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:P1_AP1_Alvaro_20190269.UI.Registros#P1_AP1_Alvaro_20190269.UI.Registros  5   	   2    ,P1_AP1_Alvaro_20190269.UI.Registros.rAportes   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:P1_AP1_Alvaro_20190269.UI.Registros     5   	     � Title$  Registro de Aportes��5   	   $	��360��6%   $	��350��62   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   $��10q�6,   .+�5      �� $ Vertical=�6   .+�5      �� $��
Aporte id:��6   �� 5      $ 
Horizontal=�6   $��23��66   .+�5      �� -   5         ��Name$ AporteID_TextBox��5      $	��100��68   $��18��6D   $��5,0,0,0q�6P   ��6a   �� *
AporteID+�� 5      -   5         ��Name$ Buscar_Button��5      $	��5,0q�64   .��5      �� $ 
Horizontal=�6%   .+�5      �� $ ��/Resources/search-icon.png��6$   $��22��6H   $��20��6T   5      5      5      5      �� 5      $��Fecha:��6   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ Fecha_DatePicker��5         SelectedDateFormat$ Short=�6R   $	��150��6m   $
��Left=�6y   $��5,0,0,0q�6�      SelectedDate 63   �� *Fecha+6�   �� 5      $��Persona:��6   �� 5      -   5        $ Persona_TextBox��5      $	��300��6/   $
��Left=�6;   $��5,0,0,0q�6V   ��6g   �� *	Persona+�� 5      $��	Concepto:��6   �� 5      -   5        $ Concepto_TextBox��5      $	��300��60   $
��Left=�6<   $��5,0,0,0q�6W   ��6h   �� *
Concepto+�� 5      $��Monto:��6   �� 5      -   5        $ Monto_TextBox��5      $	��150��6-   $
��Left=�69   $��5,0,0,0q�6T   ��6e   �� *Monto+�� 5       $ 
Horizontal=�6   $
��0,20q�62   .+�5!      �� -   5        $ Nuevo_Button��5!      .��5"      �� $ 
Horizontal=�6!   .+�5#      �� $"��/Resources/File-new-icon.png��6    �� 5$      $��Nuevo��6    5%      5&      �� 5(      -   5        $ Guardar_Button��5(      $
��35,0q�6N   .��5)      �� $ 
Horizontal=�6!   .+�5*      �� $ ��/Resources/floppy-icon.png��6    �� 5+      $��Guardar��6    5,      5-      �� 5/      -	   5        $ Eliminar_Button��5/      .��50      �� $ 
Horizontal=�6!   .+�51      �� $ ��/Resources/delete-icon.png��6    �� 52      $��Eliminar��6    53      54      55      57      59      5:      