using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace MetroApp.Helpers
{
    public enum PopupPlacement
    {
        Window,
        DataGrid
    }

    public class DataGridPopupHelper
    {
        public static readonly DependencyProperty PopupViewProperty =
            DependencyProperty.RegisterAttached("PopupView", typeof(Popup),
            typeof(DataGridPopupHelper), new PropertyMetadata(null, OnPopupViewPropertyChanged));

        public static Popup GetPopupView(DependencyObject obj)
        {
            return (Popup)obj.GetValue(PopupViewProperty);
        }

        public static void SetPopupView(DependencyObject obj, Popup value)
        {
            obj.SetValue(PopupViewProperty, value);
        }

        private static void OnPopupViewPropertyChanged(DependencyObject sender,
                         DependencyPropertyChangedEventArgs e)
        {
            
        }
    }
}
