using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace MetroApp.Controls
{
    [TemplatePart(Name = PART_TopBar, Type = typeof(MetroWindowTopBar))]
    public class MetroWindow : Window
    {
        const string PART_TopBar = "PART_TopBar";

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
                if (window.isLoadCompeleted)
                    window.ChangeToScreen((bool)e.NewValue);
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

        public static readonly DependencyProperty IsUseTopBarProperty = DependencyProperty.Register("IsUseTopBar", typeof(bool), typeof(MetroWindow), new PropertyMetadata(true, OnIsUseTopBarPropertyChanged));

        private static void OnIsUseTopBarPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MetroWindow window = d as MetroWindow;
            if (e.NewValue != e.OldValue)
            {
                if (window.isLoadCompeleted)
                    window.ChangeUseTopBar((bool)e.NewValue);
            }
        }

        /// <summary>
        /// Gets/sets whether the WindowStyle is None or not.
        /// </summary>
        public bool IsUseTopBar
        {
            get { return (bool)GetValue(IsUseTopBarProperty); }
            set { SetValue(IsUseTopBarProperty, value); }
        }


        public MetroWindowTopBar TopBar
        {
            get;
            private set;
        }

        private static void OnTopBarPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MetroWindow window = d as MetroWindow;
        }

        private bool isLoadCompeleted;

        public MetroWindow()
        {
            this.KeyDown += MetroWindow_KeyDown;
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            this.TopBar = this.GetTemplateChild(PART_TopBar) as MetroWindowTopBar;
            this.isLoadCompeleted = true;
            this.ChangeToScreen(this.IsFullScreen);
            this.ChangeUseTopBar(this.IsUseTopBar);
        }

        void ChangeToScreen(bool isFullScreen)
        {
            if (!this.isLoadCompeleted) return;
            if (isFullScreen)
            {
                this.TopBar.Visibility = Visibility.Collapsed;
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.TopBar.Visibility = Visibility.Visible;
                this.WindowState = WindowState.Normal;
            }
        }

        void ChangeUseTopBar(bool useTopBar)
        {
            if (!this.isLoadCompeleted) return;
            if (!useTopBar)
            {
                this.TopBar.Visibility = Visibility.Collapsed;
            }
            else
            {
                this.TopBar.Visibility = Visibility.Visible;
            }
        }

        internal T GetPart<T>(string name) where T : DependencyObject
        {
            return GetTemplateChild(name) as T;
        }

        private void MetroWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Escape)
            {
                this.IsFullScreen = false;
            }
        }
    }
}
