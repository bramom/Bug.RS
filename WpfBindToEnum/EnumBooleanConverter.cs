using System;
using System.Windows;
using System.Windows.Data;

namespace WpfApplication1
{
    public class EnumBooleanConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string parameterString = (string)parameter;

            if (parameterString == null)
                return DependencyProperty.UnsetValue;
            
            Days parameterValue = (Days) Enum.Parse(typeof(Days), parameterString);

            bool isSet;
            Days myDays = ((Days)value);

            if (parameterValue == Days.None)
                isSet = (myDays == Days.None);
            else
                isSet = myDays.HasFlag(parameterValue);

            return isSet;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string parameterString = (string)parameter;

            if (parameterString == null)
                return DependencyProperty.UnsetValue;

            return Enum.Parse(targetType, parameterString);
        }

        #endregion
    }
}
