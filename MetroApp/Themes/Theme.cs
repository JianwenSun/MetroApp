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
    public sealed class Themes
    {
        public static Theme Dark { get { return MetroApp.Themes.Dark.Instance; } }
        public static Theme Light { get { return MetroApp.Themes.Light.Instance; } }
    }

    public abstract class Theme
    {
        public static List<Theme> Themes = new List<Theme>();
        static ResourceDictionary _controls;

        static Theme()
        {
            GetThemes();
        }

        public static Theme FromName(string themeName)
        {
            foreach (var theme in Themes)
            {
                if (theme.Name == themeName)
                    return theme;
            }

            return null;
        }

        public static bool Contains(string themeName)
        {
            foreach (var theme in Themes)
            {
                if (theme.Name == themeName)
                    return true;
            }

            return false;
        }

        public static ResourceDictionary Controls
        {
            get
            {
                if (_controls == null)
                {
                    _controls = new ResourceDictionary() { Source = new Uri("pack://application:,,,/MetroApp;component/Themes/Controls.xaml") };
                }

                return _controls;
            }
        }

        static void GetThemes()
        {
            lock (Themes)
            {
                foreach (Type type in typeof(Theme).Assembly.GetTypes())
                {
                    var attribute = type.GetCustomAttribute(typeof(ThemeAttribute));
                    if (attribute != null)
                    {
                        var theme = Activator.CreateInstance(type);
                        Themes.Add(theme as Theme);
                    }
                }
            }
        }

        public static Theme GetControlTheme(ResourceDictionary resource)
        {
            try
            {
                string dirPath = "pack://application:,,,/MetroApp;component/Themes/";

                var enumerator = resource.MergedDictionaries.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    var currentRd = enumerator.Current;
                    string dirString = currentRd.Source.ToString();

                    if (dirString.Contains(dirPath))
                    {
                        int index = dirString.IndexOf(".xaml");
                        string theme = dirString.Substring(dirPath.Length, dirString.Length - dirPath.Length - 5);
                        if (Theme.Contains(theme))
                        {
                            enumerator.Dispose();
                            return Theme.FromName(theme);
                        }
                    }
                    else
                    {
                        Theme theme = GetControlTheme(currentRd);
                        if (theme != null)
                            return theme;
                    }
                }

                enumerator.Dispose();
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool IsContainControlsResource(ResourceDictionary resource)
        {
            try
            {
                string dirPath = "pack://application:,,,/MetroApp;component/Themes/Controls.xaml";

                var enumerator = resource.MergedDictionaries.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    var currentRd = enumerator.Current;
                    string dirString = currentRd.Source.ToString();
                    if (dirString.Contains(dirPath))
                    {
                        enumerator.Dispose();
                        return true;
                    }
                    else
                    {
                        bool contains = IsContainControlsResource(currentRd);
                        if (contains)
                            return true;
                    }
                }

                enumerator.Dispose();
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static ResourceDictionary GetControlsDictionary(ResourceDictionary resource)
        {
            try
            {
                string dirPath = "pack://application:,,,/MetroApp;component/Themes/Controls.xaml";

                var enumerator = resource.MergedDictionaries.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    var currentRd = enumerator.Current;
                    string dirString = currentRd.Source.ToString();
                    if (dirString.Contains(dirPath))
                    {
                        enumerator.Dispose();
                        return currentRd;
                    }
                    else
                    {
                        ResourceDictionary dir = GetControlsDictionary(currentRd);
                        if (dir != null)
                            return dir;
                    }
                }

                enumerator.Dispose();
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Name
        {
            get;
            internal set;
        }

        public ResourceDictionary Source 
        {
            get 
            {
                if(_source == null)
                {
                    _source = new ResourceDictionary() { Source = new Uri(String.Format("pack://application:,,,/MetroApp;component/Themes/{0}.xaml", this.Name)) };
                }

                return _source;
            } 
        }

        ResourceDictionary _source;

        public override string ToString()
        {
            return GetType().Name.Replace("Theme", string.Empty);
        }

        internal class DefaultStyleKeyHelper : Control
        {
            public static void SetDefaultStyleKey(Control control, object value)
            {
                if (StyleManager.IsEnabled)
                {
                    control.SetValue(DefaultStyleKeyProperty, value);
                }
            }
        }
    }

    /// <summary>
    /// The ThemeLocation attribute decorates a Theme class and carries information about where the theme is hosted.
    /// If a theme does not have that attribute, it is treated as an external theme by default.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class ThemeAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeAttribute"/> class.
        /// </summary>
        /// <param name="location">The location.</param>
        public ThemeAttribute()
        {
        }
    }
}
