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
            Classes = new TabPage();
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
            IdLabel = new Label();
            IdTextBox = new TextBox();
            CenterYLabel = new Label();
            CenterXLabel = new Label();
            CenterYTextBox = new TextBox();
            CenterXTextBox = new TextBox();
            FindRectangleButton = new Button();
            ColorLabel = new Label();
            ColorTextBox = new TextBox();
            WidthLabel = new Label();
            WidthTextBox = new TextBox();
            LengthLabel = new Label();
            LengthTextBox = new TextBox();
            RectanglesListBox = new ListBox();
            Rectangles = new TabPage();
            CanvasPanel = new Panel();
            DrawLengthLabel = new Label();
            DrawWidthLabel = new Label();
            DrawYLabel = new Label();
            DrawXLabel = new Label();
            DrawIdLabel = new Label();
            DrawLengthTextBox = new TextBox();
            DrawWidthTextBox = new TextBox();
            DrawYTextBox = new TextBox();
            DrawXTextBox = new TextBox();
            DrawIdTextBox = new TextBox();
            SelectedRectangleLabel = new Label();
            DeletRectangleButton = new Button();
            AddRectengleButton = new Button();
            DrawRectangleLabel = new Label();
            DrawRectanglesListBox = new ListBox();
            tabControl1.SuspendLayout();
            Enums.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            Classes.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            Rectangles.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Enums);
            tabControl1.Controls.Add(Classes);
            tabControl1.Controls.Add(Rectangles);
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
            // Classes
            // 
            Classes.Controls.Add(groupBox5);
            Classes.Controls.Add(groupBox4);
            Classes.Location = new Point(4, 24);
            Classes.Name = "Classes";
            Classes.Size = new Size(792, 422);
            Classes.TabIndex = 1;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
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
            groupBox5.Size = new Size(287, 411);
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
            FindMovieButton.Location = new Point(146, 363);
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
            MoviesListBox.Size = new Size(120, 364);
            MoviesListBox.TabIndex = 0;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(IdLabel);
            groupBox4.Controls.Add(IdTextBox);
            groupBox4.Controls.Add(CenterYLabel);
            groupBox4.Controls.Add(CenterXLabel);
            groupBox4.Controls.Add(CenterYTextBox);
            groupBox4.Controls.Add(CenterXTextBox);
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
            groupBox4.Size = new Size(287, 411);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rectangle";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(146, 282);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(20, 15);
            IdLabel.TabIndex = 13;
            IdLabel.Text = "Id:";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(146, 304);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(100, 23);
            IdTextBox.TabIndex = 12;
            // 
            // CenterYLabel
            // 
            CenterYLabel.AutoSize = true;
            CenterYLabel.Location = new Point(146, 178);
            CenterYLabel.Name = "CenterYLabel";
            CenterYLabel.Size = new Size(55, 15);
            CenterYLabel.TabIndex = 11;
            CenterYLabel.Text = "Center Y:";
            // 
            // CenterXLabel
            // 
            CenterXLabel.AutoSize = true;
            CenterXLabel.Location = new Point(146, 230);
            CenterXLabel.Name = "CenterXLabel";
            CenterXLabel.Size = new Size(55, 15);
            CenterXLabel.TabIndex = 9;
            CenterXLabel.Text = "Center X:";
            // 
            // CenterYTextBox
            // 
            CenterYTextBox.Location = new Point(146, 196);
            CenterYTextBox.Name = "CenterYTextBox";
            CenterYTextBox.ReadOnly = true;
            CenterYTextBox.Size = new Size(100, 23);
            CenterYTextBox.TabIndex = 10;
            // 
            // CenterXTextBox
            // 
            CenterXTextBox.Location = new Point(146, 248);
            CenterXTextBox.Name = "CenterXTextBox";
            CenterXTextBox.ReadOnly = true;
            CenterXTextBox.Size = new Size(100, 23);
            CenterXTextBox.TabIndex = 8;
            // 
            // FindRectangleButton
            // 
            FindRectangleButton.Location = new Point(146, 363);
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
            ColorLabel.Location = new Point(146, 126);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(39, 15);
            ColorLabel.TabIndex = 6;
            ColorLabel.Text = "Color:";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(146, 144);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(100, 23);
            ColorTextBox.TabIndex = 5;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(146, 74);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(42, 15);
            WidthLabel.TabIndex = 4;
            WidthLabel.Text = "Width:";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(146, 92);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.ReadOnly = true;
            WidthTextBox.Size = new Size(100, 23);
            WidthTextBox.TabIndex = 3;
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
            LengthTextBox.ReadOnly = true;
            LengthTextBox.Size = new Size(100, 23);
            LengthTextBox.TabIndex = 1;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(6, 22);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(120, 364);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // Rectangles
            // 
            Rectangles.Controls.Add(CanvasPanel);
            Rectangles.Controls.Add(DrawLengthLabel);
            Rectangles.Controls.Add(DrawWidthLabel);
            Rectangles.Controls.Add(DrawYLabel);
            Rectangles.Controls.Add(DrawXLabel);
            Rectangles.Controls.Add(DrawIdLabel);
            Rectangles.Controls.Add(DrawLengthTextBox);
            Rectangles.Controls.Add(DrawWidthTextBox);
            Rectangles.Controls.Add(DrawYTextBox);
            Rectangles.Controls.Add(DrawXTextBox);
            Rectangles.Controls.Add(DrawIdTextBox);
            Rectangles.Controls.Add(SelectedRectangleLabel);
            Rectangles.Controls.Add(DeletRectangleButton);
            Rectangles.Controls.Add(AddRectengleButton);
            Rectangles.Controls.Add(DrawRectangleLabel);
            Rectangles.Controls.Add(DrawRectanglesListBox);
            Rectangles.Location = new Point(4, 24);
            Rectangles.Name = "Rectangles";
            Rectangles.Padding = new Padding(3);
            Rectangles.Size = new Size(792, 422);
            Rectangles.TabIndex = 2;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            // 
            // CanvasPanel
            // 
            CanvasPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvasPanel.Location = new Point(284, 13);
            CanvasPanel.Name = "CanvasPanel";
            CanvasPanel.Size = new Size(500, 401);
            CanvasPanel.TabIndex = 15;
            // 
            // DrawLengthLabel
            // 
            DrawLengthLabel.AutoSize = true;
            DrawLengthLabel.Location = new Point(28, 383);
            DrawLengthLabel.Name = "DrawLengthLabel";
            DrawLengthLabel.Size = new Size(46, 15);
            DrawLengthLabel.TabIndex = 14;
            DrawLengthLabel.Text = "Height:";
            // 
            // DrawWidthLabel
            // 
            DrawWidthLabel.AutoSize = true;
            DrawWidthLabel.Location = new Point(33, 352);
            DrawWidthLabel.Name = "DrawWidthLabel";
            DrawWidthLabel.Size = new Size(42, 15);
            DrawWidthLabel.TabIndex = 13;
            DrawWidthLabel.Text = "Width:";
            // 
            // DrawYLabel
            // 
            DrawYLabel.AutoSize = true;
            DrawYLabel.Location = new Point(58, 321);
            DrawYLabel.Name = "DrawYLabel";
            DrawYLabel.Size = new Size(17, 15);
            DrawYLabel.TabIndex = 12;
            DrawYLabel.Text = "Y:";
            // 
            // DrawXLabel
            // 
            DrawXLabel.AutoSize = true;
            DrawXLabel.Location = new Point(58, 290);
            DrawXLabel.Name = "DrawXLabel";
            DrawXLabel.Size = new Size(17, 15);
            DrawXLabel.TabIndex = 11;
            DrawXLabel.Text = "X:";
            // 
            // DrawIdLabel
            // 
            DrawIdLabel.AutoSize = true;
            DrawIdLabel.Location = new Point(55, 259);
            DrawIdLabel.Name = "DrawIdLabel";
            DrawIdLabel.Size = new Size(20, 15);
            DrawIdLabel.TabIndex = 10;
            DrawIdLabel.Text = "Id:";
            // 
            // DrawLengthTextBox
            // 
            DrawLengthTextBox.Location = new Point(82, 380);
            DrawLengthTextBox.Name = "DrawLengthTextBox";
            DrawLengthTextBox.Size = new Size(100, 23);
            DrawLengthTextBox.TabIndex = 9;
            DrawLengthTextBox.TextChanged += DrawLengthTextBox_TextChanged;
            // 
            // DrawWidthTextBox
            // 
            DrawWidthTextBox.Location = new Point(82, 349);
            DrawWidthTextBox.Name = "DrawWidthTextBox";
            DrawWidthTextBox.Size = new Size(100, 23);
            DrawWidthTextBox.TabIndex = 8;
            DrawWidthTextBox.TextChanged += DrawWidthTextBox_TextChanged;
            // 
            // DrawYTextBox
            // 
            DrawYTextBox.Location = new Point(82, 318);
            DrawYTextBox.Name = "DrawYTextBox";
            DrawYTextBox.Size = new Size(100, 23);
            DrawYTextBox.TabIndex = 7;
            DrawYTextBox.TextChanged += DrawYTextBox_TextChanged;
            // 
            // DrawXTextBox
            // 
            DrawXTextBox.Location = new Point(82, 287);
            DrawXTextBox.Name = "DrawXTextBox";
            DrawXTextBox.Size = new Size(100, 23);
            DrawXTextBox.TabIndex = 6;
            DrawXTextBox.TextChanged += DrawXTextBox_TextChanged;
            // 
            // DrawIdTextBox
            // 
            DrawIdTextBox.Location = new Point(82, 256);
            DrawIdTextBox.Name = "DrawIdTextBox";
            DrawIdTextBox.ReadOnly = true;
            DrawIdTextBox.Size = new Size(100, 23);
            DrawIdTextBox.TabIndex = 5;
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(8, 238);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(106, 15);
            SelectedRectangleLabel.TabIndex = 4;
            SelectedRectangleLabel.Text = "SelectedRectangle:";
            // 
            // DeletRectangleButton
            // 
            DeletRectangleButton.FlatStyle = FlatStyle.System;
            DeletRectangleButton.Location = new Point(159, 191);
            DeletRectangleButton.Name = "DeletRectangleButton";
            DeletRectangleButton.Size = new Size(75, 23);
            DeletRectangleButton.TabIndex = 3;
            DeletRectangleButton.Text = "Delet";
            DeletRectangleButton.UseVisualStyleBackColor = true;
            DeletRectangleButton.Click += DeletRectangleButton_Click;
            // 
            // AddRectengleButton
            // 
            AddRectengleButton.FlatStyle = FlatStyle.System;
            AddRectengleButton.Location = new Point(32, 191);
            AddRectengleButton.Name = "AddRectengleButton";
            AddRectengleButton.Size = new Size(75, 23);
            AddRectengleButton.TabIndex = 2;
            AddRectengleButton.Text = "Add";
            AddRectengleButton.UseVisualStyleBackColor = true;
            AddRectengleButton.Click += AddRectengleButton_Click;
            // 
            // DrawRectangleLabel
            // 
            DrawRectangleLabel.AutoSize = true;
            DrawRectangleLabel.Location = new Point(8, 13);
            DrawRectangleLabel.Name = "DrawRectangleLabel";
            DrawRectangleLabel.Size = new Size(67, 15);
            DrawRectangleLabel.TabIndex = 1;
            DrawRectangleLabel.Text = "Rectangles:";
            // 
            // DrawRectanglesListBox
            // 
            DrawRectanglesListBox.FormattingEnabled = true;
            DrawRectanglesListBox.ItemHeight = 15;
            DrawRectanglesListBox.Location = new Point(8, 31);
            DrawRectanglesListBox.Name = "DrawRectanglesListBox";
            DrawRectanglesListBox.Size = new Size(257, 154);
            DrawRectanglesListBox.TabIndex = 0;
            DrawRectanglesListBox.SelectedIndexChanged += DrawRectanglesListBox_SelectedIndexChanged;
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
            Classes.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            Rectangles.ResumeLayout(false);
            Rectangles.PerformLayout();
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
        private TabPage Classes;
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
        private Label CenterYLabel;
        private TextBox CenterYTextBox;
        private Label CenterXLabel;
        private TextBox CenterXTextBox;
        private Label IdLabel;
        private TextBox IdTextBox;
        private TabPage Rectangles;
        private Label DrawRectangleLabel;
        private ListBox DrawRectanglesListBox;
        private Button AddRectengleButton;
        private TextBox DrawIdTextBox;
        private Label SelectedRectangleLabel;
        private Button DeletRectangleButton;
        private Label DrawLengthLabel;
        private Label DrawWidthLabel;
        private Label DrawYLabel;
        private Label DrawXLabel;
        private Label DrawIdLabel;
        private TextBox DrawLengthTextBox;
        private TextBox DrawWidthTextBox;
        private TextBox DrawYTextBox;
        private TextBox DrawXTextBox;
        private Panel CanvasPanel;
    }
}
