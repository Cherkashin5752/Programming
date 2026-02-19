using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о музыке
    /// </summary>
    internal class Song
    {
        private string _name;
        private string _author;
        private int _duration;

        /// <summary>
        /// Возвращает и задаёт название музыки
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Возвращает и задаёт автора музыки
        /// </summary>
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        /// <summary>
        /// Возвращает и задаёт продолжительность музыки. Только положительное число
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set 
            {
                if (Validator.AssertOnPositiveValue(value))
                    _duration = value;
            }
        }

        
        public Song(string name, string author, int duration)
        {
            Name = name;
            Author = author;
            Duration = duration;
        }

        public Song()
        {

        }
    }
}
