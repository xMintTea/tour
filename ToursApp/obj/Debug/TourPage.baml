   M S B A M L   `   `   `  ����C  ?ToursApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToursAppToursApp  5          ToursApp.TourPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:ToursApp     5        N� Title$  TourPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��Center=�6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $=��7Введите название для происка: ��6   $	��175��6B    �� TextAlignment$ Right=�6N   6f   �� 5      -   5         ��Name$ TBoxSea��5   &   $	��225��6   67   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Выберите тип: ��6   $	��175��62   $ Right=�6>   6V   �� 5      -   5         ��Name$ 	ComboType��5   '   $	��225��6    �� DisplayMemberPath$
 Name��6h   5      �� 5      -   5         ��Name$ checkActual��5      $E��?Показывать только актуальные туры��6l   6�   5      �� 5   
   -   5        $��
LViewTours��5       $��1��6   $��Disabled=�62   $��Center=�6h   ��5       �� 5!      .R�5"      � $ 
Horizontal=�6    $��Center=�69   6X   5#      ��5%      �� 5&      .R�5'      � $��20q�6   $	��400��6'    5(      �� 5)      $��70 �6,   6:   �� 5*      $	��310 �6,   6;   �� 5+      $
��auto �6,   6<   �� 5,      $
��auto �6,   6<   .+�5.      �� $	��400��6    $��1��6,   $��UniformToFill=�69   $��Center=�6Q   $��5q�6n   ��5/      �� 50   "   	 �� Path$	 ImagePreview�6*   
 �� TargetNullValue
 51   &   ��52   *   Resources/no_image.jpg��6N   54   #   56      �� 57      $��Center=�6:   $ Center=�6U   $	��390��6l   $
��Wrap=�58   $   $��Center=�68   $	��5 5q�6U   $��26(�6b   $��0��6p   ��57   $   �� *Name+58      �� 59      $��2��6W   $��5 5 5 15q�6d   $��Center=�6v   $��26(�6�   $
��Bold"�6�   ��6$   �� *Price+ �� StringFormat$ {0:N2} РУБ��6�   �� 5:      $��3��6g   $��14(�6t   $��Right=�6�   ��6$   �� *TicketCount+$* $Билетов осталось: {0}��6�   �� 5;      $��3��6@   $��14(�6M   $
��Left=�6[   ��6$   �� *
ActualText+6x   5<      5=      5?      5@      5A      