using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class EnumsControl : UserControl
    {
        public EnumsControl()
        {
            InitializeComponent();
        }

        private void EnumsControl_Load(object sender, EventArgs e)
        {
            // Находим все перечисления
            var enums = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsEnum && t.Namespace == "Programming.Model.Enums");

            // Заполняем список доступных перечислений
            foreach (var en in enums)
                EnumsListBox.Items.Add(en);

            //Показываем только названия перечислений
            EnumsListBox.DisplayMember = "Name";

            // Выбираем первый элемент по умолчанию
            EnumsListBox.SetSelected(0, true); 
            ChangeValueListBox();
        }

        /// <summary>
        /// Заполняет ValuesListBox элементами выбранного в EnumsListBox перечисления
        /// </summary>
        private void ChangeValueListBox()
        {
            ValuesListBox.Items.Clear();
            Type selectedEnum = (Type)EnumsListBox.SelectedItem!;
            foreach (var value in Enum.GetValues(selectedEnum))
            {
                ValuesListBox.Items.Add(value);
            }
        }

        /// <summary>
        /// Заполняет IntValueTextBox числовым эквивалентом элемента, выбранного в ValuesListBox
        /// </summary>
        private void ChangeIntValueTextBox()
        {
            var selectedValue = ValuesListBox.SelectedItem;
            if (selectedValue != null)
                IntValueTextBox.Text = $"{(int)selectedValue}";
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e) => ChangeValueListBox();
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e) => ChangeIntValueTextBox();
    }
}