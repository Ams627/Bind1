using System;
using System.Windows;
using System.Windows.Data;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Bind1
{
    public class MyValueConverter : ConverterBase, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
