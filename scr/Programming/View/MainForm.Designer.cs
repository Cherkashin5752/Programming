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
            seasonHandlerControl1 = new Programming.View.Panels.SeasonHandlerControl();
            weekdayParseControl1 = new Programming.View.Panels.WeekdayParseControl();
            enumsControl1 = new Programming.View.Panels.EnumsControl();
            Classes = new TabPage();
            rectenglesControl1 = new Programming.View.Panels.RectenglesControl();
            tabPage1 = new TabPage();
            rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            moviesControl1 = new Programming.View.Panels.MoviesControl();
            tabControl1.SuspendLayout();
            Enums.SuspendLayout();
            Classes.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Enums);
            tabControl1.Controls.Add(Classes);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            Enums.Controls.Add(seasonHandlerControl1);
            Enums.Controls.Add(weekdayParseControl1);
            Enums.Controls.Add(enumsControl1);
            Enums.Location = new Point(4, 24);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(792, 422);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // seasonHandlerControl1
            // 
            seasonHandlerControl1.Location = new Point(400, 282);
            seasonHandlerControl1.Name = "seasonHandlerControl1";
            seasonHandlerControl1.Size = new Size(471, 137);
            seasonHandlerControl1.TabIndex = 6;
            // 
            // weekdayParseControl1
            // 
            weekdayParseControl1.Location = new Point(4, 282);
            weekdayParseControl1.Name = "weekdayParseControl1";
            weekdayParseControl1.Size = new Size(391, 136);
            weekdayParseControl1.TabIndex = 5;
            // 
            // enumsControl1
            // 
            enumsControl1.Location = new Point(3, 0);
            enumsControl1.Name = "enumsControl1";
            enumsControl1.Size = new Size(781, 283);
            enumsControl1.TabIndex = 4;
            // 
            // Classes
            // 
            Classes.Controls.Add(moviesControl1);
            Classes.Controls.Add(rectenglesControl1);
            Classes.Location = new Point(4, 24);
            Classes.Name = "Classes";
            Classes.Size = new Size(792, 422);
            Classes.TabIndex = 1;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
            // 
            // rectenglesControl1
            // 
            rectenglesControl1.Location = new Point(4, 0);
            rectenglesControl1.Name = "rectenglesControl1";
            rectenglesControl1.Size = new Size(308, 495);
            rectenglesControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(rectanglesCollisionControl1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Location = new Point(-12, -11);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(816, 440);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // moviesControl1
            // 
            moviesControl1.Location = new Point(303, 1);
            moviesControl1.Name = "moviesControl1";
            moviesControl1.Size = new Size(389, 419);
            moviesControl1.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Enums.ResumeLayout(false);
            Classes.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Enums;
        private TabPage Classes;
        private TabPage tabPage1;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.EnumsControl enumsControl1;
        private View.Panels.WeekdayParseControl weekdayParseControl1;
        private View.Panels.SeasonHandlerControl seasonHandlerControl1;
        private View.Panels.RectenglesControl rectenglesControl1;
        private View.Panels.MoviesControl moviesControl1;
    }
}
