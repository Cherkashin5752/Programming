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
        /// <summary>
        /// Выполняет десериализацию списка товаров из файла формата JSON.
        /// </summary>
        /// <param name="path">Путь к файлу, содержащему данные о товарах.</param>
        /// <returns>Список товаров  в виде объекта <see cref="BindingList{T}"/>, содержащего экземпляры <see cref="Model.Item"/></returns>
        static public BindingList<Model.Item> DeserializeJsonItemsFile(string path)
        {
            string itemsJsonText = File.ReadAllText(path);

            BindingList<Model.Item> items = JsonConvert.DeserializeObject<BindingList<Model.Item>>(itemsJsonText);

            return items;
        }

        /// <summary>
        /// Выполняет десериализацию списка покупателей из файла формат JSON.
        /// </summary>
        /// <param name="path">Путь к файлу, содержащему данные о покупателях.</param>
        /// <returns>Список товаров  в виде объекта <see cref="BindingList{T}"/>, содержащего экземпляры <see cref="Model.Customer"/></returns>
        static public BindingList<Model.Customer> DeserializeJsonCustomerFile(string path)
        {
            string customerJsonText = File.ReadAllText(path);

            BindingList<Model.Customer> customers = JsonConvert.DeserializeObject<BindingList<Model.Customer>>(customerJsonText);

            return customers;
        }

        /// <summary>
        /// Сериализует список товаров в формат JSON и сохраняет его в указанный файл.
        /// </summary>
        /// <param name="items">Список товаров <see cref="BindingList{T}"/> для сохранения.</param>
        /// <param name="path">Путь к файлу, в который будут записаны данные.</param>
        static public void SerializeJsonItemsFile(BindingList<Model.Item> items, string path)
        {
            string jsonItems = JsonConvert.SerializeObject(items);

            File.WriteAllText(path, jsonItems);
        }

        /// <summary>
        /// Сериализует список покупателей в формат JSON и сохраняет его в указанный файл.
        /// </summary>
        /// <param name="customers">Список покупателей <see cref="BindingList{T}"/> для сохранения.</param>
        /// <param name="path">Путь к файлу, в который будут записаны данные.</param>
        static public void SerializeJsonCustomersFile(BindingList<Model.Customer> customers, string path)
        {
            string jsonCustomers = JsonConvert.SerializeObject(customers);

            File.WriteAllText(path, jsonCustomers);
        }
    }
}
