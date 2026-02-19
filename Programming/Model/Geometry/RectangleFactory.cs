using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    static class RectangleFactory
    {
        static Random rnd = new Random();
        static private string[] _colors = { "Red", "Blue", "Green", "Yellow", "Orange",
            "Purple", "Pink", "Brown", "Black", "White" };

        /// <summary>
        /// Создаёт прямоугольник с случайными значениями свойст
        /// </summary>
        /// <returns>Объект класса Rectangle</returns>
        static public Rectangle Randomize()
        {
            return new Rectangle(rnd.Next(10, 200), rnd.Next(10, 200), _colors[rnd.Next(0, 10)], rnd.Next(10, 300), rnd.Next(10, 300));
        }
    }
}
