   M S B A M L   `   `   `  ����L  HAircrafts_WithLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Aircrafts_WithLibAircrafts_WithLib  5   	   "    Aircrafts_WithLib.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Aircrafts_WithLib     5   	     � Title$<  6Получение библиотеки классов��5   	   $	��450��6.   $	��800��6;   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   $��36��6*   �� 5      �� 5      .+�5   
   �� $��0��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��5,5,5,5q�6K   .+�5   
   �� -   5         ��Name$ BrowseButton��5      $)��#Выбрать библиотеку��6'   $��5,5,5,5q�5      5      �� 5   
   $��1��6   $��1��6"   $ 
Horizontal=�62   $��5,5,5,5q�6K   .+�5      �� $��1��6   $$��Выбранный класс:��6(   $��Center=�6@   $��0,0,5,0q�6[   �� 5      -   5         ��Name$ ClassListBox��5      $��0,0,5,0q�6-   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6>   $	��130��6c   5      �� 5      $ 
Horizontal=�6   $��0��62   $��0,5,0,0q�6?   .+�5      �� -   5         ��Name$ ConstructorStackPanel��5      �� 5      -   5        $ ExecuteConstructorButton��5      $��Выполнить��6;   $��5,0,0,0q�5       ${�False��6*   5!      5"      � 5$   
   $��2��6   $��1��6   $��5,5,5,5q�6,    5%      �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    �� 5(      $��* �6    .+�5+      �� $ 
Horizontal=�6   $��1��62   $��0,5,0,0q�6?   .+�5,      �� $��Методы:��6   $��Center=�6+   $��0,0,5,0q�6F   �� 5-      -   5        $ MethodComboBox��5-      $��0,0,5,0q�63   $	��200��6D   5.      �� 5/      -   5        $ ExecuteMethodButton��5/      $��Выполнить��66   $��5,0,0,0q�50      ${�False��6*   51      �� 53      $ 
Horizontal=�6   $��3��62   $��0,5,0,0q�6?   .+�54      �� $(��"Параметры методов:��6   $	��Top=�66   $��0,0,5,0q�6N   �� 55      -   5        $ MethodParameterStackPanel��55      $	��250��6@   56      57      58      59      