using Programming.Model.Geometry;
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
    public partial class RectenglesControl : UserControl
    {
        // Массив прямоугольников
        private Model.Geometry.Rectangle[] _rectangles = new Model.Geometry.Rectangle[5];
        
        // Текущий выбранный прямоугольник
        private Model.Geometry.Rectangle _currentRectangle;

        public RectenglesControl()
        {
            InitializeComponent();
        }

        private void RectenglesControl_Load(object sender, EventArgs e)
        {
            // Инициализация массива случайных прямоугольников для первой вкладки
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = RectangleFactory.Randomize();
                RectanglesListBox.Items.Add($"Rectangles {i + 1}");
            }
        }

        /// <summary>
        /// Нахождение и указание на прямоуглльник с самой большой шириной
        /// </summary>
        /// <returns></returns>
        private int FindRectangleWithMaxWidth()
        {
            int max = 0;
            for (int i = 1; i < _rectangles.Length; i++)
            {
                if (_rectangles[i].Width > _rectangles[max].Width) max = i;
            }
            return max;
        }

        /// <summary>
        /// Сохраняет цвет выбранного прямоугольника
        /// </summary>
        private void ColorTextboxChanged() => _currentRectangle.Color = ColorTextBox.Text;

        /// <summary>
        /// Перезаполняет все TextBox'ы в соответствии с выбранным прямоугольником
        /// </summary>
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

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e) => ChangeChoosenRectangle();
        private void ColorTextBox_TextChanged(object sender, EventArgs e) => ColorTextboxChanged();
        
        /// <summary>
        /// Выделяет прямоугольник с наибольшей шириной
        /// </summary>
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int maxWidth = FindRectangleWithMaxWidth();
            RectanglesListBox.SelectedIndex = maxWidth;
        }
    }
}
