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
        private int Hours
        {
            get { return hours; }
            set
            {
                if (hours > 23 || hours < 0)
                    throw new ArgumentException();
            }
        }

        private int minutes;
        private int Minutes
        {
            get { return minutes; }
            set
            {
                if (minutes > 59 || hours < 0)
                    throw new ArgumentException();
            }
        }

        private int seconds;
        private int Seconds
        {
            get { return seconds; }
            set
            {
                if (seconds > 59 || hours < 0)
                    throw new ArgumentException();
            }
        }
    }
}
