using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Rectangle
    {
        private string _color;
        private double _length;
        private double _width;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public double Length
        {
            get { return _length; }
            set
            { 
                if (_length < 0)
                    throw new ArgumentException();
                _length = value;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (_width < 0)
                    throw new ArgumentException();
                _width = value;
            }
        }

        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        public Rectangle()
        {

        }
    }
}
