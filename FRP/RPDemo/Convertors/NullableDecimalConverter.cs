using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RPDemo.Converters
{
    class NullableDecimalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => value;
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => decimal.TryParse(value?.ToString(), NumberStyles.Number, culture?.NumberFormat, out var dec) ? dec : default(decimal?);
    }
}
