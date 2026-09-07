using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ObjectOrientedPractics.Services
{
    internal class ProjectSerializer
    {
        static public BindingList<Model.Item> DeserializeJsonItemsFile(string path)
        {
            string itemsJsonText = File.ReadAllText(path);

            BindingList<Model.Item> items = JsonConvert.DeserializeObject<BindingList<Model.Item>>(itemsJsonText);

            return items;
        }

        static public BindingList<Model.Customer> DeserializeJsonCustomerFile(string path)
        {
            string customerJsonText = File.ReadAllText(path);

            BindingList<Model.Customer> customers = JsonConvert.DeserializeObject<BindingList<Model.Customer>>(customerJsonText);

            return customers;
        }

        static public void SerializeJsonItemsFile(BindingList<Model.Item> items, string path)
        {
            string jsonItems = JsonConvert.SerializeObject(items);

            File.WriteAllText(path, jsonItems);
        }

        static public void SerializeJsonCustomersFile(BindingList<Model.Customer> customers, string path)
        {
            string jsonCustomers = JsonConvert.SerializeObject(customers);

            File.WriteAllText(path, jsonCustomers);
        }
    }
}
