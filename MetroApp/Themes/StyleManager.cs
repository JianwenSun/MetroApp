using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MetroApp.Themes
{
    public static class StyleManager
    {
        public static List<Theme> Themes = new List<Theme>();

        /// <summary>
        /// Gets or sets whether StyleManager will apply themes on controls.
        /// True by default for normal assemblies (with XAML) and false by default for assemblies without XAML.
        /// </summary>
        public static bool IsEnabled { get; set; }

        public static Theme AppDefaultTheme
        {
            get;
            private set;
        }

        public static Theme FromName(string themeName)
        {
            foreach (var theme in Themes)
            {
                if (theme.Name == themeName)
                    return theme;
            }

            return AppDefaultTheme;
        }

        static void GetThemes()
        {
            lock (Themes)
            {
                foreach (Type type in typeof(Theme).Assembly.GetTypes())
                {
                    var attribute = type.GetCustomAttribute(typeof(ThemeAttribute));
                    if(attribute != null)
                    {
                        var theme = Activator.CreateInstance(type);
                        Themes.Add(theme as Theme);
                    }
                }
            }
        }

        static StyleManager()
        {
            StyleManager.IsEnabled = true;
            AppDefaultTheme = LightTheme.Instance;
            GetThemes();
        }

        /// <summary>
        /// Identifies the Theme attached property.
        /// </summary>
        public static readonly DependencyProperty ThemeProperty =
            DependencyProperty.RegisterAttached("Theme", typeof(Theme), typeof(StyleManager), new PropertyMetadata(OnThemeChanged));

        /// <summary>
        /// Gets the theme of the specified <see cref="DependencyObject"/>.
        /// </summary>
        /// <param name="element">The element to get the theme of.</param>
        /// <returns></returns>
        [CategoryAttribute("Appearance")]
        public static Theme GetTheme(DependencyObject element)
        {
            return (Theme)element.GetValue(ThemeProperty);
        }

        /// <summary>
        /// Sets the theme of the specified <see cref="DependencyObject"/>.
        /// </summary>
        /// <param name="element">The element to set the theme of.</param>
        /// <param name="value">The new theme to set.</param>
        public static void SetTheme(DependencyObject element, Theme value)
        {
            element.SetValue(ThemeProperty, value);
        }


        private static void OnThemeChanged(DependencyObject target, DependencyPropertyChangedEventArgs changedEventArgs)
        {
            if (StyleManager.IsEnabled)
            {
                Theme newTheme = changedEventArgs.NewValue as Theme;
                if (newTheme == null) return;

                Control control = target as Control;
                if (control != null && control.Resources.MergedDictionaries != null)
                {
                    foreach (ResourceDictionary rd in control.Resources.MergedDictionaries)
                    {
                        if (Theme.IsDictionaryContainTheme(rd))
                        {
                            control.Resources.MergedDictionaries.Remove(rd);
                            break;
                        }
                    }

                    control.Resources.MergedDictionaries.Add(newTheme.Source);
                }
            }
        }
    }
}
