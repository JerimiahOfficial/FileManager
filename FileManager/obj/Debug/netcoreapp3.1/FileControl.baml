   M S B A M L   `   `   `  ����F  BFileManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FileManagerFileManager  5          FileManager.FileControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:FileManager     5      -   5          � 	Resources  5
         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 FMButton �� 
TargetType �� 
TargetType ��Name	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName��%v  &	        &	 �     &	 �     &	 �     &	     &	 7    &	 X    &	 y    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   $
 true��6E   $��1��6`   #��� ��6t   5      5      5      �� 5   
   $ #202020��6;   �� 5   
   $ #202020��67   �� 5   
   $ #333333��6>   �� 5   
   $ #333333��6:   �� 5   
   $ #181818��6<   �� 5   
   $ #181818��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ white��6=   �� 5   
   " ��6!   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5        � ��8  6,   �� 5!       � ��# � ��6+   �� 5"       � ��$ 1q�60   �� 5#       � ��$ Center=�6;   �� 5$       � ��$ Center=�69   �� 5%       � ��$ 1q�6(   �� 5&       � �� 5'      �� 5(      " ��6&   .R�5)      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   $
 true��6�   ._�5*      �� $	 contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5+      
 5,      P� 5-       �@��IsDefaulted$
 true��6=   . �5.   "   �� $ border��6@   # � ��6T    � ��5/      P� 50       �@J�IsMouseOver$
 true��6=   . �51   "   �� $ border��6?   8   � ��6S   �� 52   "   $ border��6@   8   � ��6T   53      P� 54       � ��$
 true��6;   . �55   "   �� $ border��6?   8   � ��6S   �� 56   "   $ border��6@   8   � ��6T   57      P� 58       � {�$ false��6;   . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   �� 5;   "   $ contentPresenter��6K   8 	  � ��6i   5<      5>      5@      5A      5B      .��5C      � ���#202020.+�5D   
   ]� .+�5E      �� -   5         ��Name$ FileName��5E      $��	File Name��6&   
�������$	��620��6M   $
��Left=�6Y   �� 5F      -   5         ��Name$ OpenLoc��5F   8   #��� 
 6   $��30��6I   $
��Left=�6T   .��5G      �� .+�5H      �� $-��'pack://application:,,,/icons/Search.png��6   $��15��6M   $��15��6X   5I      5J      �� 5K      -   5        $ OpenFile��5K   8   #��� 
 6   $��30��6J   $
��Left=�6U   .��5L      �� .+�5M      �� $+��%pack://application:,,,/icons/Open.png��6   $��15��6K   $��15��6V   5N      5O      �� 5P      -   5        $ 
RenameFile��5P   8   #��� 
 6   $��30��6L   $
��Left=�6W   .��5Q      �� .+�5R      �� $-��'pack://application:,,,/icons/Rename.png��6   $��15��6M   $��15��6X   5S      5T      �� 5U      -   5        $ CopyFile��5U   8   #��� 
 6   $��30��6J   $
��Left=�6U   .��5V      �� .+�5W      �� $+��%pack://application:,,,/icons/Copy.png��6   $��15��6K   $��15��6V   5X      5Y      �� 5Z      -   5        $ 
DeleteFile��5Z   8   #��� 
 6   $��30��6L   $
��Left=�6W   .��5[      �� .+�5\      �� $-��'pack://application:,,,/icons/Delete.png��6   $��15��6M   $��15��6X   5]      5^      5_      5`      5a      