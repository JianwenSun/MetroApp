using MetroApp.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

namespace MetroApp.Helpers
{
    public enum PopupPlacement
    {
        Window,
        DataGrid
    }

    public class DataGridPopupController : DependencyObject
    {
        public static readonly DependencyProperty PopupViewProperty =
            DependencyProperty.RegisterAttached("PopupView", typeof(Popup),
            typeof(DataGridPopupController), new PropertyMetadata(null, OnPopupViewPropertyChanged));

        private static void OnPopupViewPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DataGridPopupController controller = d as DataGridPopupController;

            if (e.OldValue != null)
            {
                controller.SetupPopup(e.OldValue as Popup, false);
            }

            if (e.NewValue != null)
            {
                controller.SetupPopup(e.NewValue as Popup, true);
            }
        }

        public Popup PopupView
        {
            get { return (Popup)this.GetValue(PopupViewProperty); }
            set { this.SetValue(PopupViewProperty, value); }
        }

        public static readonly DependencyProperty IsStayProperty =
            DependencyProperty.RegisterAttached("IsStay", typeof(bool),
            typeof(DataGridPopupController), new PropertyMetadata(false));

        public bool IsStay
        {
            get { return (bool)this.GetValue(IsStayProperty); }
            set { this.SetValue(IsStayProperty, value); }
        }

        public static readonly DependencyProperty StayTimeProperty =
            DependencyProperty.RegisterAttached("StayTime", typeof(TimeSpan),
            typeof(DataGridPopupController), new PropertyMetadata(new TimeSpan(0, 0, 1), OnStayTimePropertyChanged));

        private static void OnStayTimePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DataGridPopupController controller = d as DataGridPopupController;

            if (e.NewValue != null)
            {
                controller.dispatcherTimer.Interval = (TimeSpan)e.NewValue;
            }
        }

        public TimeSpan StayTime
        {
            get { return (TimeSpan)this.GetValue(StayTimeProperty); }
            set { this.SetValue(StayTimeProperty, value); }
        }

        public static readonly DependencyProperty DataGridProperty =
            DependencyProperty.RegisterAttached("DataGrid", typeof(DataGrid),
            typeof(DataGridPopupController), new PropertyMetadata(null, OnDataGridPropertyChanged));

        private static void OnDataGridPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DataGridPopupController controller = d as DataGridPopupController;

            if (e.OldValue != null)
            {
                controller.SetupDataGrid(e.OldValue as DataGrid, false);
            }

            if (e.NewValue != null)
            {
                controller.SetupDataGrid(e.NewValue as DataGrid, true);
            }
        }

        public DataGrid DataGrid
        {
            get { return (DataGrid)this.GetValue(DataGridProperty); }
            set { this.SetValue(DataGridProperty, value); }
        }

        public static readonly DependencyProperty TargetProperty =
            DependencyProperty.RegisterAttached("Target", typeof(PopupPlacement),
            typeof(DataGridPopupController), new PropertyMetadata(PopupPlacement.Window));

        public PopupPlacement Target
        {
            get { return (PopupPlacement)this.GetValue(TargetProperty); }
            set { this.SetValue(TargetProperty, value); }
        }

        DispatcherTimer dispatcherTimer;

        public DataGridPopupController()
        {
            this.SetupTimer();
        }

        void SetupDataGrid(DataGrid dataGrid, bool isSetup)
        {
            if (isSetup)
            {
                dataGrid.MouseLeave += dataGrid_MouseLeave;
                dataGrid.LoadingRow += dataGrid_LoadingRow;
                dataGrid.UnloadingRow += dataGrid_UnloadingRow;
            }
            else
            {
                dataGrid.MouseLeave -= dataGrid_MouseLeave;
                dataGrid.LoadingRow -= dataGrid_LoadingRow;
                dataGrid.UnloadingRow -= dataGrid_UnloadingRow;
            }
        }

        void SetupPopup(Popup popup, bool isSetup)
        {
            if (isSetup)
            {
                popup.MouseLeave += popup_MouseLeave;
                popup.MouseEnter += popup_MouseEnter;
            }
            else
            {
                popup.MouseLeave -= popup_MouseLeave;
                popup.MouseEnter -= popup_MouseEnter;
            }
        }

        void SetupTimer()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = this.StayTime;
            dispatcherTimer.Tick += dispatcherTimer_Tick;
        }

        #region DataGrid Row Events

        void dataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.MouseEnter += Row_MouseEnter;
            e.Row.MouseLeave += Row_MouseLeave;
            e.Row.LostFocus += Row_LostFocus;
        }

        void dataGrid_UnloadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.MouseEnter -= Row_MouseEnter;
            e.Row.MouseLeave -= Row_MouseLeave;
            e.Row.LostFocus -= Row_LostFocus;
        }

        void Row_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if(this.PopupView != null)
            {
                this.ShowPopup(sender as DataGridRow);

                if(this.IsStay)
                    dispatcherTimer.Stop();
            }
        }

        void Row_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if(this.IsStay)
                dispatcherTimer.Start();
            else
            {
                if (this.PopupView != null)
                    this.PopupView.IsOpen = false;
            }
        }

        void Row_LostFocus(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Start();
        }

        void dataGrid_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            dispatcherTimer.Start();
        }

        #endregion

        #region Popup Events

        void popup_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            dispatcherTimer.Stop();
        }

        void popup_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            dispatcherTimer.Start();
        }

        #endregion

        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (this.PopupView != null && this.dispatcherTimer.IsEnabled)
                this.PopupView.IsOpen = false;

            dispatcherTimer.Stop();
        }

        void ShowPopup(DataGridRow row)
        {
            dispatcherTimer.Stop();

            UIElement popupTarget = null;

            switch (this.Target)
            {
                case PopupPlacement.Window:
                    {
                        Window window = Window.GetWindow(row);
                        if (window != null && window.WindowState == WindowState.Maximized || window.WindowState == WindowState.Minimized)
                        {
                            this.PopupView.IsOpen = false;
                            return;
                        }

                        popupTarget = window;
                    }
                    break;
                case PopupPlacement.DataGrid:
                    {
                        popupTarget = this.DataGrid;
                    }
                    break;
                default:
                    break;
            }

            this.PopupView.PlacementTarget = popupTarget;
            this.PopupView.DataContext = row.DataContext;

            Point point = row.TransformToAncestor(popupTarget).Transform(new Point(0, 0));

            this.PopupView.VerticalOffset = point.Y;
            this.PopupView.IsOpen = true;
        }
    }
}
