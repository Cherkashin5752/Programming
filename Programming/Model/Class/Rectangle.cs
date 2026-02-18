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
        private Point2D _center;
        private static int _allRectanglesCount;
        private int _id;

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
                if (Validator.AssertOnPositiveValue(value))
                    _length = value;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (Validator.AssertOnPositiveValue(value))
                    _width = value;
            }
        }

        public Point2D Center
        {
            get { return _center; }
            private set
            {
                _center = value;
            }
        }

        public int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }

        public int Id
        {
            get { return _id; }
        }

        public Rectangle(double length, double width, string color, double centerX, double centerY)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(centerX, centerY);
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle()
        {

        }
    }
}
