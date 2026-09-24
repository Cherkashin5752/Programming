using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик закрытия формы.
        /// Сериализует данные о товарах и покупателях.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            itemsTab1.SerializeItems();
            customersTab1.SerializeCustomers();
        }
    }
}