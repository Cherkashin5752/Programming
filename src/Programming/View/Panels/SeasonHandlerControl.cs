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
    public partial class SeasonHandlerControl : UserControl
    {
        public SeasonHandlerControl()
        {
            InitializeComponent();
        }

        private void SeasonHandlerControl_Load(object sender, EventArgs e)
        {
            // Заполнение выпадающего списка времен года напрямую из Enum
            foreach (var season in Enum.GetValues<Season>())
            {
                SeasonComboBox.Items.Add(season);
            }
        }

        /// <summary>
        /// Совершает уникальное события в соответствии с выбранным сезоном
        /// </summary>
        private void GoSeason()
        {
            if (SeasonComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите время года");
                return;
            }

            var selectedSeason = SeasonComboBox.SelectedItem;
            switch (selectedSeason)
            {
                case Season.Spring:
                    BackColor = System.Drawing.Color.FromArgb(85, 156, 69);
                    break;
                case Season.Autumn:
                    BackColor = System.Drawing.Color.FromArgb(226, 156, 69);
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
            }
        }

        private void GoSeasonButton_Click(object sender, EventArgs e) => GoSeason();
    }
}
