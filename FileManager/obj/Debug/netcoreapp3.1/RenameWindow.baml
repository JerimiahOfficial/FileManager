   M S B A M L   `   `   `  ����F  BFileManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FileManagerFileManager  5   	       FileManager.RenameWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:FileManager     5   	     � Title$  Rename Window��5   	   $	��105��5	   	   $	��300��5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background	 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 FMButton
 �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName  TextBox.Static.Border1  TextBox.MouseOver.Border1  TextBox.Focus.Border1  	FMTextBox-  'System.Windows.Input.KeyboardNavigation ��Name �� Triggers ]� 
Conditions �� Property �� Value��%X  &	        &	 �     &	 �     &	 �     &	     &	 7    &	 X    &	 y    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 &	 �    &	     &	 "    &	 C    �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5      5      5      �� 5   
   $	 #202020��6;   �� 5   
   $	 #202020��67   �� 5   
   $	 #333333��6>   �� 5   
   $	 #333333��6:   �� 5   
   $	 #181818��6<   �� 5   
   $	 #181818��68   �� 5   
   $	 	#FFF4F4F4��6=   �� 5   
   $	 	#FFADB2B5��69   �� 5    
   $	 white��6=   �� 5!   
   "
 ��6!   .�5"      ��  �@�FocusVisualStyle8   61   �� 5#       � ��8  6+   �� 5$       � ��8  6,   �� 5%       � ��# � ��6+   �� 5&       � ��$ 1q�60   �� 5'       � ��$ Center=�6;   �� 5(       � ��$ Center=�69   �� 5)       � ��$ 1q�6(   �� 5*       � �� 5+      �� 5,      " ��6&   .R�5-      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   $
 true��6�   ._�5.      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5/       50      P� 51       �@��IsDefaulted$
 true��6=   . �52   "   �� $ border��6@   # � ��6T    � ��53      P� 54       �@J�IsMouseOver$
 true��6=   . �55   "   �� $ border��6?   8   � ��6S   �� 56   "   $ border��6@   8   � ��6T   57      P� 58       � ��$
 true��6;   . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   5;      P� 5<       � {�$ false��6;   . �5=   "   �� $ border��6?   8   � ��6S   �� 5>   "   $ border��6@   8   � ��6T   �� 5?   "   $ contentPresenter��6K   8 	  � ��6i   5@      5B      5D      5E      �� 5F   
   $	 #202020��69   �� 5G   
   $	 #202020��6<   �� 5H   
   $	 #202020��68   �� 5I   
   "
 ��6"   .�5J      ��  � ��# � ��6+   �� 5K       � �� �#2020206,   �� 5L       � ��# � ��6+   �� 5M       � ��$ 1q�60   �� 5N       �@ TabNavigation$
 None=�6A   �� 5O       � ��$
 Left=�6;   �� 5P       �@�FocusVisualStyle 61   Z� �� 5Q       �@J�	AllowDrop$
 true��6*   �� 5R       �@��PanningMode$ VerticalFirst=�69   �� 5S       �@��IsFlicksEnabled$ False��67   �� 5T       � �� 5U      �� 5V      " ��6&   .R�5W      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   $
 True��6�   ._�5X      �� $ PART_ContentHost��6+   $|�false��6E   $��Hidden=�6W   $��Hidden=�6~   5Y       5Z      P� 5[       � {�$ false��6;   . �5\   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5]      P� 5^       �@J�IsMouseOver$
 true��6=   . �5_   "   �� $ border��6@    � �� �#2020206T   5`      P� 5a       �@J�IsKeyboardFocused$
 true��6C   . �5b   "   �� $ border��6@    � �� �#2020206T   5c      5e      5g       5h      ]� 5i       5j      �� 5k      + �@��#IsInactiveSelectionHighlightEnabled$
 true��6S   �� 5l       �@��IsSelectionActive$ false��6A   ./�5n      ��  �@��SelectionBrush# � /�67   5o      5q      5r      .��5s      � .+�5t   
   ]� .+�5u      � -   5        ���#202020$	��Top=�5u   -   $��30��6B   .+�5v      �� $��icons/Rename.png��6   $��15��62   $��15��6=   $	��7.5q�6I   �� 5w      $��Rename File(s)��6   
�������61   5x      � 5y      ���#181818.+�5z      � $	��290��6   $��30��6#   $��5 5 5 0q�6/   .+�5{      �� -   5         ��Name$ InputTextBox��5{   B   #���  6   ���#202020
�������$��Center=�6�   5|      �� 5}      -   5         ��Name$ Cancel��5}      #��� 
 6)   $	��140��6L   $��30��6X   $��5q�6d   $��Cancel��6o   
�������6�   �� 5~      -   5        $ Rename��5~      #��� 
 6)   $	��140��6L   $��30��6X   $��5q�6d   $��Rename��6o   
�������6�   5      5�      5�      5�      