namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            SuspendLayout();
            // 
            // CanvasPanel
            // 
            CanvasPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvasPanel.Location = new Point(296, 20);
            CanvasPanel.Name = "CanvasPanel";
            CanvasPanel.Size = new Size(500, 401);
            CanvasPanel.TabIndex = 31;
            // 
            // DrawLengthLabel
            // 
            DrawLengthLabel.AutoSize = true;
            DrawLengthLabel.Location = new Point(40, 390);
            DrawLengthLabel.Name = "DrawLengthLabel";
            DrawLengthLabel.Size = new Size(46, 15);
            DrawLengthLabel.TabIndex = 30;
            DrawLengthLabel.Text = "Height:";
            // 
            // DrawWidthLabel
            // 
            DrawWidthLabel.AutoSize = true;
            DrawWidthLabel.Location = new Point(45, 359);
            DrawWidthLabel.Name = "DrawWidthLabel";
            DrawWidthLabel.Size = new Size(42, 15);
            DrawWidthLabel.TabIndex = 29;
            DrawWidthLabel.Text = "Width:";
            // 
            // DrawYLabel
            // 
            DrawYLabel.AutoSize = true;
            DrawYLabel.Location = new Point(70, 328);
            DrawYLabel.Name = "DrawYLabel";
            DrawYLabel.Size = new Size(17, 15);
            DrawYLabel.TabIndex = 28;
            DrawYLabel.Text = "Y:";
            // 
            // DrawXLabel
            // 
            DrawXLabel.AutoSize = true;
            DrawXLabel.Location = new Point(70, 297);
            DrawXLabel.Name = "DrawXLabel";
            DrawXLabel.Size = new Size(17, 15);
            DrawXLabel.TabIndex = 27;
            DrawXLabel.Text = "X:";
            // 
            // DrawIdLabel
            // 
            DrawIdLabel.AutoSize = true;
            DrawIdLabel.Location = new Point(67, 266);
            DrawIdLabel.Name = "DrawIdLabel";
            DrawIdLabel.Size = new Size(20, 15);
            DrawIdLabel.TabIndex = 26;
            DrawIdLabel.Text = "Id:";
            // 
            // DrawLengthTextBox
            // 
            DrawLengthTextBox.Location = new Point(94, 387);
            DrawLengthTextBox.Name = "DrawLengthTextBox";
            DrawLengthTextBox.Size = new Size(100, 23);
            DrawLengthTextBox.TabIndex = 25;
            DrawLengthTextBox.TextChanged += DrawLengthTextBox_TextChanged;
            // 
            // DrawWidthTextBox
            // 
            DrawWidthTextBox.Location = new Point(94, 356);
            DrawWidthTextBox.Name = "DrawWidthTextBox";
            DrawWidthTextBox.Size = new Size(100, 23);
            DrawWidthTextBox.TabIndex = 24;
            DrawWidthTextBox.TextChanged += DrawWidthTextBox_TextChanged;
            // 
            // DrawYTextBox
            // 
            DrawYTextBox.Location = new Point(94, 325);
            DrawYTextBox.Name = "DrawYTextBox";
            DrawYTextBox.Size = new Size(100, 23);
            DrawYTextBox.TabIndex = 23;
            DrawYTextBox.TextChanged += DrawYTextBox_TextChanged;
            // 
            // DrawXTextBox
            // 
            DrawXTextBox.Location = new Point(94, 294);
            DrawXTextBox.Name = "DrawXTextBox";
            DrawXTextBox.Size = new Size(100, 23);
            DrawXTextBox.TabIndex = 22;
            DrawXTextBox.TextChanged += DrawXTextBox_TextChanged;
            // 
            // DrawIdTextBox
            // 
            DrawIdTextBox.Location = new Point(94, 263);
            DrawIdTextBox.Name = "DrawIdTextBox";
            DrawIdTextBox.ReadOnly = true;
            DrawIdTextBox.Size = new Size(100, 23);
            DrawIdTextBox.TabIndex = 21;
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(20, 245);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(106, 15);
            SelectedRectangleLabel.TabIndex = 20;
            SelectedRectangleLabel.Text = "SelectedRectangle:";
            // 
            // DeletRectangleButton
            // 
            DeletRectangleButton.FlatStyle = FlatStyle.System;
            DeletRectangleButton.Location = new Point(171, 198);
            DeletRectangleButton.Name = "DeletRectangleButton";
            DeletRectangleButton.Size = new Size(75, 23);
            DeletRectangleButton.TabIndex = 19;
            DeletRectangleButton.Text = "Delet";
            DeletRectangleButton.UseVisualStyleBackColor = true;
            DeletRectangleButton.Click += DeletRectangleButton_Click;
            // 
            // AddRectengleButton
            // 
            AddRectengleButton.FlatStyle = FlatStyle.System;
            AddRectengleButton.Location = new Point(44, 198);
            AddRectengleButton.Name = "AddRectengleButton";
            AddRectengleButton.Size = new Size(75, 23);
            AddRectengleButton.TabIndex = 18;
            AddRectengleButton.Text = "Add";
            AddRectengleButton.UseVisualStyleBackColor = true;
            AddRectengleButton.Click += AddRectengleButton_Click;
            // 
            // DrawRectangleLabel
            // 
            DrawRectangleLabel.AutoSize = true;
            DrawRectangleLabel.Location = new Point(20, 20);
            DrawRectangleLabel.Name = "DrawRectangleLabel";
            DrawRectangleLabel.Size = new Size(67, 15);
            DrawRectangleLabel.TabIndex = 17;
            DrawRectangleLabel.Text = "Rectangles:";
            // 
            // DrawRectanglesListBox
            // 
            DrawRectanglesListBox.FormattingEnabled = true;
            DrawRectanglesListBox.ItemHeight = 15;
            DrawRectanglesListBox.Location = new Point(20, 38);
            DrawRectanglesListBox.Name = "DrawRectanglesListBox";
            DrawRectanglesListBox.Size = new Size(257, 154);
            DrawRectanglesListBox.TabIndex = 16;
            DrawRectanglesListBox.SelectedIndexChanged += DrawRectanglesListBox_SelectedIndexChanged;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CanvasPanel);
            Controls.Add(DrawLengthLabel);
            Controls.Add(DrawWidthLabel);
            Controls.Add(DrawYLabel);
            Controls.Add(DrawXLabel);
            Controls.Add(DrawIdLabel);
            Controls.Add(DrawLengthTextBox);
            Controls.Add(DrawWidthTextBox);
            Controls.Add(DrawYTextBox);
            Controls.Add(DrawXTextBox);
            Controls.Add(DrawIdTextBox);
            Controls.Add(SelectedRectangleLabel);
            Controls.Add(DeletRectangleButton);
            Controls.Add(AddRectengleButton);
            Controls.Add(DrawRectangleLabel);
            Controls.Add(DrawRectanglesListBox);
            Name = "RectanglesCollisionControl";
            Size = new Size(816, 440);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel CanvasPanel;
        private Label DrawLengthLabel;
        private Label DrawWidthLabel;
        private Label DrawYLabel;
        private Label DrawXLabel;
        private Label DrawIdLabel;
        private TextBox DrawLengthTextBox;
        private TextBox DrawWidthTextBox;
        private TextBox DrawYTextBox;
        private TextBox DrawXTextBox;
        private TextBox DrawIdTextBox;
        private Label SelectedRectangleLabel;
        private Button DeletRectangleButton;
        private Button AddRectengleButton;
        private Label DrawRectangleLabel;
        private ListBox DrawRectanglesListBox;
    }
}
