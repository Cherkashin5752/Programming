using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Point2D
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }
            private set
            {
                _x = value;
            }
        }

        public double Y
        {
            get { return _y; }
            private set
            {
                _y = value;
            }
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
