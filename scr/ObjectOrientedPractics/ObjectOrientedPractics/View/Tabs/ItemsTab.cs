using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private BindingList<Model.Item> _items = new();

        public ItemsTab()
        {
            InitializeComponent();
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = "Name";
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Model.Item newItem = new Model.Item("Default name", "Default description", 0);
            _items.Add(newItem);
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                int selectedIndex = ItemsListBox.SelectedIndex;

                _items.RemoveAt(selectedIndex);

                ItemsListBox.SelectedIndex = -1;

                ClearItemsInfo();
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _items[ItemsListBox.SelectedIndex].Cost = int.Parse(CostTextBox.Text);
                    CostTextBox.BackColor = Color.White;
                }
                catch { CostTextBox.BackColor = Color.LightPink; }
            }
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                    NameTextBox.BackColor = Color.White;
                }
                catch { NameTextBox.BackColor = Color.LightPink; }
            }
        }
        
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = "Name";
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _items[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
                    DescriptionTextBox.BackColor = Color.White;
                }
                catch { DescriptionTextBox.BackColor = Color.LightPink; }
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                IDTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).ID.ToString();
                NameTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).Name;
                DescriptionTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).Info;
                CostTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).Cost.ToString();
            }
            else
            {
                ClearItemsInfo();
            }
        }

        private void ClearItemsInfo()
        {
            IDTextBox.Text = "";
            CostTextBox.Text = "";
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
        }

        private void RefreshItemsListBox()
        {
            ItemsListBox.DataSource = _items;
        }
    }
}