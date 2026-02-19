using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    static class CollisionManager
    {
        // Проверка пересечения прямоугольников
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.X < rectangle2.X + rectangle2.Width &&
                   rectangle1.X + rectangle1.Width > rectangle2.X &&
                   rectangle1.Y < rectangle2.Y + rectangle2.Length &&
                   rectangle1.Y + rectangle1.Length > rectangle2.Y;
        }

        // Проверка пересечения колец
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            // Если расстояние от центра одного кольца до другого меньше суммы их радусов
            // значит они пересекаются
            if (Math.Sqrt(Math.Pow(Math.Abs(ring1.X - ring2.X), 2) +
                Math.Pow(Math.Abs(ring1.Y - ring2.Y), 2)) < ring1.OuterRadius + ring2.OuterRadius)
                return true;
            else
                return false;
        }
    }
}
