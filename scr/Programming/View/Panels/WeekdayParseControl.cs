using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class WeekdayParseControl : UserControl
    {
        public WeekdayParseControl()
        {
            InitializeComponent();
        }

        private void WeekdayParseControl_Load(object sender, EventArgs e)
        {
            IsitWeekday.Text = "";
        }

        /// <summary>
        /// Логика парсинга введенной строки в перечисление Weekday
        /// </summary>
        private void ParseWeekday()
        {
            if (!int.TryParse(WeekdayTextBox.Text, out var a) &&
                Enum.TryParse<Weekday>(WeekdayTextBox.Text, true, out Weekday weekday))
            {
                IsitWeekday.Text = $"Есть такой день недели ({weekday} = {(int)weekday + 1})";
                return;
            }
            IsitWeekday.Text = "Нет такого дня недели";
        }

        private void WeekdayParseButton_Click(object sender, EventArgs e) => ParseWeekday();
    }
}
