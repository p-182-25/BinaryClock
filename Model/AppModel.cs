using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryClockTest.Model
{
    public class AppModel
    {
        // int h10 = DateTime.Now.Hour / 10;
        // int h1 = DateTime.Now.Hour % 10;
        // int min10 = DateTime.Now.Minute / 10;
        // int min1 = DateTime.Now.Minute % 10;
        // int sec10 = DateTime.Now.Second / 10;
        // int sec1 = DateTime.Now.Second % 10;

        public int hour10 { get; set; }
        public int hour1 { get; set; }
        public int min10 { get; set; }
        public int min1 { get; set; }
        public int sec10 { get; set; }
        public int sec1 { get; set; }

    }
}
