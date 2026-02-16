using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Ring
    {
        private Point2D _center;
        private double _innerRadius;
        private double _outerRadius;

        public Point2D Center
        {
            get { return _center; }
            set { _center = value; }
        }

        public double OuterRadius
        {
            get { return _outerRadius; }
            set 
            {
                if (Validator.AssertOnPositiveValue(value))
                    _outerRadius = value;
            }
        }
        public double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                if (Validator.AssertValueInRange(value, 0, OuterRadius))
                    _innerRadius = value;
            }
        }

        public double Area
        {
            get { return Math.PI * Math.Pow(OuterRadius, 2) - Math.PI * Math.Pow(InnerRadius, 2); }
        }

        public Ring(double innerRadius, double outerRadius)
        {
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
            Center = new Point2D(OuterRadius / 2, OuterRadius / 2);
        }

        public Ring()
        {

        }
    }
}
