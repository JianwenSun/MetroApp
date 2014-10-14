using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MetroApp.Themes
{
    public enum MetroColorKey
    {
        AccentColorKey,
        BasicColorKey,
        WeakColorKey,
        StrongColorKey,
        MainColorKey,
        MarkerColorKey,
        ValidationColorKey,

        WindowBackgroundColorKey,
        WindowForegroundColorKey,
        WindowStateButtonMouseOverColorKey,
        WindowStateButtonCloseMouseOverColorKey,
        WindowStateButtonPressedColorKey,
        WindowStateButtonClosePressedColorKey,
        WindowStateButtonDisabledColorKey,
        WindowCommandsForegroundColorKey,
        WindowCommandsDisabledColorKey,

        LabelForegroundColorKey,

        ButtonBackgroundColorKey,
        ButtonBackgroundDisabledColorKey,
        ButtonForegroundColorKey,
        ButtonBorderColorKey,
        ButtonMouseOverColorKey,
        ButtonPressedColorKey
    }

    public static class MetroColorKeys
    {
        public static MetroColorKey AccentColorKey
        {
            get { return MetroColorKey.AccentColorKey; }
        }
        public static MetroColorKey WeakColorKey
        {
            get { return MetroColorKey.WeakColorKey; }
        }

        public static MetroColorKey BasicColorKey
        {
            get { return MetroColorKey.BasicColorKey; }
        }

        public static MetroColorKey StrongColorKey
        {
            get { return MetroColorKey.StrongColorKey; }
        }

        public static MetroColorKey MainColorKey
        {
            get { return MetroColorKey.MainColorKey; }
        }

        public static MetroColorKey MarkerColorKey
        {
            get { return MetroColorKey.MarkerColorKey; }
        }

        public static MetroColorKey ValidationColorKey
        {
            get { return MetroColorKey.ValidationColorKey; }
        }

        public static MetroColorKey WindowBackgroundColorKey
        {
            get { return MetroColorKey.WindowBackgroundColorKey; }
        }

        public static MetroColorKey WindowForegroundColorKey
        {
            get { return MetroColorKey.WindowForegroundColorKey; }
        }

        public static MetroColorKey WindowStateButtonMouseOverColorKey
        {
            get { return MetroColorKey.WindowStateButtonMouseOverColorKey; }
        }

        public static MetroColorKey WindowStateButtonCloseMouseOverColorKey
        {
            get { return MetroColorKey.WindowStateButtonCloseMouseOverColorKey; }
        }

        public static MetroColorKey WindowStateButtonClosePressedColorKey
        {
            get { return MetroColorKey.WindowStateButtonClosePressedColorKey; }
        }

        public static MetroColorKey WindowStateButtonPressedColorKey
        {
            get { return MetroColorKey.WindowStateButtonPressedColorKey; }
        }

        public static MetroColorKey WindowStateButtonDisabledColorKey
        {
            get { return MetroColorKey.WindowStateButtonDisabledColorKey; }
        }

        public static MetroColorKey WindowCommandsForegroundColorKey
        {
            get { return MetroColorKey.WindowCommandsForegroundColorKey; }
        }

        public static MetroColorKey WindowCommandsDisabledColorKey
        {
            get { return MetroColorKey.WindowCommandsDisabledColorKey; }
        }

        public static MetroColorKey LabelForegroundColorKey
        {
            get { return MetroColorKey.LabelForegroundColorKey; }
        }

        public static MetroColorKey ButtonBackgroundColorKey
        {
            get { return MetroColorKey.ButtonBackgroundColorKey; }
        }

        public static MetroColorKey ButtonBackgroundDisabledColorKey
        {
            get { return MetroColorKey.ButtonBackgroundDisabledColorKey; }
        }

        public static MetroColorKey ButtonForegroundColorKey
        {
            get { return MetroColorKey.ButtonForegroundColorKey; }
        }

        public static MetroColorKey ButtonBorderColorKey
        {
            get { return MetroColorKey.ButtonBorderColorKey; }
        }

        public static MetroColorKey ButtonMouseOverColorKey
        {
            get { return MetroColorKey.ButtonMouseOverColorKey; }
        }

        public static MetroColorKey ButtonPressedColorKey
        {
            get { return MetroColorKey.ButtonPressedColorKey; }
        }
    }
}
