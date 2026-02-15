using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Contact
    {
        private string _number;
        private string _firstName;
        private string _lastName;

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Contact(string number, string firstName, string lastName)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
        }

        public Contact()
        {

        }
    }
}
