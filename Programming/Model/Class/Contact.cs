using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    internal class Contact
    {
        private string Number { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }

        public Contact(string _number, string _firstName, string _lastName)
        {
            Number = _number;
            FirstName = _firstName;
            LastName = _lastName;
        }

        public Contact()
        {

        }
    }
}
