using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Discipline
    {
        private string name { get; set; }
        private string teacherName { get; set; }
        
        private int hoursPerSemester;
    
        private int HoursPerSemester
        {
            get { return hoursPerSemester; }
            set
            {
                if (hoursPerSemester < 0)
                    throw new ArgumentException();
            }
        }
    }
}
