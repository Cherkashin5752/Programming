using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Model
{
    static internal class Validator
    {
        public static bool AssertValueInRange(int value, int min, int max)
        {
            if (value > min && value < max)
                return true;
            else
                throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
        }
    }
}
