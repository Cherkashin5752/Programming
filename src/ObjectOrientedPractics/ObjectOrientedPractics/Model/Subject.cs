using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит название, полное количество часов и преподавателя дисциплины
    /// </summary>
    internal class Subject
    {
        /// <summary>
        /// Название дисциплины
        /// </summary>
        private string _title;

        /// <summary>
        /// Полное количество часов дисциплины 
        /// </summary>
        private int _fullHours;

        /// <summary>
        /// Учитель дисциплины
        /// </summary>
        private Teacher _teacher;
        
        /// <summary>
        /// Возвращает и задаёт название дисциплины
        /// </summary>
        public string Title { get { return _title; } set { _title = value; } }
        
        /// <summary>
        /// Возвращает и задаёт полное количество часов дисциплины
        /// </summary>
        public int FullHours { get { return _fullHours; }
            set
            {
                if (ValueValidator.ValueIsPositive(value, "FullHours"))
                {
                    _fullHours = value;
                }
                else
                {
                    throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт преподавателя дисциплины
        /// </summary>
        public Teacher Teacher { get { return _teacher; } set { _teacher = value; } }
        
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Subject"> с дефолтными значениями
        /// </summary>
        public Subject()
        {
            this.Title = "Default title";
            this.FullHours = 0;
            this.Teacher = new Teacher();
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Subject">
        /// </summary>
        /// <param name="title">Название дисциплины</param>
        /// <param name="fullHours">Полное количество часов дисциплины</param>
        /// <param name="name">Имя преподавателя дисциплины</param>
        /// <param name="experience">Опыт преподавателя дисциплины</param>
        public Subject(string title, int fullHours, string name, int experience)
        {
            this.Title = title;
            this.FullHours = fullHours;
            this.Teacher = new Teacher(name, experience);
        }
    }
}
