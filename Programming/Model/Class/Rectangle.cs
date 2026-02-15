using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Rectangle
    {
        private string Color { get; set; }
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set
            { 
                if (length < 0)
                    throw new ArgumentException();
                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (width < 0)
                    throw new ArgumentException();
                width = value;
            }
        }

        public Rectangle(double _length, double _width, string _color)
        {
            Length = _length;
            Width = _width;
            Color = _color;
        }

        public Rectangle()
        {

        }
    }
}
