namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            CustomersGroupBox = new GroupBox();
            RemoveCustomerButton = new Button();
            AdddefaultCutomerButton = new Button();
            CustomersListBox = new ListBox();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            SelectedCustomerGroupBox = new GroupBox();
            AddressTextBox = new TextBox();
            FullnameTextBox = new TextBox();
            IDTextBox = new TextBox();
            label1 = new Label();
            FullnameLabel = new Label();
            IDLabel = new Label();
            Panel = new Panel();
            AddRandomCustomerButton = new Button();
            CustomersGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersGroupBox.Controls.Add(AddRandomCustomerButton);
            CustomersGroupBox.Controls.Add(RemoveCustomerButton);
            CustomersGroupBox.Controls.Add(AdddefaultCutomerButton);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Controls.Add(RemoveItemButton);
            CustomersGroupBox.Controls.Add(AddItemButton);
            CustomersGroupBox.Location = new Point(3, 3);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(249, 522);
            CustomersGroupBox.TabIndex = 1;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveCustomerButton.Location = new Point(87, 467);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Size = new Size(75, 49);
            RemoveCustomerButton.TabIndex = 4;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            // 
            // AdddefaultCutomerButton
            // 
            AdddefaultCutomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AdddefaultCutomerButton.Location = new Point(6, 467);
            AdddefaultCutomerButton.Name = "AdddefaultCutomerButton";
            AdddefaultCutomerButton.Size = new Size(75, 49);
            AdddefaultCutomerButton.TabIndex = 0;
            AdddefaultCutomerButton.Text = "Add (default)";
            AdddefaultCutomerButton.UseVisualStyleBackColor = true;
            AdddefaultCutomerButton.Click += AddCutomerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(6, 22);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(237, 439);
            CustomersListBox.TabIndex = 3;
            CustomersListBox.SelectedIndexChanged += CustomerListBox_SelectedIndexChanged;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.Location = new Point(87, 889);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(75, 49);
            RemoveItemButton.TabIndex = 2;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(6, 889);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(75, 49);
            AddItemButton.TabIndex = 1;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerGroupBox.Controls.Add(AddressTextBox);
            SelectedCustomerGroupBox.Controls.Add(FullnameTextBox);
            SelectedCustomerGroupBox.Controls.Add(IDTextBox);
            SelectedCustomerGroupBox.Controls.Add(label1);
            SelectedCustomerGroupBox.Controls.Add(FullnameLabel);
            SelectedCustomerGroupBox.Controls.Add(IDLabel);
            SelectedCustomerGroupBox.Location = new Point(258, 3);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(570, 217);
            SelectedCustomerGroupBox.TabIndex = 2;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(76, 94);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(488, 117);
            AddressTextBox.TabIndex = 5;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // FullnameTextBox
            // 
            FullnameTextBox.Location = new Point(76, 60);
            FullnameTextBox.Name = "FullnameTextBox";
            FullnameTextBox.Size = new Size(145, 23);
            FullnameTextBox.TabIndex = 4;
            FullnameTextBox.TextChanged += FullnameTextBox_TextChanged;
            FullnameTextBox.Leave += FullnameTextBox_Leave;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(76, 29);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(145, 23);
            IDTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 97);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Address:";
            // 
            // FullnameLabel
            // 
            FullnameLabel.AutoSize = true;
            FullnameLabel.Location = new Point(6, 63);
            FullnameLabel.Name = "FullnameLabel";
            FullnameLabel.Size = new Size(59, 15);
            FullnameLabel.TabIndex = 1;
            FullnameLabel.Text = "Fullname:";
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
            // Panel
            // 
            Panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel.Location = new Point(258, 226);
            Panel.Name = "Panel";
            Panel.Size = new Size(570, 299);
            Panel.TabIndex = 3;
            // 
            // AddRandomCustomerButton
            // 
            AddRandomCustomerButton.Location = new Point(168, 467);
            AddRandomCustomerButton.Name = "AddRandomCustomerButton";
            AddRandomCustomerButton.Size = new Size(75, 49);
            AddRandomCustomerButton.TabIndex = 0;
            AddRandomCustomerButton.Text = "Add (random)";
            AddRandomCustomerButton.UseVisualStyleBackColor = true;
            AddRandomCustomerButton.Click += AddRandomCustomerButton_Click;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel);
            Controls.Add(SelectedCustomerGroupBox);
            Controls.Add(CustomersGroupBox);
            Name = "CustomersTab";
            Size = new Size(831, 528);
            CustomersGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomersGroupBox;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private GroupBox SelectedCustomerGroupBox;
        private ListBox CustomersListBox;
        private Button RemoveCustomerButton;
        private Button AdddefaultCutomerButton;
        private Label IDLabel;
        private Label FullnameLabel;
        private Label label1;
        private TextBox IDTextBox;
        private TextBox AddressTextBox;
        private TextBox FullnameTextBox;
        private Panel Panel;
        private Button AddRandomCustomerButton;
    }
}
