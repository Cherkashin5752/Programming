using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о учебном предмете
    /// </summary>
    internal class Subject
    {
        private string _name;
        private string _teacherName;
        private int _hoursPerSemester;
    
        /// <summary>
        /// Возвращает и задаёт название предмета
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя преподавателя предмета
        /// </summary>
        public string TeacherName { get; set; }

        /// <summary>
        /// Возвращает и задаёт количество часов в семестре этого предмета. Только положительно число
        /// </summary>
        public int HoursPerSemester
        {
            get { return _hoursPerSemester; }
            set
            {
                if (Validator.AssertOnPositiveValue(value))
                    _hoursPerSemester = value;
            }
        }

        public Subject(string name, string teacherName, int hoursPerSemester)
        {
            Name = name;
            TeacherName = teacherName;
            HoursPerSemester = hoursPerSemester;
        }

        public Subject()
        {

        }
    }
}
