using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using System.Text.RegularExpressions;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит адрес покупателя
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Индекс покупателя
        /// </summary>
        private int _index;
 
        /// <summary>
        /// Страна/регион покупателя
        /// </summary>
        private string _country;

        /// <summary>
        /// Город покупателя
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица покупателя
        /// </summary>
        private string _street;

        /// <summary>
        /// номер дома покупателя
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения покупателя
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задаёт индекс покупателя 
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                if (ValueValidator.ValueInRange(value, 99_999, 1_000_000, "Index"))
                {
                    _index = value;
                }
            }
        }
        
        /// <summary>
        /// Возвращает и задаёт страну/регион покупателя
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 50, "Country"))
                {
                    _country = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт город покупателя
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 50, "City"))
                {
                    _city = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задаёт улицу покупателя
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 100, "Street"))
                {
                    _street = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома покупателя
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 10, "Building"))
                {
                    _building = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры/помещения покупателя
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 10, "Apartment"))
                {
                    _apartment = value;
                }
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"> с дефолтными значениями
        /// </summary>
        public Address()
        {
            this.Index = 100_000;
            this.Country = "Default country";
            this.City = "Default";
            this.Street = "Default street";
            this.Building = "Default";
            this.Apartment = "Default";
        }

        /// <summary>
        /// Инициализирует новый экзепляр класса <see cref="Address">
        /// </summary>
        /// <param name="index">Индекс покупателя</param>
        /// <param name="country">Страна/регион покупателя</param>
        /// <param name="city">Город покупателя</param>
        /// <param name="street">Улица покупателя</param>
        /// <param name="building">Номер дома покупателя</param>
        /// <param name="apartment">Номер квартиры/помещения покупателя</param>
        public Address(int index, string country, string city,
            string street, string building, string apartment)
        {
            this.Index = index;
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.Building = building;
            this.Apartment = apartment;
        }
    }
}
