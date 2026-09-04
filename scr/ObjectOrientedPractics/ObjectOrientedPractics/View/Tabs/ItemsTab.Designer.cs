namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsGroupBox = new GroupBox();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            ItemsListBox = new ListBox();
            SelectedItemGroupBox = new GroupBox();
            DescriptionLabel = new Label();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            CostTextBox = new TextBox();
            IDTextBox = new TextBox();
            CostLabel = new Label();
            IDLabel = new Label();
            ItemsGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsGroupBox.Controls.Add(RemoveItemButton);
            ItemsGroupBox.Controls.Add(AddItemButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(249, 522);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.Location = new Point(87, 467);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(75, 49);
            RemoveItemButton.TabIndex = 2;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(6, 467);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(75, 49);
            AddItemButton.TabIndex = 1;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(6, 22);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(237, 439);
            ItemsListBox.TabIndex = 0;
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemGroupBox.Controls.Add(DescriptionLabel);
            SelectedItemGroupBox.Controls.Add(DescriptionTextBox);
            SelectedItemGroupBox.Controls.Add(NameTextBox);
            SelectedItemGroupBox.Controls.Add(NameLabel);
            SelectedItemGroupBox.Controls.Add(CostTextBox);
            SelectedItemGroupBox.Controls.Add(IDTextBox);
            SelectedItemGroupBox.Controls.Add(CostLabel);
            SelectedItemGroupBox.Controls.Add(IDLabel);
            SelectedItemGroupBox.Location = new Point(258, 6);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(570, 522);
            SelectedItemGroupBox.TabIndex = 1;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Item";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(6, 250);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(70, 15);
            DescriptionLabel.TabIndex = 7;
            DescriptionLabel.Text = "Description:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(6, 268);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(558, 190);
            DescriptionTextBox.TabIndex = 6;
            DescriptionTextBox.TextChanged += textBox2_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(6, 123);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(558, 108);
            NameTextBox.TabIndex = 5;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 105);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name:";
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(50, 60);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(145, 23);
            CostTextBox.TabIndex = 3;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(50, 26);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(145, 23);
            IDTextBox.TabIndex = 2;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(6, 63);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 1;
            CostLabel.Text = "Cost:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(6, 29);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(21, 15);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID:";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemGroupBox);
            Controls.Add(ItemsGroupBox);
            Name = "ItemsTab";
            Size = new Size(831, 528);
            ItemsGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsGroupBox;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private ListBox ItemsListBox;
        private GroupBox SelectedItemGroupBox;
        private TextBox CostTextBox;
        private TextBox IDTextBox;
        private Label CostLabel;
        private Label IDLabel;
        private Label NameLabel;
        private Label DescriptionLabel;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
    }
}
