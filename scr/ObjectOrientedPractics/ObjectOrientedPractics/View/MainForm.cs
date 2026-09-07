using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_ormClosing(object sender, FormClosingEventArgs e)
        {
            itemsTab1.SerializeItems();
            customersTab1.SerializeCustomers();
        }
    }
}
