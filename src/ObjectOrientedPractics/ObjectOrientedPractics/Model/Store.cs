using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит списки товаров и покупателей
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private BindingList<Item> _items;
        
        /// <summary>
        /// Список покупателей
        /// </summary>
        private BindingList<Customer> _customers;

        /// <summary>
        /// Возвращает и задаёт список товаров
        /// </summary>
        public BindingList<Item> Items { get { return _items; } set { _items = value; } }
        
        /// <summary>
        /// Возвращает и задаёт список покупателей
        /// </summary>
        public BindingList<Customer> Customers { get { return _customers; } set { _customers = value; } }

        /// <summary>
        /// Инициализирует новый экземплар класса <see cref="Store">
        /// </summary>
        public Store()
        {
            Items = new();
            Customers = new();
        }
    }
}
