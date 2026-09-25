namespace Programming.View.Panels
{
    partial class SeasonHandlerControl
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
            groupBox3 = new GroupBox();
            SeasonComboBox = new ComboBox();
            GoSeasonButton = new Button();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(SeasonComboBox);
            groupBox3.Controls.Add(GoSeasonButton);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(379, 130);
            groupBox3.TabIndex = 4;
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
            // SeasonHandlerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Name = "SeasonHandlerControl";
            Size = new Size(471, 137);
            Load += SeasonHandlerControl_Load;
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private ComboBox SeasonComboBox;
        private Button GoSeasonButton;
    }
}
