using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace MetroApp.Controls
{
    public class MetroWindowCommands : ItemsControl
    {
        static MetroWindowCommands()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MetroWindowCommands), new FrameworkPropertyMetadata(typeof(MetroWindowCommands)));
        }

        public MetroWindowCommands()
        {
            
        }
    }
}
