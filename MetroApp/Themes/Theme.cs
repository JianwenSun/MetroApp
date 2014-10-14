using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MetroApp.Themes
{
    public abstract class Theme
    {
        public static bool IsDictionaryContainTheme(ResourceDictionary resourceDictionary)
        {
            if (resourceDictionary.Source.ToString().Contains("pack://application:,,,/MetroApp;component/Themes/"))
                return true;
            return false;
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
}
