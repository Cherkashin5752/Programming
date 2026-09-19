using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ObjectOrientedPractics.Model
{
    internal class Teacher
    {
        private string _name;
        private int _experience;

        public string Name { get { return _name; } set { _name = value; } }
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

        public Teacher(string name, int experience)
        {
            Name = name;
            Experience = experience;
        }
    }
}
