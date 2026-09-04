namespace Programming.View.Panels
{
    partial class WeekdayParseControl
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
            groupBox2 = new GroupBox();
            IsitWeekday = new Label();
            WeekdayParseButton = new Button();
            WeekdayTextBox = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(IsitWeekday);
            groupBox2.Controls.Add(WeekdayParseButton);
            groupBox2.Controls.Add(WeekdayTextBox);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 130);
            groupBox2.TabIndex = 2;
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
            // WeekdayParseControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Name = "WeekdayParseControl";
            Size = new Size(386, 136);
            Load += WeekdayParseControl_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label IsitWeekday;
        private Button WeekdayParseButton;
        private TextBox WeekdayTextBox;
    }
}
