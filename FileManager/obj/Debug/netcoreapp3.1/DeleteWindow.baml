   M S B A M L   `   `   `  ����F  BFileManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FileManagerFileManager  5   	       FileManager.DeleteWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:FileManager     5   	     � Title$  Delete Window��5   	   $	��105��5	   	   $	��300��5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background	 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 FMButton
 �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%v  &	        &	 �     &	 �     &	 �     &	     &	 7    &	 X    &	 y    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5   
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
 true��6;   . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   5;      P� 5<       � {�$ false��6;   . �5=   "   �� $ border��6?   8   � ��6S   �� 5>   "   $ border��6@   8   � ��6T   �� 5?   "   $ contentPresenter��6K   8 	  � ��6i   5@      5B      5D      5E      5F      .��5G      � .+�5H   
   ]� .+�5I      � -   5        ���#202020$	��Top=�5I   -   $��30��6B   .+�5J      �� $��icons/Delete.png��6   $��15��62   $��15��6=   $	��7.5q�6I   �� 5K      $��Delete File(s)��6   
�������61   5L      � 5M      ���#181818.+�5N      �� $/��)Are you sure you want to want to do this?��6   
�������$��Center=�6_   $��5q�6�   �� 5O      -   5         ��Name$ No��5O   <   #��� 
 6   $	��140��6H   $��30��6T   $��5q�6`   $��No��6k   
�������6�   �� 5P      -   5        $	 Yes��5P   <   #��� 
 6   $	��140��6I   $��30��6U   $��5q�6a   $	��Yes��6l   
�������6�   5Q      5R      5S      5T      