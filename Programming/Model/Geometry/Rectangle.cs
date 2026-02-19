using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит информацию о прямоугольнике
    /// </summary>
    internal class Rectangle
    {
        private string _color;
        private int _length;
        private int _width;
        private Point2D _center;
        private static int _allRectanglesCount;
        private int _id;

        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника
        /// </summary>
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// Возвращает и задаёт длину прямоугольника. Только положительное число
        /// </summary>
        public int Length
        {
            get { return _length; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Только положительное число
        /// </summary>
        public int Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает номер прямоугольника
        /// </summary>
        public int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }

        /// <summary>
        /// Возвращает уникальный идендификатор прямоугольника
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задаёт координату X прямоугольника. Только положительное число
        /// </summary>
        public int X
        {
            get { return _center.X; }
            set => _center = new Point2D(value, _center.Y);
        }

        /// <summary>
        /// Возвращает и задаёт координату Y прямоугольника. Только положительное число
        /// </summary>
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
