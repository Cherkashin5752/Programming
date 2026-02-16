using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Programming.Model.Class
{
    internal class Contact
    {
        private string _number;
        private string _name;
        private string _sureName;

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (AssertStringContainsOnlyLetters(value))
                    _name = value;
            }
        }

        public string SureName
        {
            get { return _sureName; }
            set
            {
                if (AssertStringContainsOnlyLetters(value))
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

        private bool AssertStringContainsOnlyLetters(string value)
        {
            if (Regex.IsMatch(value, "^[a-zA-Z]*$"))
                return true;
            else
                throw new ArgumentException(nameof(value), " содержит не только латинские буквы");
        }
    }
}
