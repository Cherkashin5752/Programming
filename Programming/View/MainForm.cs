using Programming.Model.Enums;
using System.Reflection;

namespace Programming
{
    // Главная форма приложения, демонстрирующая работу с перечислениями
    public partial class MainForm : Form
    {
        // Создает экземпляр основной формы
        public MainForm()
        {
            InitializeComponent();
        }

        // Обработчик события загрузки формы. Выполняет инициализацию списков на основе типов перечислений
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Получаем все типы-перечисления из заданного пространства имен через рефлексию
            var enums = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsEnum && t.Namespace == "Programming.Model.Enums");

            IsitWeekday.Text = "";

            foreach (var en in enums)
                EnumsListBox.Items.Add(en);

            EnumsListBox.DisplayMember = "Name";

            // Установка начального состояния интерфейса
            EnumsListBox.SetSelected(0, true);
            ChangeValueListBox();

            // Заполнение выпадающего списка времен года
            foreach (var season in Enum.GetValues<Season>())
            {
                SeasonComboBox.Items.Add(season);
            }

            // Подписка на события изменения выбора
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedItemChanged;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedItemChanged;
        }

        /// Обработчик изменения выбранного перечисления
        private void EnumsListBox_SelectedItemChanged(object sender, EventArgs e)
        {
            ChangeValueListBox();
        }

        /// Обновляет список значений (ValuesListBox) в зависимости от выбранного перечисления
        private void ChangeValueListBox()
        {
            ValuesListBox.Items.Clear();

            Type selectedEnum = (Type)EnumsListBox.SelectedItem!;

            foreach (var value in Enum.GetValues(selectedEnum))
            {
                ValuesListBox.Items.Add(value);
            }
        }

        /// Обработчик изменения выбранного значения в списке констант перечисления
        private void ValuesListBox_SelectedItemChanged(object sender, EventArgs e)
        {
            ChangeIntValueTextBox();
        }

        /// Выводит целочисленное значение выбранной константы перечисления в текстовое поле
        private void ChangeIntValueTextBox()
        {
            var selectedValue = ValuesListBox.SelectedItem;
            IntValueTextBox.Text = $"{(int)selectedValue}";
        }

        /// Обработчик нажатия кнопки парсинга дня недели
        private void WeekdayParseButton_Click(object sender, EventArgs e)
        {
            ParseWeekday();
        }

        /// Проверяет введенную строку на соответствие элементам перечисления Weekday
        private void ParseWeekday()
        {
            // Пытаемся распарсить строку, исключая ввод чисел
            if (!int.TryParse(WeekdayTextBox.Text, out var a) &&
                Enum.TryParse<Weekday>(WeekdayTextBox.Text, true, out Weekday weekday))
            {
                IsitWeekday.Text = $"Есть такой день недели({weekday} = {(int)weekday + 1})";
                return;
            }

            IsitWeekday.Text = "Нет такого дня недели";
        }

        /// Обработчик нажатия кнопки применения эффекта времени года
        private void GoSeasonButton_Click(object sender, EventArgs e)
        {
            GoSeason();
        }

        /// Выполняет действие, соответствующее выбранному времени года
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
    }
}
