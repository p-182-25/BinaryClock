using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryClockTest.ModelWidoku
{
    using Model;
    using System.Windows.Threading;

    public class AppModelWidoku : INotifyPropertyChanged
    {
        private AppModel appModel = new AppModel();

        public int Sec1
        {
            get { return appModel.sec1; }
            set
            {
                appModel.sec1 = value;
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public AppModelWidoku()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        public void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            Sec1 = DateTime.Now.Second % 10;
        }
    }
}
