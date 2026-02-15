using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Time
    {
        private int hours;
        private int minutes;
        private int seconds;
        
        public int Hours
        {
            get { return hours; }
            set
            {
                if (hours > 23 || hours < 0)
                    throw new ArgumentException();
                hours = value;
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (minutes > 59 || minutes < 0)
                    throw new ArgumentException();
                minutes = value;
            }
        }

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (seconds > 59 || seconds < 0)
                    throw new ArgumentException();
                seconds = value;
            }
        }

        public Time(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
        }

        public Time()
        {

        }
    }
}
