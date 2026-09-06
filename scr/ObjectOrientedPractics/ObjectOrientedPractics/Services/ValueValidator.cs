using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPractics.Services
{
    internal class ValueValidator
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
            if (value.Length <= maxLength)
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов");
            }
        }
    }
}
