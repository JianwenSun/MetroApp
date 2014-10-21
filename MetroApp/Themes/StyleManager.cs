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
        /// <summary>
        /// Gets or sets whether StyleManager will apply themes on controls.
        /// True by default for normal assemblies (with XAML) and false by default for assemblies without XAML.
        /// </summary>
        public static bool IsEnabled { get; set; }

        public static Theme AppDefaultTheme = Light.Instance;

        static StyleManager()
        {
            StyleManager.IsEnabled = true;
        }

        public static void SetAppTheme(Theme appTheme)
        {
            if (StyleManager.IsEnabled)
            {
                ChangeTheme(Application.Current.Resources, appTheme);
            }
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

                FrameworkElement element = target as FrameworkElement;
                if(element != null)
                    ChangeTheme(element.Resources, newTheme);
            }
        }

        private static ResourceDictionary GetThemeResourceDictionary(ResourceDictionary resource, ref ResourceDictionary theme)
        {
            var enumerator = resource.MergedDictionaries.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var currentRd = enumerator.Current;

                if (Theme.IsContainControlsResource(currentRd))
                {
                    theme = currentRd;
                    return resource;
                }
            }

            enumerator.Dispose();
            return null;
        }

        private static void ChangeTheme(ResourceDictionary resources, Theme newTheme)
        {
            ResourceDictionary theme = null;
            ResourceDictionary containResource = GetThemeResourceDictionary(resources, ref theme);
            if (containResource != null && theme != null)
            {
                if (Theme.IsContainControlsResource(containResource))
                {
                    var dir = Theme.GetControlsDictionary(containResource);
                    if (dir != null)
                        resources.MergedDictionaries.Remove(dir);
                }
                containResource.MergedDictionaries.Insert(0, newTheme.Source);
                containResource.MergedDictionaries.Remove(theme);
            }
            else
            {
                resources.MergedDictionaries.Add(newTheme.Source);
            }

            if (!Theme.IsContainControlsResource(resources))
            {
                resources.MergedDictionaries.Add(Theme.Controls);
            }
        }
    }
}
