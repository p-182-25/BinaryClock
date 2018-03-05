using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace BinaryClock.ViewModel
{    
    public class Timer : INotifyPropertyChanged
    {
        public DateTime CurrentTime
        {
            get
            {
                return DateTime.Now;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(CurrentTime)));
        }

        public Timer()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Tick += (sender, e) => { OnPropertyChanged(); };
            dispatcherTimer.Start();
        }
    }
}
