using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    internal class Subject
    {
        private string _title;
        private int _fullHours;
        private Teacher _teacher;

        public string Title { get { return _title; } set { _title = value; } }
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
        public Teacher Teacher { get { return _teacher; } set { _teacher = value; } }
        
        public Subject(string title, int fullHours, string name, int experience)
        {
            Title = title;
            FullHours = fullHours;
            _teacher = new Teacher(name, experience);
        }
    }
}
