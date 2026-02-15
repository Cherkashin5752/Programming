using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Discipline
    {
        private string Name { get; set; }
        private string TeacherName { get; set; }
        private int hoursPerSemester;
    
        public int HoursPerSemester
        {
            get { return hoursPerSemester; }
            set
            {
                if (hoursPerSemester < 0)
                    throw new ArgumentException();
                hoursPerSemester = value;
            }
        }

        public Discipline(string _name, string _teacherName, int _hoursPerSemester)
        {
            Name = _name;
            TeacherName = _teacherName;
            HoursPerSemester = _hoursPerSemester;
        }

        public Discipline()
        {

        }
    }
}
