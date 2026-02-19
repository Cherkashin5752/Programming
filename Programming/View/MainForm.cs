using System.Reflection;
using Programming.Model.Enums;
using Programming.Model;
using Programming.Model.Geometry;

namespace Programming
{
    // Главная форма приложения, демонстрирующая работу с перечислениями, классами Movie и Rectangle
    public partial class MainForm : Form
    {
        // --- Поля для работы с прямоугольниками (вкладка Rectangles) ---
        private Model.Geometry.Rectangle[] _rectangles = new Model.Geometry.Rectangle[10];
        private Model.Geometry.Rectangle _currentRectangle;

        // --- Поля для интерактивного рисования прямоугольников (вкладка 2D Graphics) ---
        private List<Model.Geometry.Rectangle> _drawRectangles = new List<Model.Geometry.Rectangle>();
        private Model.Geometry.Rectangle _drawCurrentRectangle;
        private List<Panel> _rectanglePanels = new List<Panel>(); // Список панелей (визуальных представлений прямоугольников)

        // --- Поля для работы с фильмами ---
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;

        // Данные для генерации случайных фильмов
        private string[] _movieNames = { "Inception", "The Godfather", "Interstellar",
            "Pulp Fiction", "The Matrix", "Gladiator", "Parasite", "Joker", "Avatar", "Titanic" };
        private string[] _movieGenres = { "Action", "Comedy", "Drama", "Horror",
            "Sci-Fi", "Thriller", "Documentary", "Fantasy", "Animation", "Romance" };

        private Random rnd = new Random();

        // Конструктор формы: инициализирует компоненты и заполняет массивы начальными данными
        public MainForm()
        {
            InitializeComponent();

            // Инициализация массива случайных прямоугольников для первой вкладки
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = RectangleFactory.Randomize();
                RectanglesListBox.Items.Add($"Rectangles {i + 1}");
            }

            // Инициализация массива случайных фильмов
            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(
                    _movieNames[rnd.Next(0, 9)],
                    _movieGenres[rnd.Next(0, 9)],
                    rnd.Next(100, 240),
                    rnd.Next(2000, 2026),
                    (double)rnd.Next(0, 10) + (double)(rnd.Next(1, 10) / 10.0)
                    );

                MoviesListBox.Items.Add($"Movie {i + 1}");
            }
        }

        // Обработчик события загрузки формы: настройка интерфейса перечислений
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Используем Reflection для поиска всех Enum в указанном пространстве имен
            var enums = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsEnum && t.Namespace == "Programming.Model.Enums");

            IsitWeekday.Text = "";

            // Заполняем список доступных перечислений
            foreach (var en in enums)
                EnumsListBox.Items.Add(en);

            EnumsListBox.DisplayMember = "Name";
            EnumsListBox.SetSelected(0, true); // Выбираем первый элемент по умолчанию
            ChangeValueListBox();

            // Заполнение выпадающего списка времен года напрямую из Enum
            foreach (var season in Enum.GetValues<Season>())
            {
                SeasonComboBox.Items.Add(season);
            }
        }

        // Добавляет новый случайный прямоугольник на холст (CanvasPanel)
        private void AddRectangle()
        {
            Model.Geometry.Rectangle newRectangle = RectangleFactory.Randomize();
            _drawRectangles.Add(newRectangle);

            // Добавляем строковое описание в ListBox
            DrawRectanglesListBox.Items.Add($"{newRectangle.Id}: (X = {newRectangle.X}," +
                $" Y = {newRectangle.Y}, W = {newRectangle.Width}, H = {newRectangle.Length})");

            // Создаем визуальный элемент (Panel) для отображения прямоугольника
            Panel newPanel = new Panel();
            newPanel.Location = new Point(newRectangle.X, newRectangle.Y);
            newPanel.Width = newRectangle.Width;
            newPanel.Height = newRectangle.Length;
            newPanel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127); // Светло-зеленый (полупрозрачный)

            _rectanglePanels.Add(newPanel);
            CanvasPanel.Controls.Add(newPanel); // Добавляем панель на форму

            FindCollision(); // Проверяем на пересечения сразу после добавления
        }


        private void YearTextboxChanged()
        {
            try
            {
                int newYear = int.Parse(YearTextBox.Text);
                _currentMovie.Year = newYear;
                YearTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                YearTextBox.BackColor = System.Drawing.Color.LightPink; // Индикация ошибки
            }
        }

        private void RatingTextboxChanged()
        {
            try
            {
                double newRating = double.Parse(RatingTextBox.Text);
                _currentMovie.Rating = newRating;
                RatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void DurationTextboxChanged()
        {
            try
            {
                int newDuration = int.Parse(DurationTextBox.Text);
                _currentMovie.Duration = newDuration;
                DurationTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void GenreTextboxChanged() => _currentMovie.Genre = GenreTextBox.Text;

        private void NameTextboxChanged() => _currentMovie.Name = NameTextBox.Text;

        // Поиск фильма с самым высоким рейтингом
        private int FindMovieWithMaxRating()
        {
            int max = 0;
            for (int i = 1; i < _movies.Length; i++)
            {
                if (_movies[i].Rating > _movies[max].Rating) max = i;
            }
            return max;
        }

        // Синхронизирует текстовые поля с данными выбранного фильма
        private void ChangeChoosenMovie()
        {
            _currentMovie = _movies[MoviesListBox.SelectedIndex];
            NameTextBox.Text = _currentMovie.Name;
            GenreTextBox.Text = _currentMovie.Genre;
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        // Нахождение и указание на прямоуглльник с самой большой шириной
        private int FindRectangleWithMaxWidth()
        {
            int max = 0;
            for (int i = 1; i < _rectangles.Length; i++)
            {
                if (_rectangles[i].Width > _rectangles[max].Width) max = i;
            }
            return max;
        }

        private void ColorTextboxChanged() => _currentRectangle.Color = ColorTextBox.Text;

        // Обновляет список значений во втором ListBox при выборе типа Enum
        private void ChangeValueListBox()
        {
            ValuesListBox.Items.Clear();
            Type selectedEnum = (Type)EnumsListBox.SelectedItem!;
            foreach (var value in Enum.GetValues(selectedEnum))
            {
                ValuesListBox.Items.Add(value);
            }
        }

        // Показывает числовой эквивалент выбранного значения перечисления
        private void ChangeIntValueTextBox()
        {
            var selectedValue = ValuesListBox.SelectedItem;
            if (selectedValue != null)
                IntValueTextBox.Text = $"{(int)selectedValue}";
        }

        // Логика парсинга введенной строки в перечисление Weekday
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

        // Логика кнопки "Применить" для времен года
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

        // Обновляет UI для выбранного статического прямоугольника
        public void ChangeChoosenRectangle()
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            CenterXTextBox.Text = _currentRectangle.X.ToString();
            CenterYTextBox.Text = _currentRectangle.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        // Удаляет выбранный прямоугольник и связанную с ним панель
        public void DeleteRectanglesList()
        {
            if (DrawRectanglesListBox.SelectedIndex != -1)
            {
                int selectedRectangle = DrawRectanglesListBox.SelectedIndex;

                _drawRectangles.RemoveAt(selectedRectangle);
                DrawRectanglesListBox.Items.RemoveAt(selectedRectangle);
                _rectanglePanels.RemoveAt(selectedRectangle);
                CanvasPanel.Controls.RemoveAt(selectedRectangle);

                FindCollision(); // Пересчитываем коллизии после удаления
            }
        }

        // При выборе прямоугольника в списке Graphics заполняет поля координат и размеров
        public void ChangeRectangleListBoxs()
        {
            if (DrawRectanglesListBox.SelectedIndex != -1)
            {
                _drawCurrentRectangle = _drawRectangles[DrawRectanglesListBox.SelectedIndex];
                DrawIdTextBox.Text = _drawCurrentRectangle.Id.ToString();
                DrawXTextBox.Text = _drawCurrentRectangle.X.ToString();
                DrawYTextBox.Text = _drawCurrentRectangle.Y.ToString();
                DrawWidthTextBox.Text = _drawCurrentRectangle.Width.ToString();
                DrawLengthTextBox.Text = _drawCurrentRectangle.Length.ToString();
            }
            else
            {
                ClearRectangleIndo();
            }
        }

        // Методы Draw...TextBoxChanged: обновляют параметры прямоугольника с проверкой ввода
        public void DrawXTextBoxChanged()
        {
            try
            {
                int newX = int.Parse(DrawXTextBox.Text);
                _drawCurrentRectangle.X = newX;
                UpdateRectangleInfo(_drawCurrentRectangle);
                DrawXTextBox.BackColor = System.Drawing.Color.White;
            }
            catch { DrawXTextBox.BackColor = System.Drawing.Color.LightPink; }
        }

        public void DrawYTextBoxChanged()
        {
            try
            {
                int newY = int.Parse(DrawYTextBox.Text);
                _drawCurrentRectangle.Y = newY;
                UpdateRectangleInfo(_drawCurrentRectangle);
                DrawYTextBox.BackColor = System.Drawing.Color.White;
            }
            catch { DrawYTextBox.BackColor = System.Drawing.Color.LightPink; }
        }

        public void DrawWidthTextBoxChanged()
        {
            try
            {
                int newWidth = int.Parse(DrawWidthTextBox.Text);
                _drawCurrentRectangle.Width = newWidth;
                UpdateRectangleInfo(_drawCurrentRectangle);
                DrawWidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch { DrawWidthTextBox.BackColor = System.Drawing.Color.LightPink; }
        }

        public void DrawLengthTextBoxChanged()
        {
            try
            {
                int newLength = int.Parse(DrawLengthTextBox.Text);
                _drawCurrentRectangle.Length = newLength;
                UpdateRectangleInfo(_drawCurrentRectangle);
                DrawLengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch { DrawLengthTextBox.BackColor = System.Drawing.Color.LightPink; }
        }

        // Главный метод поиска коллизий. Красит пересекающиеся прямоугольники в красный.
        private void FindCollision()
        {
            // Сбрасываем цвета всех панелей на зеленый
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            // Попарное сравнение каждого прямоугольника с каждым (алгоритм O(n^2))
            for (int i = 0; i < _drawRectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _drawRectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_drawRectangles[i], _drawRectangles[j]))
                    {
                        // Если есть столкновение, красим обе панели в красный
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        // Обновляет текстовую информацию в ListBox и положение/размер панели на холсте
        private void UpdateRectangleInfo(Model.Geometry.Rectangle rectangle)
        {
            int index = DrawRectanglesListBox.SelectedIndex;
            if (index == -1) return;

            DrawRectanglesListBox.Items[index] = $"{rectangle.Id}: (X = {rectangle.X}, Y = {rectangle.Y}, W = {rectangle.Width}, H = {rectangle.Length})";

            Panel panel = _rectanglePanels[index];
            panel.Location = new Point(rectangle.X, rectangle.Y);
            panel.Width = rectangle.Width;
            panel.Height = rectangle.Length;

            FindCollision(); // Перепроверка коллизий после перемещения/изменения размера
        }

        // Очистка полей ввода информации о прямоугольнике
        private void ClearRectangleIndo()
        {
            DrawIdTextBox.Clear(); DrawXTextBox.Clear(); DrawYTextBox.Clear();
            DrawWidthTextBox.Clear(); DrawLengthTextBox.Clear();
            DrawXTextBox.BackColor = DrawYTextBox.BackColor = DrawWidthTextBox.BackColor = DrawLengthTextBox.BackColor = System.Drawing.Color.White;
        }

        // --- Обработчики событий элементов управления (привязка к методам выше) ---

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e) => ChangeChoosenRectangle();
        private void WeekdayParseButton_Click(object sender, EventArgs e) => ParseWeekday();
        private void GoSeasonButton_Click(object sender, EventArgs e) => GoSeason();
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e) => ChangeValueListBox();
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e) => ChangeIntValueTextBox();
        private void ColorTextBox_TextChanged(object sender, EventArgs e) => ColorTextboxChanged();
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int maxWidth = FindRectangleWithMaxWidth();
            RectanglesListBox.SelectedIndex = maxWidth;
        }
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e) => ChangeChoosenMovie();
        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int maxRating = FindMovieWithMaxRating();
            MoviesListBox.SelectedIndex = maxRating;
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e) => NameTextboxChanged();
        private void GenreTextBox_TextChanged(object sender, EventArgs e) => GenreTextboxChanged();
        private void DurationTextBox_TextChanged(object sender, EventArgs e) => DurationTextboxChanged();
        private void RatingTextBox_TextChanged(object sender, EventArgs e) => RatingTextboxChanged();
        private void YearTextBox_TextChanged(object sender, EventArgs e) => YearTextboxChanged();
        private void AddRectengleButton_Click(object sender, EventArgs e) => AddRectangle();
        private void DeletRectangleButton_Click(object sender, EventArgs e) => DeleteRectanglesList();
        private void DrawRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e) => ChangeRectangleListBoxs();
        private void DrawXTextBox_TextChanged(object sender, EventArgs e) => DrawXTextBoxChanged();
        private void DrawYTextBox_TextChanged(object sender, EventArgs e) => DrawYTextBoxChanged();
        private void DrawWidthTextBox_TextChanged(object sender, EventArgs e) => DrawWidthTextBoxChanged();
        private void DrawLengthTextBox_TextChanged(object sender, EventArgs e) => DrawLengthTextBoxChanged();
    }
}