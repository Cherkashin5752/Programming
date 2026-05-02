namespace NotesApp
{
    partial class Form1
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
            NotesList = new ListBox();
            groupBox1 = new GroupBox();
            labelType = new Label();
            labelDate = new Label();
            comboBoxType = new ComboBox();
            labelDescription = new Label();
            LabelName = new Label();
            textBoxDate = new TextBox();
            textBoxDescription = new TextBox();
            textBoxName = new TextBox();
            buttonCreate = new Button();
            buttonDelete = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // NotesList
            // 
            NotesList.FormattingEnabled = true;
            NotesList.ItemHeight = 15;
            NotesList.Location = new Point(12, 12);
            NotesList.Name = "NotesList";
            NotesList.Size = new Size(249, 424);
            NotesList.TabIndex = 0;
            NotesList.SelectedIndexChanged += NotesList_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelType);
            groupBox1.Controls.Add(labelDate);
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Controls.Add(labelDescription);
            groupBox1.Controls.Add(LabelName);
            groupBox1.Controls.Add(textBoxDate);
            groupBox1.Controls.Add(textBoxDescription);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Location = new Point(277, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 148);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Note";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(71, 112);
            labelType.Name = "labelType";
            labelType.Size = new Size(34, 15);
            labelType.TabIndex = 7;
            labelType.Text = "Type:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(11, 83);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(94, 15);
            labelDate.TabIndex = 6;
            labelDate.Text = "Date of creation:";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(111, 109);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(159, 23);
            comboBoxType.TabIndex = 5;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(35, 54);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(70, 15);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "Description:";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(63, 25);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(42, 15);
            LabelName.TabIndex = 2;
            LabelName.Text = "Name:";
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(111, 80);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.ReadOnly = true;
            textBoxDate.Size = new Size(159, 23);
            textBoxDate.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(111, 51);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(386, 23);
            textBoxDescription.TabIndex = 1;
            textBoxDescription.TextChanged += textBoxDescription_TextChanged;
            textBoxDescription.Leave += textBoxDescription_Leave;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(111, 22);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(386, 23);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.Leave += textBoxName_Leave;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(277, 166);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(82, 23);
            buttonCreate.TabIndex = 2;
            buttonCreate.Text = "New Note";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(378, 166);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(82, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete Note";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCreate);
            Controls.Add(groupBox1);
            Controls.Add(NotesList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox NotesList;
        private GroupBox groupBox1;
        private Label LabelName;
        private TextBox textBoxDate;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private Label labelType;
        private Label labelDate;
        private ComboBox comboBoxType;
        private Label labelDescription;
        private Button buttonCreate;
        private Button buttonDelete;
    }
}
