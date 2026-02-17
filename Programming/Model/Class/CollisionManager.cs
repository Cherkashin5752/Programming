using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    static class CollisionManager
    {
        // Проверка пересечения прямоугольников
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            // Если расстояния центров по X меньше разности их ширины и
            // если раастояние центров по Y меньше разности их длин,
            // то они пересекаются
            if (Math.Abs(rectangle1.Center.X - rectangle2.Center.X) < Math.Abs(rectangle1.Width - rectangle2.Width) / 2 &&
                Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y) < Math.Abs(rectangle1.Length - rectangle2.Length) / 2)
                return true;
            else
                return false;
        }

        // Проверка пересечения колец
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            // Если расстояние от центра одного кольца до другого меньше суммы их радусов
            // значит они пересекаются
            if (Math.Sqrt(Math.Pow(Math.Abs(ring1.Center.X - ring2.Center.X), 2) +
                Math.Pow(Math.Abs(ring1.Center.Y - ring2.Center.Y), 2)) < ring1.OuterRadius + ring2.OuterRadius)
                return true;
            else
                return false;
        }
    }
}
