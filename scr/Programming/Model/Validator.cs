using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    static class Validator
    {
        /// <summary>
        /// Проверяет на то, положительное ли целочисленное число
        /// </summary>
        /// <param name="value">проверяемое целочисленное число</param>
        /// <returns>Возвращает true, если число положительное</returns>
        /// <exception cref="ArgumentException">Ошибка, если число не положительное</exception>
        public static bool AssertOnPositiveValue(int value)
        {
            if (value > 0)
                return true;
            else
                throw new ArgumentException($"Отрицательное значени {value}", nameof(value));
        }

        /// <summary>
        /// Проверяет на то, положительное ли вещественное число
        /// </summary>
        /// <param name="value">Проверяемое вещественное число</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Ошибка, если число не положительное</exception>
        public static bool AssertOnPositiveValue(double value)
        {
            if (value > 0)
                return true;
            else
                throw new ArgumentException($"Отрицательное значение {value}", nameof(value));
        }

        /// <summary>
        /// Проверяет, находится ли целочисленное число в диапазоне
        /// </summary>
        /// <param name="value">Проверяем число</param>
        /// <param name="min">Начало диапазона</param>
        /// <param name="max">Конец диапазона</param>
        /// <returns>Возвращает true, если число находится в диапазоне</returns>
        /// <exception cref="ArgumentException">Ошибка, если число не находится в диапазоне</exception>
        public static bool AssertValueInRange(int value, int min, int max)
        {
            if (value > min && value < max)
                return true;
            else
                throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
        }

        /// <summary>
        /// Проверяет, находится ли вещественное число в диапазоне
        /// </summary>
        /// <param name="value">Проверяем число</param>
        /// <param name="min">Начало диапазона</param>
        /// <param name="max">Конец диапазона</param>
        /// <returns>Возвращает true, если число находится в диапазоне</returns>
        /// <exception cref="ArgumentException">Ошибка, если число не находится в диапазоне</exception>
        public static bool AssertValueInRange(double value, double min, double max)
        {
            if (value > min && value < max)
                return true;
            else
                throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
        }

        /// <summary>
        /// Проверяет, что строка состоит только из латинских символов
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <returns>Возвращает true, если нет не латинских символов</returns>
        /// <exception cref="ArgumentException">Ошибка, если строка содержит не только латинские буквы</exception>
        public static bool AssertStringContainsOnlyLetters(string value)
        {
            if (Regex.IsMatch(value, "^[a-zA-Z]*$"))
                return true;
            else
                throw new ArgumentException(nameof(value), " содержит не только латинские буквы");
        }
    }
}
