using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MetroApp.Converters
{
    public class StrokeMaginConverter : IValueConverter
    {
        static StrokeMaginConverter instance = null;
        public static StrokeMaginConverter Instance
        {
            get { return instance = instance ?? new StrokeMaginConverter(); }
        }

        public double Offset
        {
            get;
            set;
        }

        public StrokeMaginConverter()
        {
            this.Offset = 6;
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is double)
            {
                double border = (double)value - this.Offset;
                return border > 0 ? border : (double)value;
            }

            return this.Offset;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
