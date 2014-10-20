﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MetroApp.Themes
{
    public static class MetroBrushKeys
    {
        static MetroBrushKeys()
        {
            PropertyInfo[] properties = typeof(MetroBrushKeys).GetProperties();
            foreach (var property in properties)
            {
                if (property.SetMethod != null)
                    property.SetMethod.Invoke(null, new object[1] { property.Name });
            }
        }

        #region Base

        public static string AccentBrushKey { get; private set; }
        public static string WeakBrushKey { get; private set; }
        public static string BasicBrushKey { get; private set; }
        public static string StrongBrushKey { get; private set; }
        public static string MainBrushKey { get; private set; }
        public static string MarkerBrushKey { get; private set; }
        public static string ValidationBrushKey { get; private set; }
        
        #endregion

        #region Window

        public static string WindowBackgroundBrushKey { get; private set; }
        public static string WindowForegroundBrushKey { get; private set; }
        public static string WindowStateButtonMouseOverBrushKey { get; private set; }
        public static string WindowStateButtonCloseMouseOverBrushKey { get; private set; }
        public static string WindowStateButtonPressedBrushKey { get; private set; }
        public static string WindowStateButtonClosePressedBrushKey { get; private set; }
        public static string WindowStateButtonDisabledBrushKey { get; private set; }
        public static string WindowCommandsForegroundBrushKey { get; private set; }
        public static string WindowCommandsDisabledBrushKey { get; private set; }

        #endregion

        public static string LabelForegroundBrushKey { get; private set; }

        #region Button

        public static string ButtonBackgroundBrushKey { get; private set; }
        public static string ButtonBackgroundDisabledBrushKey { get; private set; }
        public static string ButtonForegroundBrushKey { get; private set; }
        public static string ButtonBorderBrushKey { get; private set; }
        public static string ButtonMouseOverBrushKey { get; private set; }
        public static string ButtonPressedBrushKey { get; private set; }

        #endregion

        #region DataGrid

        public static string DataGridSelectAllButtonBackgroundBrushKey { get; private set; }
        public static string DataGridSelectAllButtonMouseOverBrushKey { get; private set; }
        public static string DataGridSelectAllButtonArrowBrushKey { get; private set; }
        public static string DataGridSelectAllButtonPressedBrushKey { get; private set; }
        public static string DataGridColumnHeaderGripperBrushKey { get; private set; }
        public static string DataGridColumnHeaderGripperDisabledBrushKey { get; private set; }
        public static string DataGridRowHeaderGripperBrushKey { get; private set; }
        public static string DataGridColumnHeaderForegroundBrushKey { get; private set; }
        public static string DataGridColumnHeaderBorderBrushKey { get; private set; }
        public static string DataGridColumnHeaderBackgroundBrushKey { get; private set; }
        public static string DataGridColumnHeaderForegroundDisabledBrushKey { get; private set; }
        public static string DataGridColumnHeaderMouseOverBackgroundBrushKey { get; private set; }
        public static string DataGridRowHeaderBorderBrushKey { get; private set; }
        public static string DataGridRowHeaderMouseOverBrushKey { get; private set; }
        public static string DataGridCellForegroundBrushKey { get; private set; }
        public static string DataGridCellSelectedForegroundBrushKey { get; private set; }
        public static string DataGridCellSelectedBackgroundBrushKey { get; private set; }
        public static string DataGridCellMouseOverSelectedBackgroundBrushKey { get; private set; }
        public static string DataGridCellMouseOverUnSelectedBackgroundBrushKey { get; private set; }
        public static string DataGridCellDisabledForegroundBrushKey { get; private set; }
        public static string DataGridCellDisabledSelectedForegroundBrushKey { get; private set; }
        public static string DataGridCellDisabledSelectedBackgroundBrushKey { get; private set; }
        public static string DataGridRowForegroundBrushKey { get; private set; }
        public static string DataGridRowBackgroundBrushKey { get; private set; }
        public static string DataGridRowSelectedForegroundBrushKey { get; private set; }
        public static string DataGridRowSelectedBackgroundBrushKey { get; private set; }
        public static string DataGridRowSelectionActiveSelectedBackgroundBrushKey { get; private set; }
        public static string DataGridRowMouseOverFullRowBackgroundBrushKey { get; private set; }
        public static string DataGridRowMouseOverSelectedCellOrRowHeaderBackgroundBrushKey { get; private set; }
        public static string DataGridRowDisableForegroundBrushKey { get; private set; }
        public static string DataGridRowDisableSelectedForegroundBrushKey { get; private set; }
        public static string DataGridRowDisableSelectedBackgroundBrushKey { get; private set; }
        public static string DataGridBackgroundBrushKey { get; private set; }
        public static string DataGridBorderBrushKey { get; private set; }
        public static string DataGridHorizontalGridLinesBrushKey { get; private set; }
        public static string DataGridVerticalGridLinesBrushKey { get; private set; }
        public static string DataGridSeparatorBackgroundBrushKey { get; private set; }

        #endregion

        #region TextBlock



        #endregion

        #region TabControl

        public static string TabItemBorderBrushKey { get; private set; }
        public static string TabItemForegroundBrushKey { get; private set; }
        public static string TabItemSelectedForegroundBrushKey { get; private set; }
        public static string TabItemSelectedUnderLineBrushKey { get; private set; }
        public static string TabItemUnSelectedForegroundBrushKey { get; private set; }
        public static string TabItemUnSelectedUnderLineBrushKey { get; private set; }
        public static string TabItemMouseOverForegroundBrushKey { get; private set; }
        public static string TabItemMouseOverUnderLineBrushKey { get; private set; }

        #endregion

        #region CheckBox

        public static string CheckBoxForegroundBrushKey { get; private set; }
        public static string CheckBoxDisabledForegroundBrushKey { get; private set; }
        public static string CheckBoxFillBrushKey { get; private set; }
        public static string CheckBoxIndeterminateFillBrushKey { get; private set; }
        public static string CheckBoxBackgroundBrushKey { get; private set; }
        public static string CheckBoxBorderBrushKey { get; private set; }
        public static string CheckBoxMouseOverBorderBrushKey { get; private set; }
        public static string CheckBoxMouseOverBackgroundBrushKey { get; private set; }
        public static string CheckBoxPressedBorderBrushKey { get; private set; }
        public static string CheckBoxPressedBackgroundBrushKey { get; private set; }
        public static string CheckBoxDisableBackgroundBrushKey { get; private set; }
        public static string CheckBoxDisableBorderBrushKey { get; private set; }
        #endregion

        #region ComboBox

        public static string ComboBoxForegroundBrushKey { get; private set; }
        public static string ComboBoxBackgroundBrushKey { get; private set; }
        public static string ComboBoxBorderBrushKey { get; private set; }
        public static string ComboBoxDisableBackgroundBrushKey { get; private set; }
        public static string ComboBoxDisableForegroundBrushKey { get; private set; }
        public static string ComboBoxMouseOverBackgroundBrushKey { get; private set; }
        public static string ComboBoxMouseOverBorderBrushKey { get; private set; }
        public static string ComboBoxRessedBackgroundBrushKey { get; private set; }
        public static string ComboBoxRessedBorderBrushKey { get; private set; }
        public static string ComboBoxFocusBorderBrushKey { get; private set; }
        public static string ComboBoxFocusBackgroundBrushKey { get; private set; }
        public static string ComboBoxArrowBrushKey { get; private set; }
        public static string ComboBoxArrowMouseOverBrushKey { get; private set; }
        public static string ComboBoxClearButtonForegroundBrushKey { get; private set; }
        public static string ComboBoxClearButtonBackgroundBrushKey { get; private set; }
        public static string ComboBoxClearButtonMouseOverForegroundBrushKey { get; private set; }
        public static string ComboBoxClearButtonMouseOverBackgroundBrushKey { get; private set; }
        public static string ComboBoxClearButtonPressedForegroundBrushKey { get; private set; }
        public static string ComboBoxClearButtonPressedBackgroundBrushKey { get; private set; }
        public static string ComboBoxEditBackgroundBrushKey { get; private set; }
        public static string ComboBoxPopupBorderBrushKey { get; private set; }
        public static string ComboBoxPopupBackgroundBrushKey { get; private set; }


        public static string ComboBoxItemForegroundBrushKey { get; private set; }
        public static string ComboBoxItemBackgroundBrushKey { get; private set; }
        public static string ComboBoxItemSelectedBackgroundBrushKey { get; private set; }
        public static string ComboBoxItemSelectedForegroundBrushKey { get; private set; }
        public static string ComboBoxItemMouseOverBackgroundBrushKey { get; private set; }
        public static string ComboBoxItemFouseBorderBrushKey { get; private set; }
        
        #endregion

        #region TextBox

        public static string TextBoxSelectionBrushKey { get; private set; }
        public static string TextBoxBackgroundBrushKey { get; private set; }
        public static string TextBoxBorderBrushKey { get; private set; }
        public static string TextBoxForegroundBrushKey { get; private set; }
        public static string TextBoxFocusBorderBrushKey { get; private set; }
        public static string TextBoxMouseOverBorderBrushKey { get; private set; }
        public static string TextBoxCaretBrusBrushKey { get; private set; }
        public static string TextBoxDisabledForegroundBrushKey { get; private set; }
        public static string TextBoxDisabledBackgroundBrushKey { get; private set; }
        public static string TextBoxDisabledBorderBrushKey { get; private set; }
        public static string TextBoxClearButtonMouseOverBackgroundBrushKey { get; private set; }
        public static string TextBoxClearButtonMouseOverForegroundBrushKey { get; private set; }
        public static string TextBoxClearButtonPressedBackgroundBrushKey { get; private set; }
        public static string TextBoxClearButtonPressedForegroundBrushKey { get; private set; }
        public static string TextBoxWaitingForDataShadowBrushKey { get; private set; }
        
        
        #endregion

        #region ListView

        public static string ListViewBorderBrushKey { get; private set; }
        public static string ListViewDisabledBorderBrushKey { get; private set; }
        public static string ListViewBackgroundBrushKey { get; private set; }

        public static string ListViewItemForegroundBrushKey { get; private set; }
        public static string ListViewItemSelectedForegroundBrushKey { get; private set; }
        public static string ListViewItemDisabledForegroundBrushKey { get; private set; }
        public static string ListViewItemDisabledSelectedForegroundBrushKey { get; private set; }
        public static string ListViewItemBorderBrushKey { get; private set; }
        public static string ListViewItemSelectedBorderBrushKey { get; private set; }
        public static string ListViewItemSelectedBackgroundBrushKey { get; private set; }
        public static string ListViewItemDisabledSelectedBackgroundBrushKey { get; private set; }
        public static string ListViewItemMouseOverBackgroundBrushKey { get; private set; }
        public static string ListViewItemSelectionActiveSelectedBorderBrushKey { get; private set; }
        public static string ListViewItemSelectionActiveSelectedBackgroundBrushKey { get; private set; }
        public static string ListViewItemSelectionActiveSelectedForegroundBrushKey { get; private set; }

        #endregion

        #region GridView

        public static string GridViewColumnHeaderGripperBackgroundBrushKey { get; private set; }
        public static string GridViewColumnHeaderForegroundBrushKey { get; private set; }
        public static string GridViewColumnHeaderBackroundBrushKey { get; private set; }
        public static string GridViewColumnHeaderPressedBackgroundBrushKey { get; private set; }
        public static string GridViewColumnHeaderDisabledForegroundBrushKey { get; private set; }


        #endregion

        #region ListBox

        public static string ListBoxBorderBrushKey { get; private set; }
        public static string ListBoxDisabledBorderBrushKey { get; private set; }
        public static string ListBoxBackgroundBrushKey { get; private set; }

        public static string ListBoxItemForegroundBrushKey { get; private set; }
        public static string ListBoxItemSelectedBackgroundBrushKey { get; private set; }
        public static string ListBoxItemSelectedForegroundBrushKey { get; private set; }
        public static string ListBoxItemMouseOverBackgroundBrushKey { get; private set; }
        public static string ListBoxItemDisabledForegroundBrushKey { get; private set; }
        public static string ListBoxItemDisabledSelectedBackgroundBrushKey { get; private set; }
        public static string ListBoxItemDisabledSelectedForegroundBrushKey { get; private set; }
        public static string ListBoxItemSelectionActiveSelectedBackgroundBrushKey { get; private set; }
        

        #endregion

        #region TreeView

        public static string TreeViewExpandBrushKey { get; private set; }
        public static string TreeViewExpandDisabledBrushKey { get; private set; }
        public static string TreeViewExpandMouseOverBrushKey { get; private set; }
        public static string TreeViewItemFocusBrushKey { get; private set; }

        public static string TreeViewBorderBrushKey { get; private set; }
        public static string TreeViewBackgroundBrushKey { get; private set; }
        public static string TreeViewDisabledBorderBrushKey { get; private set; }
        public static string TreeViewItemForegroundBrushKey { get; private set; }
        public static string TreeViewItemDisabledForegroundBrushKey { get; private set; }
        public static string TreeViewItemBackgroundBrushKey { get; private set; }
        public static string TreeViewItemMouseOverForegroundBrushKey { get; private set; }
        public static string TreeViewItemMouseOverBackgroundBrushKey { get; private set; }
        public static string TreeViewItemSelectedForegroundBrushKey { get; private set; }
        public static string TreeViewItemSelectedBackgroundBrushKey { get; private set; }
        public static string TreeViewItemDisabledSelectedForegroundBrushKey { get; private set; }
        public static string TreeViewItemDisabledSelectedBackgroundBrushKey { get; private set; }
        public static string TreeViewItemSelectionActiveSelectedBrushKey { get; private set; }

        #endregion

        #region

        public static string ScrollbarHorizontalIncrementBrushKey { get; private set; }
        public static string ScrollbarHorizontalIncrementMouseOverBrushKey { get; private set; }
        public static string ScrollbarHorizontalIncrementPressedBrushKey { get; private set; }
        public static string ScrollbarHorizontalIncrementDisabledBrushKey { get; private set; }
        public static string ScrollbarHorizontalDecrementBrushKey { get; private set; }
        public static string ScrollbarHorizontalDecrementMouseOverBrushKey { get; private set; }
        public static string ScrollbarHorizontalDecrementPressedBrushKey { get; private set; }
        public static string ScrollbarHorizontalDecrementDisabledBrushKey { get; private set; }
        public static string ScrollbarHorizontalThumbBrushKey { get; private set; }
        public static string ScrollbarHorizontalThumbMouseOverBrushKey { get; private set; }
        public static string ScrollbarHorizontalThumbPressedBrushKey { get; private set; }
        public static string ScrollbarHorizontalThumbDisabledBrushKey { get; private set; }

        public static string ScrollbarVerticalIncrementBrushKey { get; private set; }
        public static string ScrollbarVerticalIncrementMouseOverBrushKey { get; private set; }
        public static string ScrollbarVerticalIncrementPressedBrushKey { get; private set; }
        public static string ScrollbarVerticalIncrementDisabledBrushKey { get; private set; }
        public static string ScrollbarVerticalDecrementBrushKey { get; private set; }
        public static string ScrollbarVerticalDecrementMouseOverBrushKey { get; private set; }
        public static string ScrollbarVerticalDecrementPressedBrushKey { get; private set; }
        public static string ScrollbarVerticalDecrementDisabledBrushKey { get; private set; }
        public static string ScrollbarVerticalThumbBrushKey { get; private set; }
        public static string ScrollbarVerticalThumbMouseOverBrushKey { get; private set; }
        public static string ScrollbarVerticalThumbPressedBrushKey { get; private set; }
        public static string ScrollbarVerticalThumbDisabledBrushKey { get; private set; }

        #endregion
    }
}
