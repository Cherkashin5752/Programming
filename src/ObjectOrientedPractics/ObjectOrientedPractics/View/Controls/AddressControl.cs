using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// ПОльзовательский элемент, который осуществляет логику работы с адресами покупателей
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Сдрес текуще-выбранного покупателя
        /// </summary>
        private Model.Address _currentAddress;

        /// <summary>
        /// Событие. Возникает при изменении любого поля класса
        /// </summary>
        public event EventHandler AddressChanged;

        /// <summary>
        /// Возвращает и задаёт значение текуще-выбранного покупателя
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Model.Address CurrentAddress
        {
            get
            {
                return _currentAddress;
            }
            set
            {
                if (value == null)
                {
                    ClearTextBoxAddress();
                    return;
                }

                _currentAddress = value;

                RefreshAddressInfo();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AddressControl"/>.
        /// <summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Очищает текстовые поля формы о адресе покупателя
        /// </summary>
        private void ClearTextBoxAddress()
        {
            PostIndexTextBox.Text = "";
            CountryTextBox.Text = "";
            CityTextBox.Text = "";
            StreetTextBox.Text = "";
            BuildingTextBox.Text = "";
            ApartmentTextBox.Text = "";
        }

        /// <summary>
        /// Вызывает событие <see cref="AddressChanged">
        /// </summary>
        public void OnAddressChanged()
        {
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Меняет значения текстовых полей Address в форме на значения текуще-выбранного покупателя
        /// </summary>
        private void RefreshAddressInfo()
        {
            PostIndexTextBox.Text = CurrentAddress.Index.ToString();
            CountryTextBox.Text = CurrentAddress.Country;
            CityTextBox.Text = CurrentAddress.City;
            StreetTextBox.Text = CurrentAddress.Street;
            BuildingTextBox.Text = CurrentAddress.Building;
            ApartmentTextBox.Text = CurrentAddress.Apartment;
        }

        /// <summary>
        /// Обработчик события изменения текста в поле индекса адреса покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentAddress != null)
            {
                try
                {
                    CurrentAddress.Index = int.Parse(PostIndexTextBox.Text);
                    OnAddressChanged();
                    PostIndexTextBox.BackColor = Color.White;
                }
                catch { PostIndexTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле страны/региона адреса покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentAddress != null)
            {
                try
                {
                    CurrentAddress.Country = CountryTextBox.Text;
                    OnAddressChanged();
                    CountryTextBox.BackColor = Color.White;
                }
                catch { CountryTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле города адреса покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentAddress != null)
            {
                try
                {
                    CurrentAddress.City = CityTextBox.Text;
                    OnAddressChanged();
                    CityTextBox.BackColor = Color.White;
                }
                catch { CityTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле улицы адреса покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentAddress != null)
            {
                try
                {
                    CurrentAddress.Street = StreetTextBox.Text;
                    OnAddressChanged();
                    StreetTextBox.BackColor = Color.White;
                }
                catch { StreetTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле номера дома адреса покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentAddress != null)
            {
                try
                {
                    CurrentAddress.Building = BuildingTextBox.Text;
                    OnAddressChanged();
                    BuildingTextBox.BackColor = Color.White;
                }
                catch { BuildingTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле номера квартиры/помещения адреса покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentAddress != null)
            {
                try
                {
                    CurrentAddress.Apartment = ApartmentTextBox.Text;
                    OnAddressChanged();
                    ApartmentTextBox.BackColor = Color.White;
                }
                catch { ApartmentTextBox.BackColor = Color.LightPink; }
            }
        }
    }
}
