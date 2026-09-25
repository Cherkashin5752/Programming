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
        private BindingList<Model.Item> _items;
        
        /// <summary>
        /// Список покупателей
        /// </summary>
        private BindingList<Model.Customer> _customers;

        /// <summary>
        /// Возвращает и задаёт список товаров
        /// </summary>
        public BindingList<Model.Item> Items { get { return _items; } set { _items = value; } }
        
        /// <summary>
        /// Возвращает и задаёт список покупателей
        /// </summary>
        public BindingList<Model.Customer> Customers { get { return _customers; } set { _customers = value; } }

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
