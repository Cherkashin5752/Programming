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
            // Если расстояния центров по X меньше разности их ширины и
            // если раастояние центров по Y меньше разности их длин,
            // то они пересекаются
            if (Math.Abs(rectangle1.X - rectangle2.X) < Math.Abs(rectangle1.Width - rectangle2.Width) / 2 &&
                Math.Abs(rectangle1.Y - rectangle2.Y) < Math.Abs(rectangle1.Length - rectangle2.Length) / 2)
                return true;
            else
                return false;
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
