namespace Programming.View.Panels
{
    partial class RectenglesControl
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
            groupBox4.SuspendLayout();
            SuspendLayout();
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
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(287, 411);
            groupBox4.TabIndex = 1;
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
            // RectenglesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Name = "RectenglesControl";
            Size = new Size(426, 495);
            Load += RectenglesControl_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Label IdLabel;
        private TextBox IdTextBox;
        private Label CenterYLabel;
        private Label CenterXLabel;
        private TextBox CenterYTextBox;
        private TextBox CenterXTextBox;
        private Button FindRectangleButton;
        private Label ColorLabel;
        private TextBox ColorTextBox;
        private Label WidthLabel;
        private TextBox WidthTextBox;
        private Label LengthLabel;
        private TextBox LengthTextBox;
        private ListBox RectanglesListBox;
    }
}
