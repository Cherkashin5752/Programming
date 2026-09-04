namespace Programming.View.Panels
{
    partial class MoviesControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            groupBox5.SuspendLayout();
            SuspendLayout();
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
            groupBox5.Location = new Point(3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(287, 411);
            groupBox5.TabIndex = 9;
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
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox5);
            Name = "MoviesControl";
            Size = new Size(389, 419);
            Load += MoviesControl_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox5;
        private Label YearLabel;
        private TextBox YearTextBox;
        private Label RatingLabel;
        private TextBox RatingTextBox;
        private Button FindMovieButton;
        private Label DurationLabel;
        private TextBox DurationTextBox;
        private Label GenreLabel;
        private TextBox GenreTextBox;
        private Label NameLabel;
        private TextBox NameTextBox;
        private ListBox MoviesListBox;
    }
}
