using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace MetroApp.Themes
{
    public static class ColorKeys
    {
        static ColorKeys()
        {
            PropertyInfo[] properties = typeof(ColorKeys).GetProperties();
            foreach (var property in properties)
            {
                if (property.SetMethod != null)
                    property.SetMethod.Invoke(null, new object[1] { property.Name });
            }
        }

        public static string AccentColorKey { get; private set; }
        public static string AccentWeakColorKey { get; private set; }
        public static string AccentDisableColorKey { get; private set; }
        public static string WeakColorKey { get; private set; }
        public static string WeakDisableColorKey { get; private set; }
        public static string BasicColorKey { get; private set; }
        public static string BasicMouseOverColorKey { get; private set; }
        public static string BasicPressColorKey { get; private set; }
        public static string BasicDisableColorKey { get; private set; }
        public static string BasicFouseColorKey { get; private set; }
        public static string StrongColorKey { get; private set; }
        public static string MainColorKey { get; private set; }
        public static string MainStrongColorKey { get; private set; }
        public static string MainDisableColorKey { get; private set; }
        public static string MarkerColorKey { get; private set; }
        public static string ValidationColorKey { get; private set; }
    }
}
