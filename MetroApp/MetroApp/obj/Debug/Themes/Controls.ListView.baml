   M S B A M L   `   `   `  ����C  ?MetroApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MetroApp.ThemesMetroApp.Themes  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 "  MetroGridViewScrollViewerStyle  �� 
TargetType �� BasedOn �� Property �� Value �� 
TargetType J� SnapsToDevicePixels � ColumnDefinitions � RowDefinitions �� AllowsColumnReorder	 �� RelativeSource!
 �� ColumnHeaderContainerStyle �� ColumnHeaderToolTip �� ColumnHeaderStringFormat �� ColumnHeaderContextMenu �� ColumnHeaderTemplate �� Columns# �� ColumnHeaderTemplateSelector ��Name �� CanContentScroll-   'System.Windows.Input.KeyboardNavigation    DirectionalNavigation ��Name � Cursor �� ScrollableWidth � Maximum � Minimum �� Orientation, �� %ComputedHorizontalScrollBarVisibility �� ViewportWidth �� ViewportSize � Value �� Mode �� ScrollableHeight*  �� #ComputedVerticalScrollBarVisibility! �� ViewportHeight  MetroListView   MetroApp.Themes.BrushKeys"   ListViewBorderBrushKey!#   ListViewBackgroundBrushKey$ ��Name% �� Triggers& P� Property' P� Value( �� 
TargetName%)   ListViewDisabledBorderBrushKey  VirtualisedMetroListView  MetroListViewItem%*   ListViewItemForegroundBrushKey!+   ListViewItemBorderBrushKey, � 	Resources- �� AncestorType. �� Path/ �� Triggers0 �� Binding1 �� Value-2   &ListViewItemSelectedForegroundBrushKey-3   &ListViewItemDisabledForegroundBrushKey4 ^� 
Conditions5 �� Binding6 �� Value47   -ListBoxItemDisabledSelectedForegroundBrushKey8 ��Name)9   "ListViewItemSelectedBorderBrushKey-:   &ListViewItemSelectedBackgroundBrushKey.;   'ListViewItemMouseOverBackgroundBrushKey< ]� 
Conditions= �� Property<>   5ListViewItemSelectionActiveSelectedBackgroundBrushKey8?   1ListViewItemSelectionActiveSelectedBorderBrushKey<@   5ListViewItemSelectionActiveSelectedForegroundBrushKey5A   .ListViewItemDisabledSelectedBackgroundBrushKey�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      (Themesclr-namespace:MetroApp.Themes  5      %  &	        7$�&	 �    &	 `    7  &	 k    �� 5      "  ��5      8   .�5   
   ��  � |� .  5	      �� 5
   
    � �� 5      �� 5      " ��6"   .R�5      � #��z��6    .  5      �� 5      $��* �6/   �� 5      $
��Auto �6/    5      �� 5      $��* �6,   �� 5      $
��Auto �6,   .+�5      ]� #��z��6$   .+�5      �� $	��Top=�6+   |�.  $��Hidden=�5   +   $��Hidden=�5   +   .��5   "   �� $��2,0,2,0q�5$   =   # z 5%   =    5   =   �� **(TemplatedParent.View.AllowsColumnReorder+	 �� *TemplatedParent+
 5   =   �� *1/TemplatedParent.View.ColumnHeaderContainerStyle+	 �� *TemplatedParent+ 5   =   �� **(TemplatedParent.View.ColumnHeaderToolTip+	 �� *TemplatedParent+ 5   =   �� */-TemplatedParent.View.ColumnHeaderStringFormat+	 �� *TemplatedParent+ 5    =   �� *.,TemplatedParent.View.ColumnHeaderContextMenu+	 �� *TemplatedParent+ 5!   =   �� *+)TemplatedParent.View.ColumnHeaderTemplate+	 �� *TemplatedParent+ 5"   =   �� *TemplatedParent.View.Columns+	 �� *TemplatedParent+ 5#   =   �� *31TemplatedParent.View.ColumnHeaderTemplateSelector+	 �� *TemplatedParent+5%   =   5&      �� 5'      $! PART_ScrollContentPresenter��65   # z��5(   5   #��z��5)   5   #��z��5*   5   $ Local=�5+   5   # z 5,   5   5-      �� 5.      $ PART_HorizontalScrollBar��6$   $ Arrow��5/   $   # z 50   $   $	 0.0Q�51   $   $ 
Horizontal=�52   $   $��1��53   $   #y�z 54   $   # z 56   $    55   $   �� *HorizontalOffset+$ OneWay=�	 �� *TemplatedParent+56   $   �� 57      $ PART_VerticalScrollBar��6$   $ Arrow��58   $   $��1��59   $   # z 5:   $   $	 0.0Q�5;   $   $ Vertical=�5<   $   #y�z  5=   $   # z! 5?   $    5>   $   �� *VerticalOffset+$ OneWay=�	 �� *TemplatedParent+5?   $   5O      5P      5R      5S      �� 5U      "  ��5V      .�5W   
   ��  � ��# � " 5X      �� 5Y   
    � ��# � # 5Z      �� 5[   
    � ��$ 0 1 0 0q�5\      �� 5]   
    � �� .  5^      �� 5_   
    �@��AlternationCount$ 2��5`      �� 5c   
    �@J�SnapsToDevicePixels . 5d      �� 5e   
    �@�OverridesDefaultStyle . 5f      �� 5g   
    � ��$
 Auto=�5h      �� 5i   
    � ��$
 Auto=�5j      �� 5k   
    � ��$ Center=�5l      �� 5m   
    � �� 5n      �� 5o      " ��6"   .R�5p      �� $$ Border��6   #��z��5q      #��z��5r      #��z��5s       . ._�5u      �� #��z��6'   #���   5v   '   .��5w      �� 5x      5y      % 5z      P� 5{      & �@��
IsGrouping' . . �5}      ��  � �� .  5~   %   5      P� 5�      & � {�' .  . �5�      �� $( Border��6%   # � ) 5�   %    � ��5�      5�      5�      5�      �� 5�      "  ��5�      8   .�5�   
   ��  �@%�IsVirtualizing . 5�      �� 5�   
    �@%�VirtualizationMode$ 	Recycling=�5�      �� 5�   
   " �@��IsDeferredScrollingEnabled . 5�      �� 5�   
    � �� . 5�      5�      �� 5�      "  ��5�      .�5�   
   ��  � ��# � * 5�      �� 5�   
    � ��$ Stretch=�5�      �� 5�   
    � ��$ Center=�5�      �� 5�   
    � ��$ 22��5�      �� 5�   
    � ��$ 0,0,0,0q�5�      �� 5�   
    � ��# � + 5�      �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $$ Bd��6   #��z��5�       . ._�5�      � .+�5�      �� #��z��63   , 5�   "   ���� 5�   &   '��       "  ��6,   .�5�   *   ��  � �� 5�   1   �� 	 �� "- ��$. 
Foreground�/ 5�   *   �� 5�   .   0 6:   �� $. 
IsSelected�	 �� "- ��1 True5�   :   .a�5�   2   ��  � ��# � 2 5�   9   5�   /   �� 5�   .   0 6:   �� $. 	IsEnabled�	 �� "- ��	1 False5�   :   .a�5�   2   ��  � ��# � 3 5�   9   5�   /   ^� 5�   .   4 5�   2   �� 5�   6   5 6@   �� $. 	IsEnabled�	 �� "- ��	6 False5�   @   �� 5�   6   5 6@   �� $. 
IsSelected�	 �� "- ��6 True5�   @   0�5�   2   �� 5�   6    � ��# � 7 5�   =   5�   /   5�   '   5�   #   5�      �� 5�      $8 contentPresenter��6/   $y�	Collapsed=�5�   /   5�      5�      % 5�      P� 5�      ' 5�   "   Z� & �@��ColumnCollection. �5�      �� $( contentPresenter��6%    � y�$ Visible=�5�   %   5�      P� 5�      & �@��
IsSelected' . . �5�      �� $( Bd��6%   # � 9 5�   %    � ���� 5�      $( Bd��5�   %   # � : 5�   %    � ���� 5�      # � 2 5�   %    � ��5�      P� 5�      & �@J�IsMouseOver' . . �5�      �� $( Bd��6%   # � ; 5�   %    � ��5�      ]� 5�      < 5�      �� 5�   "   = �@��
IsSelected6 . 5�   ,   �� 5�   "   = �@��IsSelectionActive6 . 5�   ,   ./�5�      �� $( Bd��5�   %   # � > 5�   %    � ���� 5�      $( Bd��5�   %   # � ? 5�   %    � ���� 5�      # � @ 5�   %    � ��5�      ]� 5�      < 5�      �� 5�   "   = � {�6 .  5�   ,   �� 5�   "   = �@��
IsSelected6 . 5�   ,   /�5     �� 5  "   $( Bd��6)   # � A 5  )    � ��5     5     5
     5     5     