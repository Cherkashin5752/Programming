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
    public partial class CustomersTab : UserControl
    {
        private BindingList<Model.Customer> _customers = new();

        public CustomersTab()
        {
            InitializeComponent();

            CustomersListBox.DataSource = _customers;
            CustomersListBox.DisplayMember = "Fullname";

            string exeFilePath = PathService.GetProjectRootDir();

            try
            {
                CustomerFactory.SetUpCustomerFactory();

                string jsonPath = PathService.GetProjectRootDir() + "\\Customers Objects.json";

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

        private void AddCutomerButton_Click(object sender, EventArgs e)
        {
            Model.Customer newCustomer = new Model.Customer("Default name", "Default address");
            _customers.Add(newCustomer);
        }

        private void AddRandomCustomerButton_Click(object sender, EventArgs e)
        {
            Model.Customer newCustomer = CustomerFactory.GenerateCustomer();
            _customers.Add(newCustomer);
        }
        
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;

                _customers.RemoveAt(selectedIndex);

                CustomersListBox.SelectedIndex = -1;

                ClearItemsInfo();
            }
        }

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

        private void FullnameTextBox_Leave(object sender, EventArgs e)
        {
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
            CustomersListBox.DisplayMember = "Fullname";
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    _customers[CustomersListBox.SelectedIndex].Address = AddressTextBox.Text;
                    AddressTextBox.BackColor = Color.White;
                }
                catch { AddressTextBox.BackColor = Color.LightPink; }
            }
        }

        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                IDTextBox.Text = ((Model.Customer)CustomersListBox.SelectedItem).ID.ToString();
                FullnameTextBox.Text = ((Model.Customer)CustomersListBox.SelectedItem).Fullname;
                AddressTextBox.Text = ((Model.Customer)CustomersListBox.SelectedItem).Address;
            }
            else
            {
                ClearItemsInfo();
            }
        }

        private void ClearItemsInfo()
        {
            IDTextBox.Text = "";
            FullnameTextBox.Text = "";
            AddressTextBox.Text = "";
        }

        public void SerializeCustomers()
        {
            ProjectSerializer.SerializeJsonCustomersFile(_customers, PathService.GetProjectRootDir() + "\\Customers Objects.json");
        }
    }
}
