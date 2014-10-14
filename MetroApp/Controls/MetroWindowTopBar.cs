using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MetroApp.Controls
{
    using MetroApp.Helpers;
    using MetroApp.Native;
    using System.Windows.Interop;
    using Microsoft.Windows.Shell;

    [TemplatePart(Name = PART_Icon, Type = typeof(UIElement))]
    [TemplatePart(Name = PART_TitleBar, Type = typeof(UIElement))]
    [TemplatePart(Name = PART_WindowTitleBackground, Type = typeof(UIElement))]
    [TemplatePart(Name = PART_LeftWindowCommands, Type = typeof(MetroWindowCommands))]
    [TemplatePart(Name = PART_RightWindowCommands, Type = typeof(MetroWindowCommands))]
    [TemplatePart(Name = PART_WindowButtonCommands, Type = typeof(MetroWindowStateButtons))]

    public class MetroWindowTopBar : ContentControl
    {
        private const string PART_Icon = "PART_Icon";
        private const string PART_TitleBar = "PART_TitleBar";
        private const string PART_WindowTitleBackground = "PART_WindowTitleBackground";
        private const string PART_LeftWindowCommands = "PART_LeftWindowCommands";
        private const string PART_RightWindowCommands = "PART_RightWindowCommands";
        private const string PART_WindowButtonCommands = "PART_WindowButtonCommands";

        static MetroWindowTopBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MetroWindowTopBar), new FrameworkPropertyMetadata(typeof(MetroWindowTopBar)));
        }

        UIElement icon;
        UIElement titleBar;
        UIElement titleBarBackground;
        internal ContentPresenter LeftWindowCommandsPresenter;
        internal ContentPresenter RightWindowCommandsPresenter;
        internal MetroWindowStateButtons WindowButtonCommands;

        internal MetroWindow ParentWindow;

        public static readonly DependencyProperty IconTemplateProperty
            = DependencyProperty.Register("IconTemplate", typeof(DataTemplate), typeof(MetroWindowCommands), new PropertyMetadata(null));

        public DataTemplate IconTemplate
        {
            get { return (DataTemplate)GetValue(IconTemplateProperty); }
            set { SetValue(IconTemplateProperty, value); }
        }

        public static readonly DependencyProperty TitleTemplateProperty
            = DependencyProperty.Register("TitleTemplate", typeof(DataTemplate), typeof(MetroWindowCommands), new PropertyMetadata(null));

        /// <summary>
        /// Gets/sets the title content template to show a custom title.
        /// </summary>
        public DataTemplate TitleTemplate
        {
            get { return (DataTemplate)GetValue(TitleTemplateProperty); }
            set { SetValue(TitleTemplateProperty, value); }
        }

        public static readonly DependencyProperty LeftWindowCommandsProperty 
            = DependencyProperty.Register("LeftWindowCommands", typeof(MetroWindowCommands), typeof(MetroWindowTopBar), new PropertyMetadata(null));

        /// <summary>
        /// Gets/sets the left window commands that hosts the user commands.
        /// </summary>
        public MetroWindowCommands LeftWindowCommands
        {
            get { return (MetroWindowCommands)GetValue(LeftWindowCommandsProperty); }
            set { SetValue(LeftWindowCommandsProperty, value); }
        }

        public static readonly DependencyProperty RightWindowCommandsProperty 
            = DependencyProperty.Register("RightWindowCommands", typeof(MetroWindowCommands), typeof(MetroWindowTopBar), new PropertyMetadata(null));

        /// <summary>
        /// Gets/sets the right window commands that hosts the user commands.
        /// </summary>
        public MetroWindowCommands RightWindowCommands
        {
            get { return (MetroWindowCommands)GetValue(RightWindowCommandsProperty); }
            set { SetValue(RightWindowCommandsProperty, value); }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (LeftWindowCommands == null)
                LeftWindowCommands = new MetroWindowCommands();
            if (RightWindowCommands == null)
                RightWindowCommands = new MetroWindowCommands();

            LeftWindowCommandsPresenter = GetTemplateChild(PART_LeftWindowCommands) as ContentPresenter;
            RightWindowCommandsPresenter = GetTemplateChild(PART_RightWindowCommands) as ContentPresenter;

            WindowButtonCommands = GetTemplateChild(PART_WindowButtonCommands) as MetroWindowStateButtons;

            icon = GetTemplateChild(PART_Icon) as UIElement;
            titleBar = GetTemplateChild(PART_TitleBar) as UIElement;
            titleBarBackground = GetTemplateChild(PART_WindowTitleBackground) as UIElement;

            this.ParentWindow = this.TryFindParent<MetroWindow>();
            this.SetWindowEvents();
        }

        #region Window Events

        private void SetWindowEvents()
        {
            // clear all event handlers first
            this.ClearWindowEvents();

            // set mouse down/up for icon
            if (icon != null && icon.Visibility == Visibility.Visible)
            {
                icon.MouseDown += IconMouseDown;
            }

            // handle mouse events for PART_WindowTitleBackground -> MetroWindow
            if (titleBarBackground != null && titleBarBackground.Visibility == Visibility.Visible)
            {
                titleBarBackground.MouseDown += TitleBarMouseDown;
                titleBarBackground.MouseUp += TitleBarMouseUp;
            }

            // handle mouse events for PART_TitleBar -> MetroWindow and CleanWindow
            if (titleBar != null && titleBar.Visibility == Visibility.Visible)
            {
                titleBar.MouseDown += TitleBarMouseDown;
                titleBar.MouseUp += TitleBarMouseUp;
            }
            else
            {
                // handle mouse events for windows without PART_WindowTitleBackground or PART_TitleBar
                MouseDown += TitleBarMouseDown;
                MouseUp += TitleBarMouseUp;
            }
        }

        private void ClearWindowEvents()
        {
            // clear all event handlers first:
            if (titleBarBackground != null)
            {
                titleBarBackground.MouseDown -= TitleBarMouseDown;
                titleBarBackground.MouseUp -= TitleBarMouseUp;
            }
            if (titleBar != null)
            {
                titleBar.MouseDown -= TitleBarMouseDown;
                titleBar.MouseUp -= TitleBarMouseUp;
            }
            if (icon != null)
            {
                icon.MouseDown -= IconMouseDown;
            }
            MouseDown -= TitleBarMouseDown;
            MouseUp -= TitleBarMouseUp;
        }

        private void IconMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (e.ClickCount == 2)
                {
                    this.ParentWindow.Close();
                }
                else
                {
                    SystemCommands.ShowSystemMenuPhysicalCoordinates(this.ParentWindow, PointToScreen(new Point(0, this.ParentWindow.ActualHeight)));
                }
            }
        }

        protected void TitleBarMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && !this.ParentWindow.UseNoneWindowStyle)
            {
                // if UseNoneWindowStyle = true no movement, no maximize please
                IntPtr windowHandle = new WindowInteropHelper(this.ParentWindow).Handle;
                UnsafeNativeMethods.ReleaseCapture();

                var mPoint = Mouse.GetPosition(this.ParentWindow);

                var wpfPoint = this.PointToScreen(mPoint);
                var x = Convert.ToInt16(wpfPoint.X);
                var y = Convert.ToInt16(wpfPoint.Y);
                var lParam = x | (y << 16);
                UnsafeNativeMethods.SendMessage(windowHandle, Constants.WM_NCLBUTTONDOWN, Constants.HT_CAPTION, lParam);

                if (e.ClickCount == 2 && (this.ParentWindow.ResizeMode == ResizeMode.CanResizeWithGrip || this.ParentWindow.ResizeMode == ResizeMode.CanResize) && mPoint.Y <= this.ActualHeight)
                {
                    if (this.ParentWindow.WindowState == WindowState.Maximized)
                    {
                        Microsoft.Windows.Shell.SystemCommands.RestoreWindow(this.ParentWindow);
                    }
                    else
                    {
                        Microsoft.Windows.Shell.SystemCommands.MaximizeWindow(this.ParentWindow);
                    }
                }
            }
        }

        protected void TitleBarMouseUp(object sender, MouseButtonEventArgs e)
        {
           
        }

        #endregion
    }
}
