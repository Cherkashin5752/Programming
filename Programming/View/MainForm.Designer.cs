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
            tabPage1 = new TabPage();
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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
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
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Location = new Point(6, 37);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(133, 214);
            EnumsListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
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
    }
}
