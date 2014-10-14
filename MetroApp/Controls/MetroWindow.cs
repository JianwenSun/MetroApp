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
        private const string PART_TopBar = "PART_TopBar";

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

        public static readonly DependencyProperty UseNoneWindowStyleProperty = DependencyProperty.Register("UseNoneWindowStyle", typeof(bool), typeof(MetroWindow), new PropertyMetadata(false, OnUseNoneWindowStylePropertyChangedCallback));

        /// <summary>
        /// Gets/sets whether the WindowStyle is None or not.
        /// </summary>
        public bool UseNoneWindowStyle
        {
            get { return (bool)GetValue(UseNoneWindowStyleProperty); }
            set { SetValue(UseNoneWindowStyleProperty, value); }
        }

        private static void OnUseNoneWindowStylePropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                // if UseNoneWindowStyle = true no title bar should be shown
                if ((bool)e.NewValue)
                {
                    ((MetroWindow)d).TopBar.Visibility = Visibility.Collapsed;
                }
                else
                {
                    ((MetroWindow)d).TopBar.Visibility = Visibility.Visible;
                }
            }
        }

        public MetroWindow()
        {
        }

        public static readonly DependencyProperty TopBarProperty
            = DependencyProperty.Register("TopBar", typeof(MetroWindowTopBar), typeof(MetroWindow), new PropertyMetadata(null));

        public MetroWindowTopBar TopBar
        {
            get { return (MetroWindowTopBar)GetValue(TopBarProperty); }
            set { SetValue(TopBarProperty, value); }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            TopBar = GetTemplateChild(PART_TopBar) as MetroWindowTopBar;
        }

        internal T GetPart<T>(string name) where T : DependencyObject
        {
            return GetTemplateChild(name) as T;
        }
    }
}
