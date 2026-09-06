using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит Id, полное имя и адрес покупателя
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Счётчик для генерации уникальных Id
        /// </summary>
        static private int _idCounter;

        /// <summary>
        /// Id товара
        /// </summary>
        readonly int _id;
        
        /// <summary>
        /// Полное имя покупателя
        /// </summary>
        private string _fullname;
        
        /// <summary>
        /// Адрес покупателя
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает Id товара
        /// </summary>
        public int ID { get { return _id; } init { _id = value; } }

        /// <summary>
        /// Возвращает и задаёт полное имя покупателя
        /// </summary>
        public string Fullname { get { return _fullname; }
            set {
                if (ValueValidator.AssertStringOnLength(value, 200, "Fullname")) {
                    _fullname = value;
                }
                else {
                    throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 500, "Address"))
                {
                    _address = value;
                }
                else
                {
                    throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
                }
            }
        }

        public Customer(string fullname, string address)
        {
            this.ID = _idCounter++;
            this.Fullname = fullname;
            this.Address = address;
        }
    }
}
