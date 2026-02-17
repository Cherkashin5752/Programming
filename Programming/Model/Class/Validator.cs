using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    static class Validator
    {
        // Проверяет целочисленное число на положительность
        public static bool AssertOnPositiveValue(int value)
        {
            if (value > 0)
                return true;
            else
                throw new ArgumentException($"Отрицательное значени {value}", nameof(value));
        }

        // Проверяет вещественное число на положительность
        public static bool AssertOnPositiveValue(double value)
        {
            if (value > 0)
                return true;
            else
                throw new ArgumentException($"Отрицательное значение {value}", nameof(value));
        }

        // Проверяет, что целочисленное число находится в диапазоне
        public static bool AssertValueInRange(int value, int min, int max)
        {
            if (value > min && value < max)
                return true;
            else
                throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
        }

        // Проверяет, что вещественное число находится в диапазоне
        public static bool AssertValueInRange(double value, double min, double max)
        {
            if (value > min && value < max)
                return true;
            else
                throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
        }
    }
}
