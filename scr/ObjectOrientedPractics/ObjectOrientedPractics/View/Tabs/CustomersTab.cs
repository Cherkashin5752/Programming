using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Пользовательский элемент, который осуществляет логику работы с покупателями
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей, привязанный к графическому интерфейсу.
        /// </summary>
        private BindingList<Model.Customer> _customers = new();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CustomersTab"/>.
        /// Загружает сохранённых покупателей из файла JSON и настраивает фабрику генерации покупателей.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();

            CustomersListBox.DataSource = _customers;
            CustomersListBox.DisplayMember = "Fullname";

            string exeFilePath = PathService.GetProjectRootDir();

            try
            {
                CustomerFactory.SetUpCustomerFactory(exeFilePath);

                string jsonPath = exeFilePath + "\\Customers Objects.json";

                BindingList<Model.Customer> tempCustomers = ProjectSerializer.DeserializeJsonCustomerFile(jsonPath);

                if (tempCustomers == null)
                {
                    return;
                }

                foreach (Model.Customer customer in tempCustomers)
                {
                    _customers.Add(customer);
                }
            }
            catch { }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку добавления покупателя по умолчанию.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddDefaultCustomerButton_Click(object sender, EventArgs e)
        {
            Model.Customer newCustomer = new Model.Customer();
            _customers.Add(newCustomer);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку добавления случайного покупателя.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddRandomCustomerButton_Click(object sender, EventArgs e)
        {
            Model.Customer newCustomer = CustomerFactory.GenerateCustomer();
            _customers.Add(newCustomer);
        }
        
        /// <summary>
        /// Обработчик события нажатия на кнопку удаления выбранного покупателя.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;

                _customers.RemoveAt(selectedIndex);

                CustomersListBox.SelectedIndex = -1;

                ClearCustomersInfo();
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле полного имени покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    _customers[CustomersListBox.SelectedIndex].Fullname = FullnameTextBox.Text;
                    FullnameTextBox.BackColor = Color.White;
                }
                catch { FullnameTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события потери фокуса поля полного имени покупателя.
        /// Обновления отображаемого имени покупателя в <see cref="CustomersListBox"/>
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void FullnameTextBox_Leave(object sender, EventArgs e)
        {
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
            CustomersListBox.DisplayMember = "Fullname";
        }

        /// <summary>
        /// ОБработчик события изменения поля адреса покупателя
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void addressControl1_OnAddressChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _customers[CustomersListBox.SelectedIndex].Address = addressControl1.CurrentAddress;
            }
        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке покупателей.
        /// Заполняет текстовые поля информацией о выбранном покупателе.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                IDTextBox.Text = ((Model.Customer)CustomersListBox.SelectedItem).ID.ToString();
                FullnameTextBox.Text = ((Model.Customer)CustomersListBox.SelectedItem).Fullname;
                addressControl1.CurrentAddress = ((Model.Customer)CustomersListBox.SelectedItem).Address;
            }
            else
            {
                ClearCustomersInfo();
            }
        }

        /// <summary>
        /// Очищает текстовые поля формы о данных покупателя.
        /// </summary>
        private void ClearCustomersInfo()
        {
            IDTextBox.Text = "";
            FullnameTextBox.Text = "";
            addressControl1.CurrentAddress = null;
        }

        /// <summary>
        /// Выполняет сериализацию текущего списка покупателей в файл формата JSON.
        /// Вызывается в главной форме.
        /// </summary>
        public void SerializeCustomers()
        {
            ProjectSerializer.SerializeJsonCustomersFile(_customers, PathService.GetProjectRootDir() + "\\Customers Objects.json");
        }
    }
}
