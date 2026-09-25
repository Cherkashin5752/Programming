namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            DeliveryAddressLabel = new Label();
            PostIndexLabel = new Label();
            CountryLabel = new Label();
            StreetLabel = new Label();
            BuildingLabel = new Label();
            PostIndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            StreetTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            CityTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            CityLabel = new Label();
            ApartmentLabel = new Label();
            SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            DeliveryAddressLabel.AutoSize = true;
            DeliveryAddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeliveryAddressLabel.Location = new Point(5, 6);
            DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            DeliveryAddressLabel.Size = new Size(101, 15);
            DeliveryAddressLabel.TabIndex = 0;
            DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Location = new Point(5, 31);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(64, 15);
            PostIndexLabel.TabIndex = 1;
            PostIndexLabel.Text = "Post Index:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(5, 64);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(53, 15);
            CountryLabel.TabIndex = 2;
            CountryLabel.Text = "Country:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(5, 97);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(40, 15);
            StreetLabel.TabIndex = 3;
            StreetLabel.Text = "Street:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(5, 130);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(54, 15);
            BuildingLabel.TabIndex = 4;
            BuildingLabel.Text = "Building:";
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Location = new Point(75, 28);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(130, 23);
            PostIndexTextBox.TabIndex = 5;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(75, 61);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(206, 23);
            CountryTextBox.TabIndex = 6;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(75, 94);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(482, 23);
            StreetTextBox.TabIndex = 7;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(75, 127);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(99, 23);
            BuildingTextBox.TabIndex = 8;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(357, 61);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(200, 23);
            CityTextBox.TabIndex = 9;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(274, 127);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(100, 23);
            ApartmentTextBox.TabIndex = 10;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(320, 64);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(31, 15);
            CityLabel.TabIndex = 11;
            CityLabel.Text = "City:";
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(201, 130);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(67, 15);
            ApartmentLabel.TabIndex = 12;
            ApartmentLabel.Text = "Apartment:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ApartmentLabel);
            Controls.Add(CityLabel);
            Controls.Add(ApartmentTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(BuildingTextBox);
            Controls.Add(StreetTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(PostIndexTextBox);
            Controls.Add(BuildingLabel);
            Controls.Add(StreetLabel);
            Controls.Add(CountryLabel);
            Controls.Add(PostIndexLabel);
            Controls.Add(DeliveryAddressLabel);
            ForeColor = SystemColors.ControlText;
            Name = "AddressControl";
            Size = new Size(570, 158);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DeliveryAddressLabel;
        private Label PostIndexLabel;
        private Label CountryLabel;
        private Label StreetLabel;
        private Label BuildingLabel;
        private TextBox PostIndexTextBox;
        private TextBox CountryTextBox;
        private TextBox StreetTextBox;
        private TextBox BuildingTextBox;
        private TextBox CityTextBox;
        private TextBox ApartmentTextBox;
        private Label CityLabel;
        private Label ApartmentLabel;
    }
}
