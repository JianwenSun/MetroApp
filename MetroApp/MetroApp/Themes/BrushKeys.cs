using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MetroApp.Themes
{
    public static class BrushKeys
    {
        static BrushKeys()
        {
            PropertyInfo[] properties = typeof(BrushKeys).GetProperties();
            foreach (var property in properties)
            {
                if (property.SetMethod != null)
                    property.SetMethod.Invoke(null, new object[1] { property.Name });
            }
        }

        #region Base

        public static string AccentBrushKey { get; private set; }
        public static string AccentWeakBrushKey { get; private set; }
        public static string AccentDisableBrushKey { get; private set; }
        public static string WeakBrushKey { get; private set; }
        public static string BasicBrushKey { get; private set; }
        public static string BasicMouseOverBrushKey { get; private set; }
        public static string BasicPressBrushKey { get; private set; }
        public static string BasicDisableBrushKey { get; private set; }
        public static string BasicFouseBrushKey { get; private set; }
        public static string StrongBrushKey { get; private set; }
        public static string MainBrushKey { get; private set; }
        public static string MainStrongBrushKey { get; private set; }
        public static string MainDisableBrushKey { get; private set; }
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

        #region Label

        public static string LabelForegroundBrushKey { get; private set; }

        #endregion

        #region TextBlock

        public static string TextBlockForegroundBrushKey { get; private set; }

        #endregion

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

        #region RichTextBox

        public static string RichTextBoxHyperlinkForegroundBrushKey { get; private set; }
        public static string RichTextBoxHyperlinkMouseOverForegroundBrushKey { get; private set; }
        public static string RichTextBoxHyperlinkDisabledForegroundBrushKey { get; private set; }
        public static string RichTextBoxBackgroundBrushKey { get; private set; }
        public static string RichTextBoxSelectionBrushBrushKey { get; private set; }
        public static string RichTextBoxDisabledBackgroundBrushKey { get; private set; }
        public static string RichTextBoxForegroundBrushKey { get; private set; }
        public static string RichTextBoxBorderBrushKey { get; private set; }
        public static string RichTextBoxDisabledBorderBrushKey { get; private set; }
        public static string RichTextBoxMouseOverBorderBrushKey { get; private set; }
        public static string RichTextBoxFocusBorderBrushKey { get; private set; }

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
        public static string GridViewColumnHeaderMouseOverBackgroundBrushKey { get; private set; }
        public static string GridViewColumnHeaderDisabledForegroundBrushKey { get; private set; }
        public static string GridViewColumnHeaderBorderBrushKey { get; private set; }

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

        #region ScrollBar

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

        #region RadioButton

        public static string RadioButtonForegroundBrushKey { get; private set; }
        public static string RadioButtonBackgroundBrushKey { get; private set; }
        public static string RadioButtonBorderBrushKey { get; private set; }
        public static string RadioButtonCheckedBackgroundBrushKey { get; private set; }
        public static string RadioButtonMouseOverBackgroundBrushKey { get; private set; }
        public static string RadioButtonMouseOverBorderBrushKey { get; private set; }
        public static string RadioButtonPressedBackgroundBrushKey { get; private set; }
        public static string RadioButtonPressedBorderBrushKey { get; private set; }
        public static string RadioButtonFocusedBackgroundBrushKey { get; private set; }
        public static string RadioButtonFocusedBorderBrushKey { get; private set; }
        public static string RadioButtonDisabledBackgroundBrushKey { get; private set; }
        public static string RadioButtonDisabledBorderBrushKey { get; private set; }

        #endregion

        #region PasswordBox

        public static string PasswordBoxSelectionBrushKey { get; private set; }
        public static string PasswordBoxBackgroundBrushKey { get; private set; }
        public static string PasswordBoxDisabledBackgroundBrushKey { get; private set; }
        public static string PasswordBoxForegroundBrushKey { get; private set; }
        public static string PasswordBoxBorderBrushKey { get; private set; }
        public static string PasswordBoxFocusBorderBrushKey { get; private set; }
        public static string PasswordBoxMouseOverBorderBrushKey { get; private set; }
        public static string PasswordBoxDisabledBorderBrushKey { get; private set; }
        public static string PasswordBoxClearButtonBackgroundBrushKey { get; private set; }
        public static string PasswordBoxClearButtonForegroundBrushKey { get; private set; }
        public static string PasswordBoxClearButtonMouseOverBackgroundBrushKey { get; private set; }
        public static string PasswordBoxClearButtonMouseOverForegroundBrushKey { get; private set; }
        public static string PasswordBoxClearButtonPressedBackgroundBrushKey { get; private set; }
        public static string PasswordBoxClearButtonPressedForegroundBrushKey { get; private set; }

        #endregion

        #region Calendar

        public static string CalendarDayButtonForegroundBrushKey { get; private set; }
        public static string CalendarDayButtonInactiveBrushKey { get; private set; }
        public static string CalendarDayButtonTodayBackgroundBrushKey { get; private set; }
        public static string CalendarDayButtonTodayForegroundBrushKey { get; private set; }
        public static string CalendarDayButtonSelectedBackgroundBrushKey { get; private set; }
        public static string CalendarDayButtonHighLightBackgroundBrushKey { get; private set; }
        public static string CalendarDayButtonFocusBorderBrushKey { get; private set; }
        public static string CalendarDayButtonNoTodaySelectedForegroundBrushKey { get; private set; }
        public static string CalendarDayButtonBlackoutBrushKey { get; private set; }
        public static string CalendarItemDayTitleBrushKey { get; private set; }
        public static string CalendarItemDayArrowBrushKey { get; private set; }
        public static string CalendarItemHeaderBackgroundBrushKey { get; private set; }
        public static string CalendarItemDisabledBorderBrushKey { get; private set; }
        public static string CalendarItemDisabledBackgroundBrushKey { get; private set; }
        public static string CalendarButtonBackgroundBrushKey { get; private set; }
        public static string CalendarButtonInactiveBrushKey { get; private set; }
        public static string CalendarButtonForegroundBrushKey { get; private set; }
        public static string CalendarButtonFocusBorderBrushKey { get; private set; }
        public static string CalendarForegroundBrushKey { get; private set; }
        public static string CalendarBackgroundBrushKey { get; private set; }
        public static string CalendarBorderBrushKey { get; private set; }
        public static string CalendarMouseOverBorderBrushKey { get; private set; }

        #endregion

        #region DatePicker

        public static string DatePickerTextBoxForegroundBrushKey { get; private set; }
        public static string DatePickerTextBoxBackgroundBrushKey { get; private set; }
        public static string DatePickerBackgroundBrushKey { get; private set; }
        public static string DatePickerDisabledBackgroundBrushKey { get; private set; }
        public static string DatePickerBorderBrushKey { get; private set; }
        public static string DatePickerMouseOverBorderBrushKey { get; private set; }
        public static string DatePickerDisabledBorderBrushKey { get; private set; }
        public static string DatePickerForegroundBrushKey { get; private set; }
        public static string DatePickerFocusBorderBrushKey { get; private set; }
        public static string DatePickerButtonMouseOverBackgroundBrushKey { get; private set; }
        public static string DatePickerButtonMouseOverForegroundBrushKey { get; private set; }
        public static string DatePickerButtonPressedBackgroundBrushKey { get; private set; }
        public static string DatePickerButtonPressedForegroundBrushKey { get; private set; }

        #endregion

        #region Slider

        public static string HorizontalSliderThumbBackgroundBrushKey { get; private set; }
        public static string HorizontalSliderThumbBorderBrushKey { get; private set; }
        public static string HorizontalSliderThumbDisabledBackgroundBrushKey { get; private set; }
        public static string HorizontalTrackLargeDecreaseBackgroundBrushKey { get; private set; }
        public static string HorizontalTrackValueAccentBackgroundBrushKey { get; private set; }
        public static string VerticalSliderThumbBackgroundBrushKey { get; private set; }
        public static string VerticalSliderThumbBorderBrushKey { get; private set; }
        public static string VerticalSliderThumbDisabledBackgroundBrushKey { get; private set; }
        public static string VerticalTrackLargeDecreaseBackgroundBrushKey { get; private set; }
        public static string VerticalTrackValueAccentBackgroundBrushKey { get; private set; }
        public static string SliderBorderBrushKey { get; private set; }
        public static string SliderForegroundBrushKey { get; private set; }
        public static string SliderTickBarFillBrushKey { get; private set; }

        public static string FlatSliderVerticalDecreaseRepeatButtonBackground { get; private set; }
        public static string FlatSliderVerticalThumbBackground { get; private set; }
        public static string FlatSliderVerticalIncreaseRepeatButtonBackground { get; private set; }

        public static string FlatSliderVerticalMouseOverDecreaseRepeatButtonBackground { get; private set; }
        public static string FlatSliderVerticalMouseOverThumbBackground { get; private set; }
        public static string FlatSliderVerticalMouseOverIncreaseRepeatButtonBackground { get; private set; }

        public static string FlatSliderVerticalDisabledDecreaseRepeatButtonBackground { get; private set; }
        public static string FlatSliderVerticalDisabledThumbBackground { get; private set; }
        public static string FlatSliderVerticalDisabledIncreaseRepeatButtonBackground { get; private set; }

        public static string FlatSliderHorizontalDecreaseRepeatButtonBackground { get; private set; }
        public static string FlatSliderHorizontalThumbBackground { get; private set; }
        public static string FlatSliderHorizontalIncreaseRepeatButtonBackground { get; private set; }

        public static string FlatSliderHorizontalMouseOverDecreaseRepeatButtonBackground { get; private set; }
        public static string FlatSliderHorizontalMouseOverThumbBackground { get; private set; }
        public static string FlatSliderHorizontalMouseOverIncreaseRepeatButtonBackground { get; private set; }

        public static string FlatSliderHorizontalDisabledDecreaseRepeatButtonBackground { get; private set; }
        public static string FlatSliderHorizontalDisabledThumbBackground { get; private set; }
        public static string FlatSliderHorizontalDisabledIncreaseRepeatButtonBackground { get; private set; }

        #endregion

        #region Menu

        public static string MenuItemBorderBrushKey { get; private set; }
        public static string MenuItemTopLevelBackgroundMouseOverBrushKey { get; private set; }
        public static string MenuItemSeparatorBackgroundBrushKey { get; private set; }
        public static string MenuBorderBrushKey { get; private set; }
        public static string MenuBackgroundBrushKey { get; private set; }
        public static string MenuForegroundBrushKey { get; private set; }
        public static string SubmenuItemBorderBrushKey { get; private set; }
        public static string SubmenuItemBackgroundBrushKey { get; private set; }
        public static string MenuItemBackgroundBrushKey { get; private set; }
        public static string MenuItemForegroundDisableBrushKey { get; private set; }
        public static string MenuItemBackgroundDisableBrushKey { get; private set; }
        public static string MenuItemDownArrowBrushKey { get; private set; }
        public static string MenuItemRightArrowFillBrushKey { get; private set; }
        public static string MenuItemCheckmarkFillBrushKey { get; private set; }
        public static string MenuItemBackgroundHighlightBrushKey { get; private set; }

        #endregion

        #region ContextMenu

        public static string ContextMenuBackgroundBrushKey { get; private set; }
        public static string ContextMenuBorderBrushKey { get; private set; }
        public static string ContextMenuForegroundBrushKey { get; private set; }

        #endregion
    }
}
