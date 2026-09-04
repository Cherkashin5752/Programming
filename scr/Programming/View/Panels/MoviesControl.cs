using Programming.Model;
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
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Массив фильмов
        /// </summary>
        private Movie[] _movies = new Movie[5];
        
        /// <summary>
        /// Текущий выбранный фильм
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Массив названий фильмов
        /// </summary>
        private string[] _movieNames = { "Inception", "The Godfather", "Interstellar",
            "Pulp Fiction", "The Matrix", "Gladiator", "Parasite", "Joker", "Avatar", "Titanic" };
        /// <summary>
        /// Массив жанров фильмов
        /// </summary>
        private string[] _movieGenres = { "Action", "Comedy", "Drama", "Horror",
            "Sci-Fi", "Thriller", "Documentary", "Fantasy", "Animation", "Romance" };

        Random rnd = new Random();

        public MoviesControl()
        {
            InitializeComponent();
        }


        private void MoviesControl_Load(object sender, EventArgs e)
        {
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

        /// <summary>
        /// Сохраняет год выхода выбранного фильма
        /// </summary>
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

        /// <summary>
        /// Сохраняет рейтинг выбранного фильма
        /// </summary>
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

        /// <summary>
        /// Сохраняет продолжительность выбранного фильма
        /// </summary>
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

        /// <summary>
        /// Созраняет жанр выбранного фильма
        /// </summary>
        private void GenreTextboxChanged() => _currentMovie.Genre = GenreTextBox.Text;

        private void NameTextboxChanged() => _currentMovie.Name = NameTextBox.Text;

        /// <summary>
        /// Находит фильм с наивысшим рейтингом
        /// </summary>
        /// <returns>Возвращает индекс фильма с наивысшим рейтингом</returns>
        private int FindMovieWithMaxRating()
        {
            int max = 0;
            for (int i = 1; i < _movies.Length; i++)
            {
                if (_movies[i].Rating > _movies[max].Rating) max = i;
            }
            return max;
        }

        /// <summary>
        /// Перезаполняет все TextBox'ы в соответствии с выбранным фильмом
        /// </summary>
        private void ChangeChoosenMovie()
        {
            _currentMovie = _movies[MoviesListBox.SelectedIndex];
            NameTextBox.Text = _currentMovie.Name;
            GenreTextBox.Text = _currentMovie.Genre;
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        /// <summary>
        /// Выделяет фильм с наибольшим рейтингом
        /// </summary>
        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int maxRating = FindMovieWithMaxRating();
            MoviesListBox.SelectedIndex = maxRating;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e) => ChangeChoosenMovie();
        private void NameTextBox_TextChanged(object sender, EventArgs e) => NameTextboxChanged();
        private void GenreTextBox_TextChanged(object sender, EventArgs e) => GenreTextboxChanged();
        private void DurationTextBox_TextChanged(object sender, EventArgs e) => DurationTextboxChanged();
        private void RatingTextBox_TextChanged(object sender, EventArgs e) => RatingTextboxChanged();
        private void YearTextBox_TextChanged(object sender, EventArgs e) => YearTextboxChanged();
    }
}
