namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Enums = new TabPage();
            groupBox3 = new GroupBox();
            SeasonComboBox = new ComboBox();
            GoSeasonButton = new Button();
            groupBox2 = new GroupBox();
            IsitWeekday = new Label();
            WeekdayParseButton = new Button();
            WeekdayTextBox = new TextBox();
            groupBox1 = new GroupBox();
            IntValuelabel = new Label();
            IntValueTextBox = new TextBox();
            ChooseValuelabel = new Label();
            ChooseEnumLabel = new Label();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabPage2 = new TabPage();
            groupBox5 = new GroupBox();
            YearLabel = new Label();
            YearTextBox = new TextBox();
            RatingLabel = new Label();
            RatingTextBox = new TextBox();
            FindMovieButton = new Button();
            DurationLabel = new Label();
            DurationTextBox = new TextBox();
            GenreLabel = new Label();
            GenreTextBox = new TextBox();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            MoviesListBox = new ListBox();
            groupBox4 = new GroupBox();
            FindRectangleButton = new Button();
            ColorLabel = new Label();
            ColorTextBox = new TextBox();
            WidthLabel = new Label();
            WidthTextBox = new TextBox();
            LengthLabel = new Label();
            LengthTextBox = new TextBox();
            RectanglesListBox = new ListBox();
            tabControl1.SuspendLayout();
            Enums.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Enums);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            Enums.Controls.Add(groupBox3);
            Enums.Controls.Add(groupBox2);
            Enums.Controls.Add(groupBox1);
            Enums.Location = new Point(4, 24);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(792, 422);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(SeasonComboBox);
            groupBox3.Controls.Add(GoSeasonButton);
            groupBox3.Location = new Point(405, 284);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(379, 130);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(6, 33);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(158, 23);
            SeasonComboBox.TabIndex = 3;
            // 
            // GoSeasonButton
            // 
            GoSeasonButton.Location = new Point(198, 33);
            GoSeasonButton.Name = "GoSeasonButton";
            GoSeasonButton.Size = new Size(75, 23);
            GoSeasonButton.TabIndex = 1;
            GoSeasonButton.Text = "Go!";
            GoSeasonButton.UseVisualStyleBackColor = true;
            GoSeasonButton.Click += GoSeasonButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(IsitWeekday);
            groupBox2.Controls.Add(WeekdayParseButton);
            groupBox2.Controls.Add(WeekdayTextBox);
            groupBox2.Location = new Point(8, 284);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 130);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekday Parsing";
            // 
            // IsitWeekday
            // 
            IsitWeekday.AutoSize = true;
            IsitWeekday.Location = new Point(6, 68);
            IsitWeekday.Name = "IsitWeekday";
            IsitWeekday.Size = new Size(29, 15);
            IsitWeekday.TabIndex = 2;
            IsitWeekday.Text = "Null";
            // 
            // WeekdayParseButton
            // 
            WeekdayParseButton.Location = new Point(198, 33);
            WeekdayParseButton.Name = "WeekdayParseButton";
            WeekdayParseButton.Size = new Size(75, 23);
            WeekdayParseButton.TabIndex = 1;
            WeekdayParseButton.Text = "Parse";
            WeekdayParseButton.UseVisualStyleBackColor = true;
            WeekdayParseButton.Click += WeekdayParseButton_Click;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(6, 33);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(158, 23);
            WeekdayTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(IntValuelabel);
            groupBox1.Controls.Add(IntValueTextBox);
            groupBox1.Controls.Add(ChooseValuelabel);
            groupBox1.Controls.Add(ChooseEnumLabel);
            groupBox1.Controls.Add(ValuesListBox);
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 272);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumerations";
            // 
            // IntValuelabel
            // 
            IntValuelabel.AutoSize = true;
            IntValuelabel.Location = new Point(335, 19);
            IntValuelabel.Name = "IntValuelabel";
            IntValuelabel.Size = new Size(55, 15);
            IntValuelabel.TabIndex = 5;
            IntValuelabel.Text = "Int Value:";
            IntValuelabel.UseWaitCursor = true;
            // 
            // IntValueTextBox
            // 
            IntValueTextBox.Location = new Point(335, 37);
            IntValueTextBox.Name = "IntValueTextBox";
            IntValueTextBox.Size = new Size(100, 23);
            IntValueTextBox.TabIndex = 4;
            // 
            // ChooseValuelabel
            // 
            ChooseValuelabel.AutoSize = true;
            ChooseValuelabel.Location = new Point(165, 19);
            ChooseValuelabel.Name = "ChooseValuelabel";
            ChooseValuelabel.Size = new Size(81, 15);
            ChooseValuelabel.TabIndex = 3;
            ChooseValuelabel.Text = "Choose Value:";
            ChooseValuelabel.UseWaitCursor = true;
            // 
            // ChooseEnumLabel
            // 
            ChooseEnumLabel.AutoSize = true;
            ChooseEnumLabel.Location = new Point(6, 19);
            ChooseEnumLabel.Name = "ChooseEnumLabel";
            ChooseEnumLabel.Size = new Size(126, 15);
            ChooseEnumLabel.TabIndex = 2;
            ChooseEnumLabel.Text = "Choose Enumerations:";
            ChooseEnumLabel.UseWaitCursor = true;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(165, 37);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(133, 214);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Location = new Point(6, 37);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(133, 214);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(YearLabel);
            groupBox5.Controls.Add(YearTextBox);
            groupBox5.Controls.Add(RatingLabel);
            groupBox5.Controls.Add(RatingTextBox);
            groupBox5.Controls.Add(FindMovieButton);
            groupBox5.Controls.Add(DurationLabel);
            groupBox5.Controls.Add(DurationTextBox);
            groupBox5.Controls.Add(GenreLabel);
            groupBox5.Controls.Add(GenreTextBox);
            groupBox5.Controls.Add(NameLabel);
            groupBox5.Controls.Add(NameTextBox);
            groupBox5.Controls.Add(MoviesListBox);
            groupBox5.Location = new Point(317, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(287, 351);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "Movie";
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(146, 230);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(32, 15);
            YearLabel.TabIndex = 11;
            YearLabel.Text = "Year:";
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(146, 248);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(100, 23);
            YearTextBox.TabIndex = 10;
            YearTextBox.TextChanged += YearTextBox_TextChanged;
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(146, 178);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(44, 15);
            RatingLabel.TabIndex = 9;
            RatingLabel.Text = "Rating:";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(146, 196);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(100, 23);
            RatingTextBox.TabIndex = 8;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // FindMovieButton
            // 
            FindMovieButton.Location = new Point(146, 303);
            FindMovieButton.Name = "FindMovieButton";
            FindMovieButton.Size = new Size(75, 23);
            FindMovieButton.TabIndex = 7;
            FindMovieButton.Text = "Find";
            FindMovieButton.UseVisualStyleBackColor = true;
            FindMovieButton.Click += FindMovieButton_Click;
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(146, 126);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(56, 15);
            DurationLabel.TabIndex = 6;
            DurationLabel.Text = "Duration:";
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(146, 144);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(100, 23);
            DurationTextBox.TabIndex = 5;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(146, 74);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(41, 15);
            GenreLabel.TabIndex = 4;
            GenreLabel.Text = "Genre:";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(146, 92);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(100, 23);
            GenreTextBox.TabIndex = 3;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(146, 22);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(146, 40);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 1;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // MoviesListBox
            // 
            MoviesListBox.FormattingEnabled = true;
            MoviesListBox.ItemHeight = 15;
            MoviesListBox.Location = new Point(6, 22);
            MoviesListBox.Name = "MoviesListBox";
            MoviesListBox.Size = new Size(120, 304);
            MoviesListBox.TabIndex = 0;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(FindRectangleButton);
            groupBox4.Controls.Add(ColorLabel);
            groupBox4.Controls.Add(ColorTextBox);
            groupBox4.Controls.Add(WidthLabel);
            groupBox4.Controls.Add(WidthTextBox);
            groupBox4.Controls.Add(LengthLabel);
            groupBox4.Controls.Add(LengthTextBox);
            groupBox4.Controls.Add(RectanglesListBox);
            groupBox4.Location = new Point(8, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(287, 351);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rectangle";
            // 
            // FindRectangleButton
            // 
            FindRectangleButton.Location = new Point(146, 303);
            FindRectangleButton.Name = "FindRectangleButton";
            FindRectangleButton.Size = new Size(75, 23);
            FindRectangleButton.TabIndex = 7;
            FindRectangleButton.Text = "Find";
            FindRectangleButton.UseVisualStyleBackColor = true;
            FindRectangleButton.Click += FindRectangleButton_Click;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(146, 134);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(39, 15);
            ColorLabel.TabIndex = 6;
            ColorLabel.Text = "Color:";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(146, 152);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(100, 23);
            ColorTextBox.TabIndex = 5;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(146, 78);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(42, 15);
            WidthLabel.TabIndex = 4;
            WidthLabel.Text = "Width:";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(146, 96);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(100, 23);
            WidthTextBox.TabIndex = 3;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(146, 22);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(47, 15);
            LengthLabel.TabIndex = 2;
            LengthLabel.Text = "Length:";
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(146, 40);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(100, 23);
            LengthTextBox.TabIndex = 1;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(6, 22);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(120, 304);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            Enums.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Enums;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label IntValuelabel;
        private TextBox IntValueTextBox;
        private Label ChooseValuelabel;
        private Label ChooseEnumLabel;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private GroupBox groupBox3;
        private Button GoSeasonButton;
        private Label IsitWeekday;
        private Button WeekdayParseButton;
        private TextBox WeekdayTextBox;
        private ComboBox SeasonComboBox;
        private TabPage tabPage2;
        private GroupBox groupBox4;
        private Button FindRectangleButton;
        private Label ColorLabel;
        private TextBox ColorTextBox;
        private Label WidthLabel;
        private TextBox WidthTextBox;
        private Label LengthLabel;
        private TextBox LengthTextBox;
        private ListBox RectanglesListBox;
        private GroupBox groupBox5;
        private Button FindMovieButton;
        private Label DurationLabel;
        private TextBox DurationTextBox;
        private Label GenreLabel;
        private TextBox GenreTextBox;
        private Label NameLabel;
        private TextBox NameTextBox;
        private ListBox MoviesListBox;
        private Label YearLabel;
        private TextBox YearTextBox;
        private Label RatingLabel;
        private TextBox RatingTextBox;
    }
}
