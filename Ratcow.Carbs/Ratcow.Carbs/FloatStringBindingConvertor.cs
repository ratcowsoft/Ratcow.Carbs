using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Ratcow.Carbs
{
    public class FloatStringConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return "0";
            }

            float newValue = (float)value;
            return newValue.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stringValue = value as string;
            if (string.IsNullOrEmpty(stringValue))
            {
                stringValue = "0";
            }

            if (float.TryParse(stringValue, out float result))
            {
                return result;
            }
            return 0;
        }

    }
}
