using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApplication1
{
    [ValueConversion(typeof(DateTime), typeof(Brush))]
    public class YearConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var aDate = (DateTime) value;
            switch (aDate.Year.ToString())
            {
                case "1994":
                    return new SolidColorBrush(Colors.Purple);
                case "1995":
                    return new SolidColorBrush(Colors.Green);
                case "1996":
                    return new SolidColorBrush(Colors.Red);
                default:
                    return new SolidColorBrush(Colors.Yellow);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}