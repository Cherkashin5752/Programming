using System.Reflection;
using Programming.Model.Enums;
using Programming.Model.Class;

namespace Programming
{
    // Главная форма приложения, демонстрирующая работу с перечислениями
    public partial class MainForm : Form
    {
        private Model.Class.Rectangle[] _rectangles = new Model.Class.Rectangle[10];
        private List<Model.Class.Rectangle> _drawRectangles = new List<Model.Class.Rectangle>();
        private Model.Class.Rectangle _currentRectangle;
        private Model.Class.Rectangle _drawCurrentRectangle;

        private Movie[] _movies = new Model.Class.Movie[5];
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
                _rectangles[i] = new Model.Class.Rectangle(
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
            Model.Class.Rectangle newRectangle = new Model.Class.Rectangle(rnd.Next(1, 30),
                                                                            rnd.Next(1, 30),
                                                                            _colors[rnd.Next(0, 10)],
                                                                            rnd.Next(1, 30),
                                                                            rnd.Next(1, 30)
                                                                            );

            _drawRectangles.Add(newRectangle);
            DrawRectanglesListBox.Items.Add($"{newRectangle.Id - _rectangles.Length}: (X = {newRectangle.Center.X}," +
                $" Y = {newRectangle.Center.Y} W = {newRectangle.Width}, H = {newRectangle.Length})");
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
                if (newRating < 0 && newRating > 10)
                    throw new Exception();
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
                if (newDuration < 0)
                    throw new Exception();
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
            CenterXTextBox.Text = _currentRectangle.Center.X.ToString();
            CenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        public void DeleteRectanglesList()
        {
            if (DrawRectanglesListBox.SelectedIndex != -1)
            { 
                int selectedRectangle = DrawRectanglesListBox.SelectedIndex;

                _drawRectangles.Remove(_drawRectangles[selectedRectangle]);
                DrawRectanglesListBox.Items.RemoveAt(selectedRectangle);
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
    }
}