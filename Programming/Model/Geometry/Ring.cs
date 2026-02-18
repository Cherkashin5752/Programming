using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
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

        public double X
        {
            get { return _center.X; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _center = new Point2D(value, Y);
            }
        }

        public double Y
        {
            get { return _center.Y; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _center = new Point2D(X, value);
            }
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
