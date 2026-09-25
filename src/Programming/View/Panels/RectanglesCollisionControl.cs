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
    public partial class RectanglesCollisionControl : UserControl
    {
        // Список прямоугольников
        private List<Model.Geometry.Rectangle> _drawRectangles = new List<Model.Geometry.Rectangle>();
        
        // Текущий выбранный прямоугольник
        private Model.Geometry.Rectangle _drawCurrentRectangle;

        /// <summary>
        /// Список панелей для рисования
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Создаёт новый прямокгольник для орисовки
        /// </summary>
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
            // Добавляем панель на форму
            CanvasPanel.Controls.Add(newPanel);

            // Проверяем на пересечения сразу после добавления
            FindCollision(); 
        }

        /// <summary>
        /// Удаляет выбранный прямоугольник и связанную с ним панель
        /// </summary>
        public void DeleteRectanglesList()
        {
            if (DrawRectanglesListBox.SelectedIndex != -1)
            {
                int selectedRectangle = DrawRectanglesListBox.SelectedIndex;

                _drawRectangles.RemoveAt(selectedRectangle);
                DrawRectanglesListBox.Items.RemoveAt(selectedRectangle);
                _rectanglePanels.RemoveAt(selectedRectangle);
                CanvasPanel.Controls.RemoveAt(selectedRectangle);

                // Пересчитываем коллизии после удаления
                FindCollision();
            }
        }

        /// <summary>
        /// Перезаполняет все TextBox'ы в соответствии с выбранным прямоугольником
        /// </summary>
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
                ClearRectangleInfo();
            }
        }

        /// <summary>
        /// Созраняет координату X прямоугольника
        /// </summary>
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

        /// <summary>
        /// Созраняет координату Y прямоугольника
        /// </summary>
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

        /// <summary>
        /// Созраняет координату длину прямоугольника
        /// </summary>
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

        /// <summary>
        /// Созраняет координату ширину прямоугольника
        /// </summary>
        public void DrawWidthTextBoxChanged()
        {
            try
            {
                int newWidth = int.Parse(DrawWidthTextBox.Text);
                _drawCurrentRectangle.Width = newWidth;
                UpdateRectangleInfo(_drawCurrentRectangle);
                DrawWidthTextBox.BackColor = Color.White;
            }
            catch { DrawWidthTextBox.BackColor = Color.LightPink; }
        }

        /// <summary>
        /// Обновляет текстовую информацию в ListBox и положение/размер панели на холсте
        /// </summary>
        /// <param name="rectangle">изменяемый прямоугольник</param>
        private void UpdateRectangleInfo(Model.Geometry.Rectangle rectangle)
        {
            int index = DrawRectanglesListBox.SelectedIndex;
            if (index == -1)
                return;

            DrawRectanglesListBox.Items[index] = $"{rectangle.Id}: (X = {rectangle.X}, Y = {rectangle.Y}, W = {rectangle.Width}, H = {rectangle.Length})";

            Panel panel = _rectanglePanels[index];
            panel.Location = new Point(rectangle.X, rectangle.Y);
            panel.Width = rectangle.Width;
            panel.Height = rectangle.Length;

            // Перепроверка коллизий после перемещения/изменения размера
            FindCollision(); 
        }

        /// <summary>
        /// Находит и перекрашивает все скрещивающиеся прямоугольники
        /// </summary>
        private void FindCollision()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            // Перебор всех пар прямоугольников
            for (int i = 0; i < _rectanglePanels.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectanglePanels.Count; j++)
                {
                    // Если два текущих прямоугольника скрещивабтся, перекрасить их в крассный
                    if (CollisionManager.IsCollision(_drawRectangles[i], _drawRectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        /// <summary>
        /// Сбрасывает все значения во всех TextBox'ы
        /// </summary>
        private void ClearRectangleInfo()
        {
            DrawIdTextBox.Text = "";
            DrawXTextBox.Text = "";
            DrawYTextBox.Text = "";
            DrawWidthTextBox.Text = "";
            DrawLengthTextBox.Text = "";
            DrawXTextBox.BackColor = System.Drawing.Color.White;
            DrawYTextBox.BackColor = System.Drawing.Color.White;
            DrawWidthTextBox.BackColor = System.Drawing.Color.White;
            DrawLengthTextBox.BackColor = System.Drawing.Color.White;
        }

        private void AddRectengleButton_Click(object sender, EventArgs e) => AddRectangle();
        private void DeletRectangleButton_Click(object sender, EventArgs e) => DeleteRectanglesList();
        private void DrawRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e) => ChangeRectangleListBoxs();
        private void DrawXTextBox_TextChanged(object sender, EventArgs e) => DrawXTextBoxChanged();
        private void DrawYTextBox_TextChanged(object sender, EventArgs e) => DrawYTextBoxChanged();
        private void DrawWidthTextBox_TextChanged(object sender, EventArgs e) => DrawWidthTextBoxChanged();
        private void DrawLengthTextBox_TextChanged(object sender, EventArgs e) => DrawLengthTextBoxChanged();
    }
}
