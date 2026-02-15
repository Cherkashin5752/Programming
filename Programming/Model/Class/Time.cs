using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        
        public int Hours
        {
            get { return _hours; }
            set
            {
                if (_hours > 23 || _hours < 0)
                    throw new ArgumentException();
                _hours = value;
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (_minutes > 59 || _minutes < 0)
                    throw new ArgumentException();
                _minutes = value;
            }
        }

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (_seconds > 59 || _seconds < 0)
                    throw new ArgumentException();
                _seconds = value;
            }
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Time()
        {

        }
    }
}
