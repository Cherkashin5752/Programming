using System.Reflection;
using Programming.Model.Enums;
using Programming.Model;

namespace Programming
{
    // Главная форма приложения, демонстрирующая работу с перечислениями
    public partial class MainForm : Form
    {
        private Model.Geometry.Rectangle[] _rectangles = new Model.Geometry.Rectangle[10];
        private List<Model.Geometry.Rectangle> _drawRectangles = new List<Model.Geometry.Rectangle>();
        private Model.Geometry.Rectangle _currentRectangle;
        private Model.Geometry.Rectangle _drawCurrentRectangle;

        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;

        private string[] _colors = { "Red", "Blue", "Green", "Yellow", "Orange",
            "Purple", "Pink", "Brown", "Black", "White" };
        private string[] _movieNames = { "Inception", "The Godfather", "Interstellar",
            "Pulp Fiction", "The Matrix", "Gladiator", "Parasite", "Joker", "Avatar", "Titanic" };
        private string[] _movieGenres = { "Action", "Comedy", "Drama", "Horror",
            "Sci-Fi", "Thriller", "Documentary", "Fantasy", "Animation", "Romance" };

        Random rnd = new Random();

        // Создает экземпляр основной формы
        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Model.Geometry.Rectangle(
                    rnd.Next(1, 31),
                    rnd.Next(1, 31),
                    _colors[rnd.Next(0, 9)],
                    rnd.Next(1, 30),
                    rnd.Next(1, 30)
                    );

                RectanglesListBox.Items.Add($"Rectangles {i + 1}");
            }

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
        }

        private void AddRectangle()
        {
            Model.Geometry.Rectangle newRectangle = new Model.Geometry.Rectangle(rnd.Next(1, 30),
                                                                            rnd.Next(1, 30),
                                                                            _colors[rnd.Next(0, 10)],
                                                                            rnd.Next(1, 30),
                                                                            rnd.Next(1, 30)
                                                                            );

            _drawRectangles.Add(newRectangle);
            DrawRectanglesListBox.Items.Add($"{newRectangle.Id}: (X = {newRectangle.X}," +
                $" Y = {newRectangle.Y}, W = {newRectangle.Width}, H = {newRectangle.Length})");
        }

        // Проверяет и обновляет год выпуска текущего фильма
        private void YearTextboxChanged()
        {
            try
            {
                int newYear = int.Parse(YearTextBox.Text);
                if (newYear < 1900)
                    throw new Exception();
                _currentMovie.Year = newYear;
                YearTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                YearTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        // Проверяет и обновляет рейтинг текущего фильма
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
                return;
            }
        }

        // Проверяет и обновляет продолжительность текущего фильма
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
                return;
            }
        }

        // Обновляет жанр текущего фильма
        private void GenreTextboxChanged()
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        // Обновляет название текущего фильма
        private void NameTextboxChanged()
        {
            _currentMovie.Name = NameTextBox.Text;
        }

        // Находит индекс фильма с максимальным рейтингом
        private int FindMovieWithMaxRating()
        {
            int max = 0;

            for (int i = 1; i < _movies.Length; i++)
            {
                if (_movies[i].Rating > _movies[max].Rating)
                {
                    max = i;
                }
            }

            return max;
        }

        // Обновляет данные на форме при смене выбранного фильма
        private void ChangeChoosenMovie()
        {
            _currentMovie = _movies[MoviesListBox.SelectedIndex];

            NameTextBox.Text = _currentMovie.Name;
            GenreTextBox.Text = _currentMovie.Genre;
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        // Возвращает индекс прямоугольника с максимальной шириной
        private int FindRectangleWithMaxWidth()
        {
            int max = 0;

            for (int i = 1; i < _rectangles.Length; i++)
            {
                if (_rectangles[i].Width > _rectangles[max].Width)
                {
                    max = i;
                }
            }

            return max;
        }

        // Обновляет цвет текущего прямоугольника
        private void ColorTextboxChanged()
        {
            _currentRectangle.Color = ColorTextBox.Text;
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

        /// Выводит целочисленное значение выбранной константы перечисления в текстовое поле
        private void ChangeIntValueTextBox()
        {
            var selectedValue = ValuesListBox.SelectedItem;
            IntValueTextBox.Text = $"{(int)selectedValue}";
        }

        /// Проверяет введенную строку на соответствие элементам перечисления Weekday
        private void ParseWeekday()
        {
            // Пытаемся распарсить строку, исключая ввод чисел
            if (!int.TryParse(WeekdayTextBox.Text, out var a) &&
                Enum.TryParse<Weekday>(WeekdayTextBox.Text, true, out Weekday weekday))
            {
                IsitWeekday.Text = $"Есть такой день недели ({weekday} = {(int)weekday + 1})";
                return;
            }

            IsitWeekday.Text = "Нет такого дня недели";
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

        // Обновляет данные на форме при смене выбранного прямоугольника
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

        public void DeleteRectanglesList()
        {
            if (DrawRectanglesListBox.SelectedIndex != -1)
            {
                int selectedRectangle = DrawRectanglesListBox.SelectedIndex;

                _drawRectangles.Remove(_drawRectangles[selectedRectangle]);
                DrawRectanglesListBox.Items.RemoveAt(selectedRectangle);

                DrawXTextBox.BackColor = System.Drawing.Color.White;
            }
        }

        public void ChangeRectangleListBoxs()
        {
            if (DrawRectanglesListBox.SelectedIndex != -1)
            {
                _drawCurrentRectangle = _drawRectangles[DrawRectanglesListBox.SelectedIndex];

                DrawIdTextBox.Text = (_drawCurrentRectangle.Id).ToString();
                DrawXTextBox.Text = _drawCurrentRectangle.X.ToString();
                DrawYTextBox.Text = _drawCurrentRectangle.Y.ToString();
                DrawWidthTextBox.Text = _drawCurrentRectangle.Width.ToString();
                DrawLengthTextBox.Text = _drawCurrentRectangle.Length.ToString();
            }
            else
            {
                DrawIdTextBox.Text = "";
                DrawXTextBox.Text = "";
                DrawYTextBox.Text = "";
                DrawWidthTextBox.Text = "";
                DrawLengthTextBox.Text = "";
            }
        }

        public void DrawXTextBoxChanged()
        {
            try
            {
                int newX = int.Parse(DrawXTextBox.Text);
                _drawCurrentRectangle.X = newX;
                DrawRectanglesListBox.Items[DrawRectanglesListBox.SelectedIndex] = $"{_drawCurrentRectangle.Id}: " +
                    $"(X = {_drawCurrentRectangle.X}, Y = {_drawCurrentRectangle.Y}, W = {_drawCurrentRectangle.Width}, " +
                    $" H = {_drawCurrentRectangle.Length})";
                DrawXTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                DrawXTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        public void DrawYTextBoxChanged()
        {
            try
            {
                int newY = int.Parse(DrawYTextBox.Text);
                _drawCurrentRectangle.Y = newY;
                DrawRectanglesListBox.Items[DrawRectanglesListBox.SelectedIndex] = $"{_drawCurrentRectangle.Id}: " +
                    $"(X = {_drawCurrentRectangle.X}, Y = {_drawCurrentRectangle.Y}, W = {_drawCurrentRectangle.Width}, " +
                    $" H = {_drawCurrentRectangle.Length})";
                DrawXTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                DrawXTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        public void DrawWidthTextBoxChanged()
        {
            try
            {
                int newWidth = int.Parse(DrawWidthTextBox.Text);
                _drawCurrentRectangle.Width = newWidth;
                DrawRectanglesListBox.Items[DrawRectanglesListBox.SelectedIndex] = $"{_drawCurrentRectangle.Id}: " +
                    $"(X = {_drawCurrentRectangle.X}, Y = {_drawCurrentRectangle.Y}, W = {_drawCurrentRectangle.Width}, " +
                    $" H = {_drawCurrentRectangle.Length})";
                DrawWidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                DrawWidthTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        public void DrawLengthTextBoxChanged()
        {
            try
            {
                int newLength = int.Parse(DrawLengthTextBox.Text);
                _drawCurrentRectangle.Length = newLength;
                DrawRectanglesListBox.Items[DrawRectanglesListBox.SelectedIndex] = $"{_drawCurrentRectangle.Id}: " +
                    $"(X = {_drawCurrentRectangle.X}, Y = {_drawCurrentRectangle.Y}, W = {_drawCurrentRectangle.Width}, " +
                    $" H = {_drawCurrentRectangle.Length})";
                DrawLengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                DrawLengthTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        // Обработчик изменения выбора в списке прямоугольников
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeChoosenRectangle();
        }

        /// Обработчик нажатия кнопки парсинга дня недели
        private void WeekdayParseButton_Click(object sender, EventArgs e)
        {
            ParseWeekday();
        }

        /// Обработчик нажатия кнопки применения эффекта времени года
        private void GoSeasonButton_Click(object sender, EventArgs e)
        {
            GoSeason();
        }

        /// Обработчик изменения выбранного перечисления
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeValueListBox();
        }

        /// Обработчик изменения выбранного значения в списке констант перечислений
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeIntValueTextBox();
        }

        // Обработчик изменения текста в поле цвета прямоугольника
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            ColorTextboxChanged();
        }

        // Обработчик нажатия кнопки поиска самого широкого прямоугольника
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int maxWidth = FindRectangleWithMaxWidth();

            RectanglesListBox.SelectedIndex = maxWidth;
        }

        // Обработчик изменения выбора в списке фильмов
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeChoosenMovie();
        }

        // Обработчик нажатия кнопки поиска фильма с максимальным рейтингом
        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int maxRating = FindMovieWithMaxRating();

            MoviesListBox.SelectedIndex = maxRating;
        }

        // Обработчик изменения текста в поле названия фильма.
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameTextboxChanged();
        }

        // Обработчик изменения текста в поле жанра фильма
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            GenreTextboxChanged();
        }

        // Обработчик изменения текста в поле продолжительности фильма
        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            DurationTextboxChanged();
        }

        // Обработчик изменения текста в поле рейтинга фильма
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            RatingTextboxChanged();
        }

        // Обработчик изменения текста в поле года выпуска фильма
        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            YearTextboxChanged();
        }

        private void AddRectengleButton_Click(object sender, EventArgs e)
        {
            AddRectangle();
        }

        private void DeletRectangleButton_Click(object sender, EventArgs e)
        {
            DeleteRectanglesList();
        }

        private void DrawRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRectangleListBoxs();
        }

        private void DrawXTextBox_TextChanged(object sender, EventArgs e)
        {
            DrawXTextBoxChanged();
        }

        private void DrawYTextBox_TextChanged(object sender, EventArgs e)
        {
            DrawYTextBoxChanged();
        }

        private void DrawWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            DrawWidthTextBoxChanged();
        }

        private void DrawLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            DrawLengthTextBoxChanged();
        }
    }
}