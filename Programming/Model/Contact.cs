using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Programming.Model
{
    /// <summary>
    /// Хранит номер телефона, имя и фамилию контакта
    /// </summary>
    internal class Contact
    {
        private string _name;
        private string _sureName;

        private string _number;
        /// <summary>
        /// Возвращает и задаёт номер телефона
        /// </summary>
        public string Number
        {
            get; set;
        }

        /// <summary>
        /// Возвращает и задаёт имя контакт. Состоит только из латинских букв
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (Validator.AssertStringContainsOnlyLetters(value))
                    _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию контакт. Состоит только из латинских букв
        /// </summary>
        public string SureName
        {
            get { return _sureName; }
            set
            {
                if (Validator.AssertStringContainsOnlyLetters(value))
                    _sureName = value;
            }
        }

        public Contact(string number, string name, string sureName)
        {
            Number = number;
            Name = name;
            SureName = sureName;
        }

        public Contact()
        {
            
        }
    }
}
