using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MetroApp.Converters
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public bool Direction
        {
            get;
            set;
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if(value is bool)
            {
                return (bool)value && Direction ? Visibility.Visible : Visibility.Collapsed;
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if(value is Visibility)
            {
                switch ((Visibility)value)
                {
                    case Visibility.Collapsed:
                        return !Direction;
                    case Visibility.Hidden:
                        return !Direction;
                    case Visibility.Visible:
                        return Direction;
                    default:
                        break;
                }
            }
            return false;
        }
    }
}
