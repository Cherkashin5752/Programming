using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит в себе информацию о кольце
    /// </summary>
    internal class Ring
    {
        private Point2D _center;
        private double _innerRadius;
        private double _outerRadius;

        /// <summary>
        /// Возвращает и задаёт значение координаты X кольца. Только положительное число
        /// </summary>
        public int X
        {
            get { return _center.X; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _center = new Point2D(value, Y);
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение координаты Y кольца. Только положительное число
        /// </summary>
        public int Y
        {
            get { return _center.Y; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _center = new Point2D(X, value);
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение внешнего радиуса кольца. Только положительно число
        /// </summary>
        public double OuterRadius
        {
            get { return _outerRadius; }
            set 
            {
                if (Validator.AssertOnPositiveValue(value))
                    _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение внутреннего радиуса кольца. Только положительно число
        /// </summary>
        public double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                if (Validator.AssertValueInRange(value, 0, OuterRadius))
                    _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь кольца между внутренней и внешней частью
        /// </summary>
        public double Area
        {
            get { return Math.PI * Math.Pow(OuterRadius, 2) - Math.PI * Math.Pow(InnerRadius, 2); }
        }

        public Ring(double innerRadius, double outerRadius, int centerX, int centerY)
        {
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
            _center = new Point2D(centerX, centerY);
        }

        public Ring()
        {

        }
    }
}
