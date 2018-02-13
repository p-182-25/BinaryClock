using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BinaryClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();                        
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            int h10 = DateTime.Now.Hour / 10;
            int h1 = DateTime.Now.Hour % 10;
            int min10 = DateTime.Now.Minute / 10;
            int min1 = DateTime.Now.Minute % 10;
            int sec10 = DateTime.Now.Second / 10;
            int sec1 = DateTime.Now.Second % 10;
            txtHours10.Text = h10.ToString();
            txtHours1.Text = h1.ToString();

            txtMinutes10.Text = min10.ToString();
            txtMinutes1.Text = min1.ToString();

            txtSeconds10.Text = sec10.ToString();
            txtSeconds1.Text = sec1.ToString();            

            h10_1.Fill = Brushes.LightGray;
            h10_2.Fill = Brushes.LightGray;

            h1_1.Fill = Brushes.LightGray;
            h1_2.Fill = Brushes.LightGray;
            h1_4.Fill = Brushes.LightGray;
            h1_8.Fill = Brushes.LightGray;

            min10_1.Fill = Brushes.LightGray;
            min10_2.Fill = Brushes.LightGray;
            min10_4.Fill = Brushes.LightGray;

            min1_1.Fill = Brushes.LightGray;
            min1_2.Fill = Brushes.LightGray;
            min1_4.Fill = Brushes.LightGray;
            min1_8.Fill = Brushes.LightGray;

            sec10_1.Fill = Brushes.LightGray;
            sec10_2.Fill = Brushes.LightGray;
            sec10_4.Fill = Brushes.LightGray;

            sec1_1.Fill = Brushes.LightGray;
            sec1_2.Fill = Brushes.LightGray;
            sec1_4.Fill = Brushes.LightGray;
            sec1_8.Fill = Brushes.LightGray;


            switch (h10)
            {                
                case 1:
                    h10_1.Fill = Brushes.Black;                    
                    break;
                case 2:
                    h10_2.Fill = Brushes.Black;
                    break;
                default:
                    h10_1.Fill = Brushes.LightGray;
                    h10_2.Fill = Brushes.LightGray;
                    break;
            }

            switch (h1)
            {
                case 1:
                    h1_1.Fill = Brushes.Black;                        
                    break;
                case 2:
                    h1_2.Fill = Brushes.Black;
                    break;
                case 3:
                    h1_1.Fill = Brushes.Black;
                    h1_2.Fill = Brushes.Black;
                    break;
                case 4:
                    h1_4.Fill = Brushes.Black;
                    break;
                case 5:
                    h1_1.Fill = Brushes.Black;
                    h1_4.Fill = Brushes.Black;
                    break;
                case 6:
                    h1_2.Fill = Brushes.Black;
                    h1_4.Fill = Brushes.Black;
                    break;
                case 7:
                    h1_1.Fill = Brushes.Black;
                    h1_2.Fill = Brushes.Black;
                    h1_4.Fill = Brushes.Black;
                    break;
                case 8:
                    h1_8.Fill = Brushes.Black;
                    break;
                case 9:
                    h1_1.Fill = Brushes.Black;
                    h1_8.Fill = Brushes.Black;
                    break;
                default:
                    h1_1.Fill = Brushes.LightGray;
                    h1_2.Fill = Brushes.LightGray;
                    h1_4.Fill = Brushes.LightGray;
                    h1_8.Fill = Brushes.LightGray;
                    break;
            }

            switch (min10)
            {
                case 1:
                    min10_1.Fill = Brushes.Black;
                    break;
                case 2:
                    min10_2.Fill = Brushes.Black;
                    break;
                case 3:
                    min10_1.Fill = Brushes.Black;
                    min10_2.Fill = Brushes.Black;
                    break;
                case 4:
                    min10_4.Fill = Brushes.Black;
                    break;
                case 5:
                    min10_1.Fill = Brushes.Black;
                    min10_4.Fill = Brushes.Black;
                    break;
                default:
                    min10_1.Fill = Brushes.LightGray;
                    min10_2.Fill = Brushes.LightGray;
                    min10_4.Fill = Brushes.LightGray;
                    break;
            }

            switch (min1)
            {
                case 1:
                    min1_1.Fill = Brushes.Black;
                    break;
                case 2:
                    min1_2.Fill = Brushes.Black;
                    break;
                case 3:
                    min1_1.Fill = Brushes.Black;
                    min1_2.Fill = Brushes.Black;
                    break;
                case 4:
                    min1_4.Fill = Brushes.Black;
                    break;
                case 5:
                    min1_1.Fill = Brushes.Black;
                    min1_4.Fill = Brushes.Black;
                    break;
                case 6:
                    min1_2.Fill = Brushes.Black;
                    min1_4.Fill = Brushes.Black;
                    break;
                case 7:
                    min1_1.Fill = Brushes.Black;
                    min1_2.Fill = Brushes.Black;
                    min1_4.Fill = Brushes.Black;
                    break;
                case 8:
                    min1_8.Fill = Brushes.Black;
                    break;
                case 9:
                    min1_1.Fill = Brushes.Black;
                    min1_8.Fill = Brushes.Black;
                    break;
                default:
                    min1_1.Fill = Brushes.LightGray;
                    min1_2.Fill = Brushes.LightGray;
                    min1_4.Fill = Brushes.LightGray;
                    min1_8.Fill = Brushes.LightGray;
                    break;
            }

            switch (sec10)
            {
                case 1:
                    sec10_1.Fill = Brushes.Black;
                    break;
                case 2:
                    sec10_2.Fill = Brushes.Black;
                    break;
                case 3:
                    sec10_1.Fill = Brushes.Black;
                    sec10_2.Fill = Brushes.Black;
                    break;
                case 4:
                    sec10_4.Fill = Brushes.Black;
                    break;
                case 5:
                    sec10_1.Fill = Brushes.Black;
                    sec10_4.Fill = Brushes.Black;
                    break;
                default:
                    sec10_1.Fill = Brushes.LightGray;
                    sec10_2.Fill = Brushes.LightGray;
                    sec10_4.Fill = Brushes.LightGray;
                    break;
            }

            switch (sec1)
            {
                case 1:
                    sec1_1.Fill = Brushes.Black;
                    break;
                case 2:
                    sec1_2.Fill = Brushes.Black;
                    break;
                case 3:
                    sec1_1.Fill = Brushes.Black;
                    sec1_2.Fill = Brushes.Black;
                    break;
                case 4:
                    sec1_4.Fill = Brushes.Black;
                    break;
                case 5:
                    sec1_1.Fill = Brushes.Black;
                    sec1_4.Fill = Brushes.Black;
                    break;
                case 6:
                    sec1_2.Fill = Brushes.Black;
                    sec1_4.Fill = Brushes.Black;
                    break;
                case 7:
                    sec1_1.Fill = Brushes.Black;
                    sec1_2.Fill = Brushes.Black;
                    sec1_4.Fill = Brushes.Black;
                    break;
                case 8:
                    sec1_8.Fill = Brushes.Black;
                    break;
                case 9:
                    sec1_1.Fill = Brushes.Black;
                    sec1_8.Fill = Brushes.Black;
                    break;
                default:
                    sec1_1.Fill = Brushes.LightGray;
                    sec1_2.Fill = Brushes.LightGray;
                    sec1_4.Fill = Brushes.LightGray;
                    sec1_8.Fill = Brushes.LightGray;
                    break;
            }
        }
    }
}
