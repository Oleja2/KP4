   M S B A M L   `   `   `  ����@  <Hotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Hotel.ViewsHotel.Views  5      !    Hotel.Views.ApplicationPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Hotel.Views     5        N� Title$  ApplicationPage��5	       N� FontSize$ 14(�6    N� 
FontFamily$ Arial)�6-    � 	Resources 5
         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1	 �� 
TargetType
 �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%J  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E    . $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   "	 ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5        � ��8  6,   �� 5!       � ��# � ��6+   �� 5"       � ��$ 1q�60   �� 5#       � ��$ Center=�6;   �� 5$       � ��$ Center=�69   �� 5%       � ��$ 1q�6(   �� 5&       � �� 5'      �� 5(      "
 ��6&   .R�5)      �� $ border��6!   $ 10��61   #��z��6C   #��z��6m   #��z��6�    . ._�5*      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5+       5,      P� 5-       �@��IsDefaulted . . �5.   "   �� $ border��6@   # � ��6T    � ��5/      P� 50       �@J�IsMouseOver . . �51   "   �� $ border��6?   8   � ��6S   �� 52   "   $ border��6@   8   � ��6T   53      P� 54       � �� . . �55   "   �� $ border��6?   8   � ��6S   �� 56   "   $ border��6@   8   � ��6T   57      P� 58       � {� .  . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   �� 5;   "   $ contentPresenter��6K   8 	  � ��6i   5<      5>      5@      5A      5B      .��5D      � .+�5E   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ApplicationPG��5E   S   $��
30,0,30,75q�6   ���	#997D7676
���   �   
IsReadOnly .    AutoGenerateColumns .     Columns 5G      0  *System.Windows.Controls.DataGridTextColumn  5I      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6<      Width5  /System.Windows.Controls.DataGridLengthConverter$	 30* 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ID+6W     5J      $ № Комнаты��6E   $	 90* 6X    6%   �� *Room.Number+6f     5K      $ Цена за сутки��6D   $
 100* 6[    6%   �� *
Room.Price+6j     5L      $% Категория номера��6G   $
 130* 6a    6%   �� *Room.Category+6p     5M      $ ФИО гостя��6H   $
 170* 6[    6%   �� *Guest.FullName+6j     5N      $! Номер телефона��6E   $
 120* 6]    6%   �� *PhoneNumber+6m   5Q      �� 5S   
   -   5        #��� 
 5S      ���	#99000000$��Добавить��6j   
�������
�������$��	30,0,0,39q�5T      $��23��6$   $��Bottom=�60   $
��Left=�6K   $	��113��6f   �� 5V   
   -   5        #��� 
 5V      ���	#99000000$��Удалить��6e   
�������
�������$��
160,0,0,39q�5W      $��23��6%   $��Bottom=�61   $
��Left=�6L   $	��113��6g   �� 5X   
   -   5        #��� 
 5X      ���	#99000000$��Обновить��6j   
�������
�������$��
290,0,0,39q�5Y      $��23��6%   $��Bottom=�61   $
��Left=�6L   $	��113��6g   5Z      5[      