   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      K GSistema_Contable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Sistema_Contable.Models.DBSistema_Contable.Models.DB 5	      A%clr-namespace:Sistema_Contable.ModelsSistema_Contable.Models 5
      =#clr-namespace:Sistema_Contable.ViewSistema_Contable.View 5      I)clr-namespace:Sistema_Contable.ViewModelsSistema_Contable.ViewModels 5      e aSyncfusion.SfTreeView.WPF, Version=19.2310.0.62, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89zSclr-namespace:Syncfusion.UI.Xaml.TreeView.Engine;assembly=Syncfusion.SfTreeView.WPF"Syncfusion.UI.Xaml.TreeView.Engine 5      )   #Sistema_Contable.View.PContabilidad   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      ;local2(clr-namespace:Sistema_Contable.Models.DB     5	      8local3%clr-namespace:Sistema_Contable.Models     5
      5local#clr-namespace:Sistema_Contable.View     5      @
viewModles)clr-namespace:Sistema_Contable.ViewModels     5      c	 _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity 	 5      j
 fSyncfusion.SfBusyIndicator.WPF, Version=19.2310.0.62, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.2310.0.62, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.2310.0.62, Culture=neutral, PublicKeyToken=3d67ed1f87d44c898
syncfusion!http://schemas.syncfusion.com/wpf 
    5      fEngineSclr-namespace:Syncfusion.UI.Xaml.TreeView.Engine;assembly=Syncfusion.SfTreeView.WPF 
    5      -   5          N� Title$  PContabilidad��5       � DataContext 5      8  2Sistema_Contable.ViewModels.ContabilidadViewModels  5   
    � 	Resources 5       �� MergedDictionaries �� Source �� 
TargetType   TextboxRedondo �� Property �� Value �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName ��Name  ButtonTransparent �� Padding  PruebaButton F�Name �� Stretch 
 CvsKey �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName�� 5    
    5!      �� 5#      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5$      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5%      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Themes/Light.Blue.xaml?�6%   %�  &	        '�� Z    &	 �    &	 K    &	 7    �� 50      " ��6   .�51      ��  � ��$ 2q�6,   �� 52       � �� �#0006/   �� 53       � ��$ 15(�6-   �� 54       � ��$ Center=�66   �� 55       � ��$ 30��6+   �� 56       � ��$ Stretch=�68   �� 57       � �� 58      �� 59      " ��6*   .R�5:      �� $	 border��6%   $
 10��65   ���#000$	��1.5q�6Z   ���#fff._�5;   "   �� $ PART_ContentHost��6/   $|�false��6I   $��Hidden=�6[   $��Hidden=�6�   5<       5=      P� 5>   "    �@J�IsMouseOver$
 true��6A   . �5?   &   �� $ border��6D    � ��
 �  ��6X   �� 5@   &    � ��
 �  ��6C   5A   #   P� 5B   "    �@J�	IsFocused$
 true��6?   . �5C   &   ��  � ��
 ��  �6C   �� 5D   &   $ border��6D    � ��
 ��  �6X   5E   #   5G      5I      5J      �� 5L      " ��6   .�5M      ��  � ��$ 17(�6-   �� 5N       � �� 5O      �� 5P      " ��6*   .R�5Q      �� $	 Border��6%   $��	0,0,0,2.5q�65   
�������$
 4,4,0,0��6i   $	��2,0q�6�   ._�5R   "   �� $ ContentSite��63   $��Center=�6H   $��Center=�6c   $��Header��6�   $
��10,2q�6�   5S       5T      P� 5U   "    �@��
IsSelected$
 True��6@   . �5V   &   �� $ Border��6-    � ��
 ��  �6X   �� 5W   &    � �� �#5E82F56C   5X   #   P� 5Y   "    �@��
IsSelected$ False��6@   . �5Z   &   �� $ Border��6-    � ��
 ���� 6X   5[   #   5]      5_      5`      �� 5b      " ��6   .�5c      ��  �@�OverridesDefaultStyle$
 True��6:   �� 5d       � �� 5e      �� 5f      " ��6*   .R�5g      �� $	 border��6%   $��1q�5h      $	 4,2q�5i      
������ $
 3��5k      #��z��5l      ._�5m   "   �� $��Center=�63   $��Center=�6P   5n      5p      5r      5s      �� 5u      " ��6)   .�5v      ��  � �� �#3737376/   �� 5w       � ��
 �����6/   �� 5x       � ��$ 15(�6-   �� 5y       �@J�SnapsToDevicePixels$
 True��68   �� 5{       � �� 5|      �� 5}      " ��6*   .R�5~      �� $
 4��6%   #��z��66   ._�5   "   � .+�5�   &   F� $ PathIcon��6+   $��15��6=   $��15��6H   $
 Fill=�6T   ���#4C87B3$
��Left=�6r   $��17,0,0,0q�6�   4�������<R���=�x�O���Tn5����<R6�   �� 5�   &   $ MyContentPresenter��67   #��z��6S   $��Center=�6w   $��Center=�6�   $��0,0,0,0q�6�   5�   #   5�       5�      P� 5�   "    �@J�IsMouseOver$
 True��6A   . �5�   &   ��  � �� �#E594006C   �� 5�   &    � ��
 �����6C   �� 5�   &   $ PathIcon��6-    � ��
 �   �6S   5�   #   P� 5�   "    � ��$
 True��6?   . �5�   &   ��  � ��
 � E��6C   �� 5�   &    � ��
 �����6C   5�   #   5�      5�      5�      �� 5�       5�        5�      $ 	IdAsiento��6/   5�      5�      .��5�      � .+�5�   
   �� $��5q�6   
������ 
������ .@�5�      �� $��Catálogo de cuenta��6   .��5�      �  � RowDefinitions 5�      �� 5�      $
��auto �6(   �� 5�      $��* �6(   .+�5�      � -   5         �Name$ GridEdit��5�      $��0��6-   $��	10 10 0 0q�6f   $��Stretch=�6y   y�6:   ��  �� Path$ MuestraGridEdit� � ColumnDefinitions 5�      �� 5�      $��* �6/   �� 5�      $
��auto �6/   .+�5�      � $��0��6    6/   �� *Cambio+ 5�      �� 5�   "   $
��auto �63   �� 5�   "   $��* �63   �� 5�   "   $
��auto �63   �� 5�   "   $��* �63   �� 5�   "   $
��auto �63   �� 5�   "   $
��auto �63   �� 5�   "   $
��auto �63   .+�5�      �� $��Nombre :��6$   $��0��67   $��Bottom=�6G   �� 5�      -   5         ��Name$ addressTextBox��5�   &   $��1��6g    + 'MahApps.Styles.TextBox.DataGrid.Editing#��[ 6w   $��Bottom=�6�   $��15(�6�   
���   ���6>   �� $ Nombre� �� Mode$ TwoWay=�6�   �� 5�      $��Descripcion :��6$   $��2��6<   $��Bottom=�6L   �� 5�      -   5        $ 
desTextBox��5�   &   $��3��6h   #��[ 6x   $��Bottom=�6�   $��30��6�   $��15(�6�   
���������6:   �� $ Descripcion�$ TwoWay=�6�   �� 5�      $��Estado :��6$   $��4��67   $��Bottom=�6G   �� 5�      $	��120��6'   $��5��63   $��15(�6C   $��0 3 0 3q�6�   $��Bottom=�6�    , (MahApps.Styles.ComboBox.DataGrid.Editing#��[ 6�   
������� �� SelectedIndex 6Q   �� $ Indice�$ TwoWay=�.@�5�   "   �� $��Inactiva��6/   $��15(�6B   �� 5�   "   $��Activa��6/   $��15(�6@    �� 
IsSelected$
 True��6N   5�      5�      �� 5�      $��1��6%    �� Orientation$ 
Horizontal=�65   $��10 0 0 0q�6N   $��Right=�6`   .+�5�      �� $��0 0 10 0q�6%   $��50��67   $��30��6B   ��6N   �� *CommandCancel+.��5�   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6:   $��20��6I   $��20��6T   
���  ��$��Center=�6q   $��Center=�6�   5�      �� 5�      $��0 0 10 0q�6%   $��50��67   $��30��6B   ��6N   �� *	CommandOk+.��5�   "     $ Check=�6:   $��20��6I   $��20��6T   
����  �$��Center=�6r   $��Center=�6�   5�      5�      5�      � 5�      -   5        $ GridAdd��5�      $��0��6W   $��
10,10,10,0q�6e   $��Stretch=�6y   y�6,   �� $ MuestraGridAdd� 5�      �� 5�      $��* �6/   �� 5�      $
��auto �6/   .+�5�      � $��0��6    6/   �� *NuevaCuenta+ 5�      �� 5�   "   $
��auto �60   �� 5�   "   $
��auto �60    5�      �� 5�   "   $
��auto �63   �� 5�   "   $��* �63   �� 5�   "   $
��auto �63   �� 5�   "   $��* �63   �� 5�   "   $
��auto �63   �� 5�   "   $��* �63   .+�5�      �� $��
ID Padre :��6$   $��0��69   $��0��6F   $��3,3,0,3q�6W   $��Center=�6h   �� 5�      $��
Fecha C. :��6$   $��1��69   $��0��6F   $��3,3,0,3q�6W   $��Center=�6h   �� 5�      $
{�True��6A   $��0��6R   $��3,3,0,3q�6_   $��1��6p   $��Bottom=�6�   $��15(�6�   $��30��6�   ��6(   �� $ ID�6�   (  "System.Windows.Controls.DatePicker  5�      $��1��6)   $��1��66   $��Center=�6z     MahApps.Styles.DatePicker#��[ 6�       Text  6F   �� $ FechaModificacion�$ TwoWay=�6�   �� 5�      $��Nombre :��6$   $��0��67   $��2��6D   $��3,3,0,3q�6U   $��Center=�6f   �� 5�      $��Estado :��6$   $��1��67   $��2��6D   $��3,3,0,3q�6U   $��Center=�6f   �� 5�      $��0��6O   $��3,3,0,3q�6\   $��3��6m   #��[ 6}   $��Bottom=�6�   $��15(�6�   ��6&   �� $ Nombre�$ TwoWay=�6�   �� 5�      $��1��6'   $��3��64   $��15(�6D   $��0 3 0 3q�6�   $��Center=�6�    6R   �� $ Indice�$ TwoWay=�.@�5�   "   �� $��Inactiva��6/   $��15(�6B   �� 5�   "   $��Activa��6/   $��15(�6@   $
 True��6N   5�      �� 5�      $��Descripcion :��6$   $��0��6<   $��4��6I   $��3,3,0,3q�6Y   $��Center=�6j   �� 5�      $��Saldo Inicia :��6$   $��1��6=   $��4��6J   $��3,3,0,3q�6[   $��Center=�6l   �� 5�      $��0��6T   $��5��6a   #��[ 6q   $��Center=�6�   $��30��6�   ��6&   �� $ Descripcion�$ TwoWay=�6�   �� 5�      $��1��6N   $��5��6[   #��[ 6k   $��Center=�6�   $��30��6�   $��15(�6�   ��6&   �� $ Saldo�$ TwoWay=�6�   5�      �� 5�      $��1��6%   $��80��65   $ Vertical=�6A   $��10 0 0 0q�6X   $��Right=�6j   .+�5�      �� $��0 2 0 0q�6%   $��50��66   $��30��6A   ��6M   �� *CommandCancel+.��5�   "     $ Close=�6:   $��20��6I   $��20��6T   
���  ��$��Center=�6q   $��Center=�6�   5�      �� 5�      $��0 12 0 0q�6%   $��50��67   $��30��6B   ��6N   �� *	CommandOk+.��5�   "     $ Check=�6:   $��20��6I   $��20��6T   
����  �$��Center=�6r   $��Center=�6�   5�      5      5     � 5     $��1��6   .+�5     �� -   5        ! ��Name$! MuestraCuenta��5  !   #��[ 6U   $��Mostrar Catalogo��6{   $��40��6�   $	��200��6�   $��Center=�6�   $��Center=�6�   y�68   �� *Boton+��6�   �� *CommanCargarCuenta+)   #MahApps.Metro.Controls.ProgressRing  5     -   5        "  Name$" Progreso��5  K   
����  �#   IsActive$
# True��6o   $��Center=�6   $��Center=�6�   y�6+   �� *
Progreso+6�   &   System.Windows.Controls.DataGrid  5     -   5        $  Name$$ MyGrid��5  #     MahApps.Styles.DataGrid#��[ 6�   $��0 10 0 0q�6�   %   SelectionUnit$% FullRow=�6�   &   SelectionMode$& Single=�6  '   AutoGenerateColumns$' False��6  (   CanUserAddRows$( false��6;  $
{�True��6T  )   
IsReadOnly$
) True��6g  *   EnableRowVirtualization$
* True��6y  $
��auto��6�  +   RowDetailsVisibilityMode$+ VisibleWhenSelected=�6�  y�63   �� *Tabla+��6Q   �� *ListaCuenta+$ TwoWay=�, �� UpdateSourceTrigger$, PropertyChanged=�-   Columns- 5     0  *System.Windows.Controls.DataGridTextColumn  5	  "   -	   5        ID_CuentaColumn��,  &System.Windows.Controls.DataGridColumn.   Header$. 	ID Cuenta��5	  o   /   Width5	  /System.Windows.Controls.DataGridLengthConverter$/ SizeToHeader	 6�   1
  +System.Windows.Controls.DataGridBoundColumn0 
  Binding0 6P   �� *
IdCuenta+6�     5
  "   -
   5        ID_PadreColumn��$. ID Cuenta Padre��5
  m   $/ SizeToHeader	 6�   0 6O   �� *	IdPadre+6�     5  "   -   5        NombreCuentaColumn��$. Nombre��5  w   $	/ 400	 6�   0 6S   �� *NombreCuentaC+6�     5  "   -   5        NivelColumn��$. Nivel��5  i   $/ SizeToHeader	 6z   0 6L   �� *NivelC+6z     5  "   -   5        AuxiliarColumn��$. Codigo Cuenta��5  n   $/ SizeToHeader	 6�   0 6O   �� *
Auxiliar+6�   4  .System.Windows.Controls.DataGridCheckBoxColumn  5  "   -   5        EstadoColumn��$. Estado��5  j   $/ SizeToHeader	 6z   0 6O   �� *Estado+6z   1 � ContextMenu1 5     �� 5  "     MahApps.Styles.ContextMenu#��[ 6.   .@�5  &   m� $��Editar Cuenta��6/   2 m� Command2 6F   �� *CommandEdit+3 m� CommandParameter3 6f   �� 4 �� RelativeSource4 �� *FindAncestor+5 �� AncestorType"5 ��$" PlacementTarget.SelectedItem�6 m� Icon6 5  *     5  .   $ EditOutline=�6F   $��25��6[   $��25��6f   
���   �6r   5  '   m� 5  &   $��Agregar Cuenta��6/   2 6G   �� *	CommanAdd+3 6e   �� 4 �� *FindAncestor+"5 ��$" PlacementTarget.SelectedItem�6 5  *     5  .   $	 Add=�6F   $��25��6S   $��25��6^   
���   �6j   5  '   5  #   5     5     5"     5#     �� 5%     $��Comprobantes Contables��6   .��5&     � -   5        $ ViewComprobante��5&     $��0 10 0 0q�60   
�������.+�5(     � -   5        $ Gridprincipal��5(     y�62   �� *GridComprobanteContable1+7 �� NotifyOnSourceUpdated$
7 True��8 �� NotifyOnTargetUpdated$
8 True�� 5*     �� 5+     $
��AUTO �6,   �� 5,     $��* �6,   .+�50     � -   5        $ ComprobanteA��50     $��0��65    51     �� 52  "   $��* �63   �� 53  "   $��* �63   .+�56     �� -   5        $! CambioA��56  %   $	��220��66   $��50��6B   $��Right=�6N   $��1��6k   #��[ 6{   $��Nuevo Comprobante��6�   $��0 5 10 0q�6�   ��6�   �� *ComprobanteVisible+6�   57     � 59     $��1��6   .+�5:     (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   5        9  Name$9 AsientoContableDataGrid��5:  4   $��Stretch=�6�   $��Stretch=�6�   (  "Syncfusion.UI.Xaml.Grid.SfGridBase:   SelectionMode$
: None=�6�   $
{�True��6	  $��10 20 10 20q�6  ;   ColumnSizer$
; Star=�62  <   AllowResizingColumns$
< True��6F  =   AllowFiltering$
= True��6b  >   ItemsSource> 6U   �� *ListaAsientoContable+$ TwoWay=�$, PropertyChanged=�?   Columns? 5<  &   /  )Syncfusion.UI.Xaml.Grid.GridNumericColumn  ,  &Syncfusion.UI.Xaml.Grid.GridColumnBase@   MappingName$@ 	IdAsiento��6C   A   
HeaderText$A 
ID Asiento��6^   B   NumberDecimalDigits$B 0��6y     5=  &   $@ 	IdUsuario��6C   $A 
ID Usuario��6^   $B 0��6y   0  *Syncfusion.UI.Xaml.Grid.GridDateTimeColumn  5>  &   $@ FechaRegistro��6D   $A Fecha Registro��6b   ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  5?  &   $@ Descripcion��6@   $A Descripcion��6]   5A     5B     5C     � 5E     -   5        $ Gridsecundario��5E     y�63   �� *GridComprobanteContable2+$
7 True��$
8 True�� 5F     �� 5G     �� 5H     $
��AUTO �6/   $	��302��6<   .+�5K     � $��0��6    5M     �� 5N  "   $
��AUTO �60   �� 5O  "   $��* �60   .+�5R     � $��0��6#    5S  "   �� 5T  &   $
��Auto �67   �� 5U  &   $��* �67   �� 5V  &   $
��Auto �67    5Y  "   �� 5Z  &   $
��AUTO �64   �� 5[  &   $
��AUTO �64   .+�5^  "   �� $��Fecha :��6(   $��0��6:   $��0��6G   $��0 2 0 0q�6W   $��16(�6h     5_  "   -   5        C  Name$C Fecha_registro��5_  -   $��0��6E   $��1��6R   $��0 2 80 0q�6b    6u   �� *ClaseD+  6�   �� *Date+$ TwoWay=��� 5`  "   $��Descripcion :��6(   $��1��6@   $��0��6M   $��	0 10 0 20q�6^   $��16(�6q   �� 5a  "   -   5        $ Descripcion_Comprobante��5a  *   $��1��6K   $��1��6X   $��	0 10 0 20q�6h    6{   �� *ClaseD+��6�   �� *Text+$ TwoWay=�5b     � 5d     $��1��6#    5f  "   �� 5g  &   $��* �64   �� 5h  &   $
��Auto �64   $��80��6B   .+�5k  "   � $��0��6'   .+�5l  &     -   5        $$ 	Prubadata��5l  /   #��[ 6�   $��0 10 0 0q�6�   $
% Cell=�6�   $& Single=�6�   $' False��6  $( false��6+  $
{�True��6D  $
* True��6X  $
��auto��6y  $+ VisibleWhenSelected=�6�  ��6B   �� *ClaseD.Rezo+$ TwoWay=�$, PropertyChanged=�. 	 (System.Windows.Interactivity.InteractionD   TriggersD 5m  *   / 	 )System.Windows.Interactivity.EventTrigger  5n  .   E   	EventName$E CellEditEnding��6=   . 	 (System.Windows.Interactivity.TriggerBaseF   Actions.F 5o  2   6 	 0System.Windows.Interactivity.InvokeCommandAction  G   CommandG 6H   �� *	SumarDebe+5p  /   - 5r  *   4  .System.Windows.Controls.DataGridTemplateColumn  5s  .   H   CellTemplateH 5t  2   �� 5u  6   .R�5v  :   �� $! DeleterMovButton��6B   ���	#00000000���	#00000000$��0q�6�   ��6�   �� I �� SourceI %  System.Windows.Markup.Reference  *	Prubadata+$ DataContext.EliminarMov���6�   �� .��5w  >     $ Delete=�6V   $��Stretch=�6d   $��Stretch=�6�   5x  ;   5y  7   5{  /     5|  .   $. 	Id Cuenta��6A   J   
IsReadOnly$
J True��6�   0 6T   �� *	Id_Cuenta+$ TwoWay=�$, PropertyChanged=�6�     5}  .   $. Nombre Cuenta��6A   $
J True��6�   $/ *	 6�   0 6X   �� *Nombre_CuentaC+$ TwoWay=�$, PropertyChanged=�6�     5~  .   $
. Debe��6A   $J False��6�   $	/ 100	 6�   0 6O   �� *Debe+$ TwoWay=�$, PropertyChanged=�6�     5  .   $. Haber��6A   $J False��6�   $	/ 100	 6�   0 6P   �� *Haber+$ TwoWay=�$, PropertyChanged=�6�   5�  '   5�  #   � 5�  "   $��1��6'    5�  &   �� 5�  *   $
��Auto �6;   �� 5�  *   $��* �6;   .+�5�  &   � $��0��6+    5�  *   �� 5�  .   $��* �6?   �� 5�  .   $��* �6?    5�  *   �� 5�  .   $��* �6<   �� 5�  .   $��* �6<   .+�5�  *   �� -   5        $! Registro��5�  1   $��	Registrar��6C   $��0��6W   $��0��6g   $��	10 0 10 0q�6t   $��0q�6�   
������ 
������ $��15(�6�   ��6�   �� *RegistrarMov+�� 5�  *   -   5        $! Borrar_todo��5�  1   $��Borrar todo��6F   $��1��6\   $��0��6l   $��	10 0 10 0q�6y   $��0q�6�   
������ 
������ $��15(�6�   ��6�   �� *
BorrarTodo+�� 5�  *   -   5        $! Cancelar��5�  1   $��Cancelar��6C   $��0��6V   $��
10,65,10,0q�6f   
������ 
������ $��15(�6�   $��2��6�   $��2��6�   ��6�   �� *	Cancelado+5�  '   � 5�  &   $��2��6+    5�  *   �� 5�  .   $��* �6<   �� 5�  .   $��* �6<   .+�5�  *   � $��0��6/    5�  .   �� 5�  2   $��* �6C   �� 5�  2   $��* �6C    5�  .   �� 5�  2   $��* �6@   �� 5�  2   $��* �6@   .+�5�  .   �� -   5        $ 
Total_Debe��5�  6   $��0��6J   $��0��6Z   $��	5 10 5 10q�6g   K �� 
IsReadOnly$
K True��6z    6�   �� *ClaseD+��6�   �� *
Sumadebe+�� 5�  .   $��
Total Debe��64   $��0��6I   $��1��6Y   �� 5�  .   -   5        $ Total_Haber��5�  6   $��1��6K   $��0��6[   $��	5 10 5 10q�6h   $
K True��6{    6�   �� *ClaseD+��6�   �� *	Sumahaber+�� 5�  .   $��Total Haber��64   $��1��6J   $��1��6Z   5�  +   5�  '   5�  #   5�     5�     � 5�     $��1��6   $��Center=�6/   .+�5�       -   5        $$ firstDataGrid��5�  '   $' False��6>   $& Single=�6Z   $��	0 10 0 10q�6q   L   CanUserResizeColumns$L False��6�   $+ VisibleWhenSelected=�6�   $( False��6�   ��6�   �� *ListaCuentaContable+- 5�  "     5�  &   H 5�  *   �� 5�  .   .R�5�  2   �� $! AgregarMovButton��69   ���	#00000000���	#00000000$��0q�6�   ��6�   �� ��6�   �� I   *firstDataGrid+$ DataContext.MoverCuenta�.��5�  6     $ Cross=�6N   $��Stretch=�6[   $��Stretch=�6y   5�  3   5�  /   5�  '     5�  &   $. 	Id Cuenta��69   $
J True��6j   $	/ 100	 6|   0 6L   �� *	Id_Cuenta+6|     5�  &   $. Cuenta��69   $
J True��6l   $	/ 120	 6~   0 6I   �� *Nombre_CuentaC+M   	CellStyleM 5�  *   �� 5�  .   *  $System.Windows.Controls.DataGridCell"  64   .�5�  2   ��  �@�ToolTip 6M   �� $ Nombre_CuentaC�5�  /   5�  '   5�     5�     5�     5�     5�     �� 5�     $��Libro Diario��6   5�     �� 5�     $��Reporte Contable��6   .��5�     �  5�     �� 5�     $��* �6+   �� 5�     $��* �6+    5�     �� 5�     $��* �6(   �� 5�     $��* �6(   .+�5�     � $��0��6   $��0��6(   
�������$��5q�6O   .+�5�       5�     5�     5�     5�     5�     5�     5     