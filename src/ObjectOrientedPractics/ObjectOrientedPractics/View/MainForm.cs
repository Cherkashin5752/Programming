using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;
using System.ComponentModel;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Model.Store _store = new Model.Store();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            try
            {
                string jsonPath = "\\Object Store.json";

                Store tempStore = ProjectSerializer.DeserializeJsonStoreFile(jsonPath);

                if (tempStore == null)
                {
                    throw new Exception();
                }

                _store = tempStore;
            }
            catch { }


            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
        }

        /// <summary>
        /// Обработчик закрытия формы.
        /// Сериализует данные о товарах и покупателях.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectSerializer.SerializeJsonStoreFile(_store, "\\Object Store.json");
        }
    }
}