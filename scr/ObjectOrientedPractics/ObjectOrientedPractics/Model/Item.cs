using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит Id, именование, информацию и стоимость товара
    /// </summary>
    internal class Item
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
        /// Именование товара
        /// </summary>>
        private string _name;

        /// <summary>
        /// Информация о товаре
        /// </summary>
        private string _info;
        
        /// <summary>
        /// Стоимость товара
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает Id товара
        /// </summary>
        public int ID {  get { return _id; } init { _id = value; } }
        
        /// <summary>
        /// Возвращает и задаёт именование товара
        /// </summary>
        public string Name { get { return _name; }
            set {
                if (ValueValidator.AssertStringOnLength(value, 200, "Name")) {
                    _name = value;
                }
                else {
                    throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт информацию о товаре
        /// </summary>
        public string Info { get { return _info; }
            set {
                if (ValueValidator.AssertStringOnLength(value, 1000, "Info")) {
                    _info = value;
                }
                else {
                    throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость товара
        /// </summary>
        public double Cost { get { return _cost; }
            set {
                if (value >= 0 && value <= 100000) {
                    _cost = value;
                }
                else {
                    throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
                }
            }
        }
    
        public Item(string name, string info, double cost) {
            this.ID = _idCounter++;
            this.Name = name;
            this.Info = info;
            this.Cost = cost;
        }
    }
}
