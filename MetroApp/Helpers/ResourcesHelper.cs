using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MetroApp.Helpers
{
    public class ResourcesHelper
    {
        public static readonly DependencyProperty ResourceProperty = DependencyProperty.RegisterAttached("Resource", typeof(ResourceDictionary), typeof(ResourcesHelper), new FrameworkPropertyMetadata(null, ResourcePropertyChangedCallback));

        private static void ResourcePropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            FrameworkElement elemet = dependencyObject as FrameworkElement;
            if(elemet != null)
            {
                elemet.Resources = e.NewValue as ResourceDictionary;
            }
        }

        public static void SetResource(DependencyObject obj, object value)
        {
            obj.SetValue(ResourceProperty, value);
        }

        public static ResourceDictionary GetResource(DependencyObject obj)
        {
            return (ResourceDictionary)obj.GetValue(ResourceProperty);
        }
    }
}
