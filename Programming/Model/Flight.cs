using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит в данные о рейсе
    /// </summary>
    internal class Flight
    {
        private string _departure;
        private string _destination;
        private int _time;

        /// <summary>
        /// Возвращает и задаёт пункт вылета
        /// </summary>
        public string Departure
        {
            get { return _departure; }
            set { _departure = value; }
        }

        /// <summary>
        /// Возвращает и задаёт пункт назначения
        /// </summary>
        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        /// <summary>
        /// Возвращает и задаёт время рейса. Только положительно число
        /// </summary>
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
