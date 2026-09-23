using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров, привязанный к графическому интерфейсу.
        /// </summary>
        private BindingList<Model.Item> _items = new();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ItemsTab"/>.
        /// Загружает сохранённые товары из файла JSON и настраивает фабрику генерации товаров.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = "Name";

            CategoryComboBox.Items.AddRange(Enum.GetNames<ProductCategory>());

            string exeFilePath = PathService.GetProjectRootDir();

            try
            {
                ItemFactory.SetUpItemFactory(exeFilePath);

                string jsonPath = PathService.GetProjectRootDir() + "\\Items Objects.json";

                BindingList<Model.Item> tempItems = ProjectSerializer.DeserializeJsonItemsFile(jsonPath);

                if (tempItems == null)
                {
                    return;
                }

                foreach (Model.Item item in tempItems)
                {
                    _items.Add(item);
                }
            }
            catch { }

        }

        /// <summary>
        /// Обработчик события нажатия на кнопку добавления товара по умолчанию.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void AddDefaultItemButton_Click(object sender, EventArgs e)
        {
            Model.Item newItem = new Model.Item("Default name", "Default description", 0, ProductCategory.Default);
            _items.Add(newItem);
        }

        /// <summary>
        /// Оработчик события нажатия на кнопку добавления случайного товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void AddRandomItemButton_Click(object sender, EventArgs e)
        {
            Model.Item newItem = ItemFactory.GenerateItem();
            _items.Add(newItem);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку удаления выбранного товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
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

        /// <summary>
        /// Обработчик события изменения стоимости в поле товара.
        /// Валидирует поле и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _items[ItemsListBox.SelectedIndex].Cost = double.Parse(CostTextBox.Text);
                    CostTextBox.BackColor = Color.White;
                }
                catch { CostTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле названия товара.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
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

        /// <summary>
        /// Обработчик события потери фокуса поля названия товара.
        /// Обновляет отображаемое название товара в <see cref="ItemsListBox"/>
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Обработчик события изменения текста в поле описания товара.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
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

        /// <summary>
        /// Обработчик события изменения выбранного элемента в выпадающем списке категории товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                _items[ItemsListBox.SelectedIndex].Category = (ProductCategory)CategoryComboBox.SelectedIndex;
            }
        }

        /// <summary>
        /// Обработчик события изменения выбраного элемента в списке товаров.
        /// Заполняет текстовые поля информацией о выбранном товаре.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                IDTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).ID.ToString();
                NameTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).Name;
                DescriptionTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).Info;
                CostTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).Cost.ToString();
                CategoryComboBox.SelectedIndex = (int)((Model.Item)ItemsListBox.SelectedItem).Category;
            }
            else
            {
                ClearItemsInfo();
            }
        }

        /// <summary>
        /// Очищает текстовые поля формы от данных товара.
        /// </summary>
        private void ClearItemsInfo()
        {
            IDTextBox.Text = "";
            CostTextBox.Text = "";
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            CategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Выполняет сериализацию текущего списка покупателей в файл формата JSON.
        /// Вызывается в главной форме.
        /// </summary>
        public void SerializeItems()
        {
            ProjectSerializer.SerializeJsonItemsFile(_items, PathService.GetProjectRootDir() + "\\Items Objects.json");
        }
    }
}