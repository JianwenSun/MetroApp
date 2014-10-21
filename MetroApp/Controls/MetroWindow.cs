using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace MetroApp.Controls
{
    public class MetroWindow : Window
    {
        static MetroWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MetroWindow), new FrameworkPropertyMetadata(typeof(MetroWindow)));
        }

        public static readonly DependencyProperty IgnoreTaskbarOnMaximizeProperty = DependencyProperty.Register("IgnoreTaskbarOnMaximize", typeof(bool), typeof(MetroWindow), new PropertyMetadata(false));

        /// <summary>
        /// Gets/sets whether the window will ignore (and overlap) the taskbar when maximized.
        /// </summary>
        public bool IgnoreTaskbarOnMaximize
        {
            get { return (bool)this.GetValue(IgnoreTaskbarOnMaximizeProperty); }
            set { SetValue(IgnoreTaskbarOnMaximizeProperty, value); }
        }

        public static readonly DependencyProperty GlowBrushProperty = DependencyProperty.Register("GlowBrush", typeof(SolidColorBrush), typeof(MetroWindow), new PropertyMetadata(null));

        /// <summary>
        /// Gets/sets the brush used for the Window's glow.
        /// </summary>
        public SolidColorBrush GlowBrush
        {
            get { return (SolidColorBrush)GetValue(GlowBrushProperty); }
            set { SetValue(GlowBrushProperty, value); }
        }

        public static readonly DependencyProperty NonActiveGlowBrushProperty = DependencyProperty.Register("NonActiveGlowBrush", typeof(SolidColorBrush), typeof(MetroWindow), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(153, 153, 153))));

        /// <summary>
        /// Gets/sets the brush used for the Window's non-active glow.
        /// </summary>
        public SolidColorBrush NonActiveGlowBrush
        {
            get { return (SolidColorBrush)GetValue(NonActiveGlowBrushProperty); }
            set { SetValue(NonActiveGlowBrushProperty, value); }
        }

        public static readonly DependencyProperty BorderShadowProperty = DependencyProperty.Register("BorderShadow", typeof(bool), typeof(MetroWindow), new PropertyMetadata(false));

        public bool BorderShadow
        {
            get { return (bool)GetValue(BorderShadowProperty); }
            set { SetValue(BorderShadowProperty, value); }
        }

        public static readonly DependencyProperty IsFullScreenProperty = DependencyProperty.Register("IsFullScreen", typeof(bool), typeof(MetroWindow), new PropertyMetadata(false, OnIsFullScreenPropertyChanged));

        private static void OnIsFullScreenPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MetroWindow window = d as MetroWindow;
            if (e.NewValue != e.OldValue)
            {
                if ((bool)e.NewValue)
                {
                    ((MetroWindow)d).TopBar.Visibility = Visibility.Collapsed;
                    window.WindowState = WindowState.Maximized;
                }
                else
                {
                    ((MetroWindow)d).TopBar.Visibility = Visibility.Visible;
                    window.WindowState = WindowState.Normal;
                }
            }
        }

        /// <summary>
        /// Gets/sets whether the WindowStyle is None or not.
        /// </summary>
        public bool IsFullScreen
        {
            get { return (bool)GetValue(IsFullScreenProperty); }
            set { SetValue(IsFullScreenProperty, value); }
        }

        public static readonly DependencyProperty TopBarProperty
            = DependencyProperty.Register("TopBar", typeof(MetroWindowTopBar), typeof(MetroWindow), new PropertyMetadata(null, OnTopBarPropertyChanged));

        public MetroWindowTopBar TopBar
        {
            get { return (MetroWindowTopBar)GetValue(TopBarProperty); }
            set { SetValue(TopBarProperty, value); }
        }

        private static void OnTopBarPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MetroWindow window = d as MetroWindow;
        }

        public MetroWindow()
        {
            
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (this.TopBar == null)
                TopBar = new MetroWindowTopBar();
        }

        internal T GetPart<T>(string name) where T : DependencyObject
        {
            return GetTemplateChild(name) as T;
        }
    }
}
