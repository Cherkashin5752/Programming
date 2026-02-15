using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Flight
    {
        private string Departure { get; set; }
        private string Destination { get; set; }
        
        private int time;
        public int Time
        {
            get { return time; }
            set
            {
                if (time < 0)
                    throw new ArgumentException();
                time = value;
            }
        }

        public Flight(string _departure, string _destination, int _time)
        {
            Departure = _departure;
            Destination = _destination;
            Time = _time;
        }

        public Flight()
        {

        }
    }
}
