using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Flight
    {
        private string _departure;
        private string _destination;
        private int _time;

        public string Departure
        {
            get { return _departure; }
            set { _departure = value; }
        }

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public int Time
        {
            get { return _time; }
            set
            {
                if (Validator.AssertOnPositiveValue(value))
                    _time = value;
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
