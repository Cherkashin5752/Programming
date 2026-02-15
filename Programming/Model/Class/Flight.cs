using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Flight
    {
        private string departure { get; set; }
        private string destination { get; set; }
        
        private int time;
        private double Time
        {
            get { return time; }
            set
            {
                if (time < 0)
                    throw new ArgumentException();
            }
        }
    }
}
