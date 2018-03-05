using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace BinaryClock
{
    public enum BinaryTimeValue
    {
        BinaryS1One,
        BinaryS1Two,
        BinaryS1Four,
        BinaryS1Eight,
        BinaryS10One,
        BinaryS10Two,
        BinaryS10Four,
        BinaryM1One,
        BinaryM1Two,
        BinaryM1Four,
        BinaryM1Eight,
        BinaryM10One,
        BinaryM10Two,
        BinaryM10Four,
        BinaryH1One,
        BinaryH1Two,
        BinaryH1Four,
        BinaryH1Eight,
        BinaryH10One,
        BinaryH10Two        
    }
    public class BinaryTimerConverter : IValueConverter
    {
        public BinaryTimeValue BinaryTimeValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime dateTime = (DateTime)value;            
            Brush fillColor = Brushes.LightGray;
                                    
            int sec1 = dateTime.Second % 10;
            int sec10 = dateTime.Second / 10;
            int min1 = dateTime.Minute % 10;
            int min10 = dateTime.Minute / 10;
            int h1 = dateTime.Hour % 10;
            int h10 = dateTime.Hour / 10;

            switch (BinaryTimeValue)
            {
                case BinaryTimeValue.BinaryS1One:
                    if (sec1 == 1 || sec1 == 3 || sec1 == 5 || sec1 == 7 || sec1 == 9)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryS1Two:
                    if (sec1 == 2 || sec1 == 3 || sec1 == 6 || sec1 == 7)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryS1Four:
                    if (sec1 == 4 || sec1 == 5 || sec1 == 6 || sec1 == 7)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryS1Eight:
                    if (sec1 == 8 || sec1 == 9)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryS10One:
                    if (sec10 == 1 || sec10 == 3 || sec10 ==5)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryS10Two:
                    if (sec10 == 2 || sec10 == 3 )
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryS10Four:
                    if (sec10 == 4 || sec10 == 5)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryM1One:
                    if (min1 == 1 || min1 == 3 || min1 == 5 || min1 == 7 || min1 == 9)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryM1Two:
                    if (min1 == 2 || min1 == 3 || min1 == 6 || min1 == 7)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryM1Four:
                    if (min1 == 4 || min1 == 5 || min1 == 6 || min1 == 7)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryM1Eight:
                    if (min1 == 8 || min1 == 9)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryM10One:
                    if (min10 == 1 || min10 == 3 || min10 == 5)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryM10Two:
                    if (min10 == 2 || min10 == 3)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryM10Four:
                    if (min10 == 4 || min10 == 5)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryH1One:
                    if (h1 == 1 || h1 == 3 || h1 == 5 || h1 == 7 || h1 == 9)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryH1Two:
                    if (h1 == 2 || h1 == 3 || h1 == 6 || h1 == 7)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryH1Four:
                    if (h1 == 4 || h1 == 5 || h1 == 6 || h1 == 7)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryH1Eight:
                    if (h1 == 8 || h1 == 9)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryH10One:
                    if (h10 == 1 || h10 == 3 || h10 == 5)
                        fillColor = Brushes.Black;
                    break;

                case BinaryTimeValue.BinaryH10Two:
                    if (h10 == 2 || h10 == 3)
                        fillColor = Brushes.Black;
                    break;

                default:
                    fillColor = Brushes.LightGray;
                    break;
            }
            
            return fillColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
