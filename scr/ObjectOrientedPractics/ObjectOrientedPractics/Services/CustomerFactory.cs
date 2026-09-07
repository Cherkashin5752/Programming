using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPractics.Services
{
    internal class CustomerFactory
    {
        static private int maxCustomersCount;

        static private List<string> _fullnames = new List<string>();

        static private List<string> _addresses = new List<string>();

        static public Model.Customer GenerateCustomer()
        {
            Random random = new Random();

            int randomCustomer = random.Next(0, maxCustomersCount);

            string newName = _fullnames[randomCustomer];

            string newInfo = _addresses[randomCustomer];

            Model.Customer newCustomer = new Model.Customer(newName, newInfo);

            return newCustomer;
        }

        static public void SetUpCustomerFactory()
        {
            StreamReader reader = new StreamReader(PathService.GetProjectRootDir() + "\\Customers Fullnames.txt");

            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                _fullnames.Add(line);
            }

            reader.Close();

            reader = new StreamReader(PathService.GetProjectRootDir() + "\\Customers Addresses.txt");

            while ((line = reader.ReadLine()) != null)
            {
                _addresses.Add(line);
            }

            reader.Close();

            maxCustomersCount = int.Min(_fullnames.Count, _addresses.Count);
        }
    }
}
