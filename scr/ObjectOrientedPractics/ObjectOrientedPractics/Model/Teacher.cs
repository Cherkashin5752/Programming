using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит имя и опыт преподавателя
    /// </summary>
    internal class Teacher
    {
        /// <summary>
        /// имя преподавателя
        /// </summary>
        private string _name;

        /// <summary>
        /// Опыт преподавателя
        /// </summary>
        private int _experience;

        /// <summary>
        /// Возвращает и задаёт имя преподавателя
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }
        
        /// <summary>
        /// Возвращает и задаёт опыт преподавателя
        /// </summary>
        public int Experience { get;
            set
            {
                if (ValueValidator.ValueIsPositive(value, "Experience"))
                {
                    _experience = value;
                }
                else
                {
                    throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
                }
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Teacher"> с дефолтными значениями
        /// </summary>
        public Teacher()
        {
            this.Name = "Default name";
            this.Experience = 0;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Teacher">
        /// </summary>
        /// <param name="name">Имя преподавателя</param>
        /// <param name="experience">Опыт преподавателя</param>
        public Teacher(string name, int experience)
        {
            this.Name = name;
            this.Experience = experience;
        }
    }
}
