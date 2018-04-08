using System;
using System.ComponentModel;
using System.Windows.Threading;

namespace BinaryClock.ViewModel
{
    public class Timer : INotifyPropertyChanged
    {
        public DateTime CurrentTime => DateTime.Now;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentTime)));
        }

        public Timer()
        {
            var dispatcherTimer = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 1)
            };
            dispatcherTimer.Tick += (sender, e) => { OnPropertyChanged(); };
            dispatcherTimer.Start();
        }
    }
}
