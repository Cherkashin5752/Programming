using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит координаты X и Y
    /// </summary>
    internal class Point2D
    {
        private int _x;
        private int _y;

        /// <summary>
        /// Возвращает и задаёт значение координаты X. Только положительное число
        /// </summary>
        public int X
        {
            get { return _x; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение координаты Y. Только положительное число
        /// </summary>
        public int Y
        {
            get { return _y; }
            private set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
