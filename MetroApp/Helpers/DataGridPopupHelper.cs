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
    public class DataGridPopupHelper
    {
        public static readonly DependencyProperty ControllerProperty =
            DependencyProperty.RegisterAttached("Controller", typeof(DataGridPopupController),
            typeof(DataGridPopupHelper), new PropertyMetadata(null, OnControllerPropertyChanged));

        public static DataGridPopupController GetController(DependencyObject obj)
        {
            return (DataGridPopupController)obj.GetValue(ControllerProperty);
        }

        public static void SetController(DependencyObject obj, DataGridPopupController value)
        {
            obj.SetValue(ControllerProperty, value);
        }

        private static void OnControllerPropertyChanged(DependencyObject sender,
                         DependencyPropertyChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            if(e.NewValue != null)
            {
                (e.NewValue as DataGridPopupController).DataGrid = dataGrid;
            }
        }
    }
}
