   M S B A M L   `   `   `  ����C  ?MetroApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MetroApp.ThemesMetroApp.Themes  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 %  !TreeViewExpandCollapseToggleStyle  �� 
TargetType �� Property �� Value �� 
TargetType F�Name    MetroApp.Themes.BrushKeys    TreeViewExpandBrushKey �� Triggers P� Property P� Value	 �� 
TargetName
 �� Angle �� CenterY �� CenterX%    TreeViewExpandDisabledBrushKey ]� 
Conditions �� Property �� Value&    TreeViewExpandMouseOverBrushKey  TreeViewItemFocusVisual     TreeViewItemFocusBrushKey �� StrokeDashArray J� Opacity  MetroTreeViewItem%    TreeViewItemForegroundBrushKey%    TreeViewItemBackgroundBrushKey ��Name �� Padding J� SnapsToDevicePixels � ColumnDefinitions d�Name �� 	ClickMode d� 	IsChecked �� Path �� TemplatedParent  �� RelativeSource! �� Mode" ��Name# ��Name$ � LayoutTransform% �� ScaleY& P� 
SourceName.'    'TreeViewItemMouseOverBackgroundBrushKey.(    'TreeViewItemMouseOverForegroundBrushKey-)    &TreeViewItemSelectedBackgroundBrushKey-*    &TreeViewItemSelectedForegroundBrushKey-+    &TreeViewItemDisabledForegroundBrushKey5,    .TreeViewItemDisabledSelectedBackgroundBrushKey5-    .TreeViewItemDisabledSelectedForegroundBrushKey2.    +TreeViewItemSelectionActiveSelectedBrushKey  MetroTreeView/    TreeViewBorderBrushKey!0    TreeViewBackgroundBrushKey%1    TreeViewDisabledBorderBrushKey�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      (Themesclr-namespace:MetroApp.Themes  5      %~  &	        &	 F    &	 &    7  7   &	     7  �� 5	      "  d�5
      .�5   
   ��  � |� .  5      �� 5   
    � ��$ 16��5      �� 5   
    � ��$ 16��5      �� 5   
    � �� 5      �� 5      " d�6"   .R�5      � 
������ $��16��5      $��16��5      .+�5      F� $ 
ExpandPath��6   $��Center=�5      $��Center=�5      "���� 	=     � z  	= � 	=  z 	
������ $��1��5      #���  5      5       5      P� 5        �@d�	IsChecked$
 TrueY�5!   "   . �5"      �� $	 
ExpandPath��5#   %    � z� 5$   "   �� 5%   &   $
 45Q�66   $ 4Q�5&   6   $ 4Q�5'   6   5)      �� 5*      $	 
ExpandPath��5+   %   # �  5,   %    � ���� 5-      $	 
ExpandPath��5.   %   # �  5/   %    � ��50      P� 51       � {� .  . �53      �� $	 
ExpandPath��54   %   # �  55   %    � ��56      ]� 57       58      �� 59   "    � {� .  5:   ,   �� 5;   "    �@d�	IsChecked$
 TrueY�5<   ,   ./�5>      �� $	 
ExpandPath��5?   %   # �  5@   %    � ���� 5A      $	 
ExpandPath��5B   %   # �  5C   %    � ��5D      P� 5E       �@J�IsMouseOver . . �5G      �� $	 
ExpandPath��5H   %   # �  5I   %    � ���� 5J      $	 
ExpandPath��5K   %   # �  5L   %    � ��5M      5O      5Q      5R      �� 5T      .�5U   
   ��  � �� 5V      �� 5W      .R�5X      �� ._�5Y      �� $��0,0,0,0q�6$   $��5��5Z   $   #���  5[   $   $	 1 2R�5\   $   $ 0Q�5]   $   5^      5_      5a      5b      �� 5d      "  Q�5e      .�5f   
   ��  � ��$ 22��5g      �� 5h   
    � ��# �  5i      �� 5j   
    � ��# �  5k      �� 5l   
    �@�FocusVisualStyle8   5m      �� 5n   
    �@J�SnapsToDevicePixels . 5o      �� 5p   
    � �� 5q      �� 5r      " Q�6"   .R�5s      �� .+�5t      �� $ Border��6!   #��z��5u   !   #��z��5v   !   #��z��5w   !   # z��5x   !   #��z��5y   !   # z 5z   !   ._�5{      � $��Stretch=�6#    5|   "   �� 5}   &   $��19 �67   �� 5~   &   $��* �67   .+�5�   "   d� $ Expander��6/   8�� $ Press=�5�   /    5�   /   �� $ 
IsExpanded�#  Z $! TwoWay=�5�   /   �� 5�   "   $" PART_Header��63   $��1��5�   3   $��Header��5�   3   # z 5�   3   #��z��5�   3   #��z��5�   3   5�      5�      �� 5�      $# 	ItemsHost��6)   $ 5�      �� 5�   "   $% 1Q�61   5�      5�       5�      P� 5�       �@Q�
IsExpanded .  . �5�      �� $	 	ItemsHost��6%    � y�$ 	Collapsed=�5�   %   5�      P� 5�       �@��HasItems .  . �5�      �� $	 Expander��6%    � y�$ Hidden=�5�   %   5�      P� 5�      $& Border��6"    �@J�IsMouseOver . . �5�      �� $	 Border��6%   # � ' 5�   %    � ���� 5�      # � ( 5�   %    � ��5�      P� 5�       �@Q�
IsSelected . . �5�      �� $	 Border��6%   # � ) 5�   %    � ���� 5�      # � * 5�   %    � ��5�      P� 5�       � {� .  . �5�      �� # � + 5�   %    � ��5�      ]� 5�       5�      �� 5�   "    � {� .  5�   ,   �� 5�   "    �@Q�
IsSelected . 5�   ,   /�5�      �� 5�   "   $	 Border��6)   # � , 5�   )    � ���� 5�   "   # � - 5�   )    � ��5�      ]� 5�       5�      �� 5�   "    �@Q�
IsSelected . 5�   ,   �� 5�   "    �@��IsSelectionActive . 5�   ,   ./�5�      �� $	 Border��6%   # � . 5�   %    � ��5�      5�      5�      5�      �� 5�      "  R�5�      .�5�   
   ��  � ��# � / 5�      �� 5�   
    � ��# � 0 5�      �� 5�   
    � ��$ 0q�5�      �� 5�   
    �@J�SnapsToDevicePixels . 5�      �� 5�   
    � �� 5�      �� 5�      " R�6"   .R�5�      �� $��Border��6   #��z��5�      #��z��5�      #��z��5�      ._�5�      �� .��5�      �� 5�      5�       5�      P� 5�       � {� .  . �5�      �� $	 Border��6%   # � 1 5�   %    � ��5�      5�      5�      �� 5�   
    � ��8   5�      5�      5�      