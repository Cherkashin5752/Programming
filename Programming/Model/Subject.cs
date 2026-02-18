using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Subject
    {
        private string _name;
        private string _teacherName;
        private int _hoursPerSemester;
    
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string TeacherName
        {
            get { return _teacherName; }
            set { _teacherName = value; }
        }

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
