using MetroApp.Controls;
using Microsoft.Windows.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MetroApp.Helpers
{
    internal static class MetroWindowHelpers
    {
        /// <summary>
        /// Sets the IsHitTestVisibleInChromeProperty to a MetroWindow template child
        /// </summary>
        /// <param name="window">The MetroWindow</param>
        /// <param name="name">The name of the template child</param>
        public static void SetIsHitTestVisibleInChromeProperty<T>(this MetroWindow window, string name) where T : DependencyObject
        {
            if (window == null)
            {
                return;
            }
            var elementPart = window.GetPart<T>(name);
            if (elementPart != null)
            {
                elementPart.SetValue(WindowChrome.IsHitTestVisibleInChromeProperty, true);
            }
        }
    }
}
