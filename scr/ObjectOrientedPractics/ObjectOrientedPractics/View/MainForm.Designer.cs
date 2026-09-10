using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics
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
            Items = new TabPage();
            Customers = new TabPage();
            itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            tabControl1.SuspendLayout();
            Items.SuspendLayout();
            Customers.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Items);
            tabControl1.Controls.Add(Customers);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(846, 562);
            tabControl1.TabIndex = 0;
            // 
            // Items
            // 
            Items.Controls.Add(itemsTab1);
            Items.Location = new Point(4, 24);
            Items.Name = "Items";
            Items.Padding = new Padding(3);
            Items.Size = new Size(838, 534);
            Items.TabIndex = 0;
            Items.Text = "Items";
            Items.UseVisualStyleBackColor = true;
            // 
            // Customers
            // 
            Customers.Controls.Add(customersTab1);
            Customers.Location = new Point(4, 24);
            Customers.Name = "Customers";
            Customers.Padding = new Padding(3);
            Customers.Size = new Size(838, 534);
            Customers.TabIndex = 1;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(831, 528);
            itemsTab1.TabIndex = 0;
            // 
            // customersTab1
            // 
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(831, 528);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 562);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            FormClosing += MainForm_FormClosing;
            tabControl1.ResumeLayout(false);
            Items.ResumeLayout(false);
            Customers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Items;
        private TabPage Customers;
        private View.Tabs.ItemsTab itemsTab1;
        private View.Tabs.CustomersTab customersTab1;
    }
}
