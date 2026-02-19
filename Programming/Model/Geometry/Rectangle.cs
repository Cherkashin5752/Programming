using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal class Rectangle
    {
        private string _color;
        private int _length;
        private int _width;
        private Point2D _center;
        private static int _allRectanglesCount;
        private int _id;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Length
        {
            get { return _length; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
            }
        }

        public int Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
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

        public int X
        {
            get { return _center.X; }
            set => _center = new Point2D(value, _center.Y);
        }

        public int Y
        {
            get => _center.Y;
            set => _center = new Point2D(_center.X, value);
        }

        public Rectangle(int length, int width, string color, int centerX, int centerY)
        {
            Length = length;
            Width = width;
            Color = color;
            _center = new Point2D(centerX, centerY);
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }
    }
}
