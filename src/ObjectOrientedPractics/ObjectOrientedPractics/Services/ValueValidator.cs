using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPractics.Services
{
    static internal class ValueValidator
    {
        /// <summary>
        /// Проверяет на то, не больше ли строка некторого количества символов
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <param name="maxLength">Вверхняя границы</param>
        /// <param name="propertyName">Вызываемое свойство</param>
        /// <returns>Возвращает true, если строка короче maxLength</returns>
        /// <exception cref="ArgumentException">Ошибка, если строка длинее maxLength</exception>
        static public bool AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length != 0 && value.Length <= maxLength)
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"{propertyName} должен быть не больше {maxLength} символов");
            }
        }

        /// <summary>
        /// Проверяет, что целочисленное число является положительным
        /// </summary>
        /// <param name="value">Проверяемое число</param>
        /// <param name="propetryName">Вызываемое свойство</param>
        /// <returns>Возвращает true, если число положительное</returns>
        /// <exception cref="ArgumentException">Ошибка, если число не положительное</exception>
        static public bool ValueIsPositive(int value, string propetryName)
        {
            if (value > 0)
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"{propetryName} должен быть положительным");
            }
        }
        
        /// <summary>
        /// Проверяет, что целочисленное число назодится в диапазоне от min до max
        /// </summary>
        /// <param name="value">Проверяемое число</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <param name="propetryName">Вызываемое свойство</param>
        /// <returns>Возвращает true, если число находится в диапазоне</returns>
        /// <exception cref="ArgumentException">Ошибка, если число не назодится в диапазоне</exception>
        static public bool ValueInRange(int value, int min, int max, string propetryName)
        {
            if (value > min && value < max)
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"{propetryName} должен быть не меньше {min} и не больше {max}");
            }
        }
    }
}
