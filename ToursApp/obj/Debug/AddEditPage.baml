   M S B A M L   `   `   `  ����C  ?ToursApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToursAppToursApp  5          ToursApp.AddEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:ToursApp     5        N� Title$  AddEditPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Название��6   6&   �� 5   
   $%��Количество звёзд��6   $��1��6,   6;   �� 5   
   $��Страна��6   $��2��6"   61   �� 5   
   $��1��6(    �� 	MaxLength$	 100��68   $��50��6H   ��6   �� *Name+6Y   �� 5   
   $��1��60   $	��175��6@   $��50��6L   $
��Left=�6[   $��1��6v   ��6   �� *CountOfStars+6�   �� 5   
   -   5         ��Name$ ComboCountries��5   `   $��2��64   $��1��6A   $��50��6Q    �� DisplayMemberPath$
 Name��6x    �� SelectedItem 6   �� *	Country+6�   �� 5   
   -   5        $��saveBtn��5   F   $��Сохранить��6   $��2��6%   $��3��69   6m   5      5      