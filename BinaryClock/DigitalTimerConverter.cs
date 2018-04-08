using System;
using System.Globalization;
using System.Windows.Data;

namespace BinaryClock
{
    public enum TimeValue
    {
        Hours10,
        Hours1,
        Minutes10,
        Minutes1,
        Seconds10,
        Seconds1
    }

    public class DigitalTimerConverter : IValueConverter
    {
        public TimeValue TimeValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var dt = (DateTime)value;
            var time = string.Empty;
            switch (TimeValue)
            {
                case TimeValue.Hours10:
                    time = (dt.Hour / 10).ToString();
                    break;
                case TimeValue.Hours1:
                    time = (dt.Hour % 10).ToString();
                    break;
                case TimeValue.Minutes10:
                    time = (dt.Minute / 10).ToString();
                    break;
                case TimeValue.Minutes1:
                    time = (dt.Minute % 10).ToString();
                    break;
                case TimeValue.Seconds10:
                    time = (dt.Second / 10).ToString();
                    break;
                case TimeValue.Seconds1:
                    time = (dt.Second % 10).ToString();
                    break;
            }
            return time;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
