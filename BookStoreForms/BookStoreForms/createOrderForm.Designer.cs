namespace BookStoreForms
{
    partial class createOrderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createOrderForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.chooseDeliveryCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.choosePostCompanyLabel = new System.Windows.Forms.Label();
            this.finishCreateOrderButton = new System.Windows.Forms.Button();
            this.postOfficeNumberTextBox = new System.Windows.Forms.TextBox();
            this.postNumberLabel = new System.Windows.Forms.Label();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.deliveryArddressLabel = new System.Windows.Forms.Label();
            this.chooseDeliveryComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.deliveryDetailsLabel = new System.Windows.Forms.Label();
            this.customerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.contactDetailsLabel = new System.Windows.Forms.Label();
            this.checkoutLabel = new System.Windows.Forms.Label();
            this.bookStoreLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPanel.Controls.Add(this.chooseDeliveryCompanyComboBox);
            this.mainPanel.Controls.Add(this.choosePostCompanyLabel);
            this.mainPanel.Controls.Add(this.finishCreateOrderButton);
            this.mainPanel.Controls.Add(this.postOfficeNumberTextBox);
            this.mainPanel.Controls.Add(this.postNumberLabel);
            this.mainPanel.Controls.Add(this.deliveryAddressTextBox);
            this.mainPanel.Controls.Add(this.deliveryArddressLabel);
            this.mainPanel.Controls.Add(this.chooseDeliveryComboBox);
            this.mainPanel.Controls.Add(this.deliveryLabel);
            this.mainPanel.Controls.Add(this.deliveryDetailsLabel);
            this.mainPanel.Controls.Add(this.customerPhoneNumberTextBox);
            this.mainPanel.Controls.Add(this.phoneNumberLabel);
            this.mainPanel.Controls.Add(this.customerNameTextBox);
            this.mainPanel.Controls.Add(this.customerNameLabel);
            this.mainPanel.Controls.Add(this.contactDetailsLabel);
            this.mainPanel.Controls.Add(this.checkoutLabel);
            this.mainPanel.Controls.Add(this.bookStoreLabel);
            this.mainPanel.Location = new System.Drawing.Point(125, 62);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(821, 619);
            this.mainPanel.TabIndex = 1;
            // 
            // chooseDeliveryCompanyComboBox
            // 
            this.chooseDeliveryCompanyComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chooseDeliveryCompanyComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseDeliveryCompanyComboBox.FormattingEnabled = true;
            this.chooseDeliveryCompanyComboBox.Items.AddRange(new object[] {
            "Choose delivery company...",
            "Nova poshta",
            "Ukrposhta"});
            this.chooseDeliveryCompanyComboBox.Location = new System.Drawing.Point(284, 362);
            this.chooseDeliveryCompanyComboBox.Name = "chooseDeliveryCompanyComboBox";
            this.chooseDeliveryCompanyComboBox.Size = new System.Drawing.Size(270, 36);
            this.chooseDeliveryCompanyComboBox.TabIndex = 17;
            // 
            // choosePostCompanyLabel
            // 
            this.choosePostCompanyLabel.AutoSize = true;
            this.choosePostCompanyLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choosePostCompanyLabel.Location = new System.Drawing.Point(40, 358);
            this.choosePostCompanyLabel.Name = "choosePostCompanyLabel";
            this.choosePostCompanyLabel.Size = new System.Drawing.Size(245, 38);
            this.choosePostCompanyLabel.TabIndex = 16;
            this.choosePostCompanyLabel.Text = "Delivery company:";
            // 
            // finishCreateOrderButton
            // 
            this.finishCreateOrderButton.BackColor = System.Drawing.Color.ForestGreen;
            this.finishCreateOrderButton.ForeColor = System.Drawing.Color.White;
            this.finishCreateOrderButton.Location = new System.Drawing.Point(41, 525);
            this.finishCreateOrderButton.Name = "finishCreateOrderButton";
            this.finishCreateOrderButton.Size = new System.Drawing.Size(139, 44);
            this.finishCreateOrderButton.TabIndex = 15;
            this.finishCreateOrderButton.Text = "Create";
            this.finishCreateOrderButton.UseVisualStyleBackColor = false;
            this.finishCreateOrderButton.Click += new System.EventHandler(this.finishCreateOrderButton_Click);
            // 
            // postOfficeNumberTextBox
            // 
            this.postOfficeNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postOfficeNumberTextBox.Location = new System.Drawing.Point(295, 468);
            this.postOfficeNumberTextBox.Name = "postOfficeNumberTextBox";
            this.postOfficeNumberTextBox.Size = new System.Drawing.Size(218, 38);
            this.postOfficeNumberTextBox.TabIndex = 13;
            // 
            // postNumberLabel
            // 
            this.postNumberLabel.AutoSize = true;
            this.postNumberLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postNumberLabel.Location = new System.Drawing.Point(32, 468);
            this.postNumberLabel.Name = "postNumberLabel";
            this.postNumberLabel.Size = new System.Drawing.Size(257, 38);
            this.postNumberLabel.TabIndex = 12;
            this.postNumberLabel.Text = "Post office number:";
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(170, 470);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(218, 38);
            this.deliveryAddressTextBox.TabIndex = 11;
            // 
            // deliveryArddressLabel
            // 
            this.deliveryArddressLabel.AutoSize = true;
            this.deliveryArddressLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deliveryArddressLabel.Location = new System.Drawing.Point(42, 468);
            this.deliveryArddressLabel.Name = "deliveryArddressLabel";
            this.deliveryArddressLabel.Size = new System.Drawing.Size(122, 38);
            this.deliveryArddressLabel.TabIndex = 10;
            this.deliveryArddressLabel.Text = "Address:";
            // 
            // chooseDeliveryComboBox
            // 
            this.chooseDeliveryComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chooseDeliveryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseDeliveryComboBox.FormattingEnabled = true;
            this.chooseDeliveryComboBox.Items.AddRange(new object[] {
            "Choose delivery...",
            "To the post office",
            "By currier"});
            this.chooseDeliveryComboBox.Location = new System.Drawing.Point(284, 413);
            this.chooseDeliveryComboBox.Name = "chooseDeliveryComboBox";
            this.chooseDeliveryComboBox.Size = new System.Drawing.Size(270, 36);
            this.chooseDeliveryComboBox.TabIndex = 9;
            this.chooseDeliveryComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseDeliveryComboBox_SelectedIndexChanged);
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deliveryLabel.Location = new System.Drawing.Point(40, 413);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(124, 38);
            this.deliveryLabel.TabIndex = 8;
            this.deliveryLabel.Text = "Delivery:";
            // 
            // deliveryDetailsLabel
            // 
            this.deliveryDetailsLabel.AutoSize = true;
            this.deliveryDetailsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deliveryDetailsLabel.Location = new System.Drawing.Point(39, 302);
            this.deliveryDetailsLabel.Name = "deliveryDetailsLabel";
            this.deliveryDetailsLabel.Size = new System.Drawing.Size(235, 41);
            this.deliveryDetailsLabel.TabIndex = 7;
            this.deliveryDetailsLabel.Text = "Delivery details:";
            // 
            // customerPhoneNumberTextBox
            // 
            this.customerPhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerPhoneNumberTextBox.Location = new System.Drawing.Point(252, 240);
            this.customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            this.customerPhoneNumberTextBox.Size = new System.Drawing.Size(209, 38);
            this.customerPhoneNumberTextBox.TabIndex = 6;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberLabel.Location = new System.Drawing.Point(39, 238);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(207, 38);
            this.phoneNumberLabel.TabIndex = 5;
            this.phoneNumberLabel.Text = "Phone number:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerNameTextBox.Location = new System.Drawing.Point(252, 187);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(209, 38);
            this.customerNameTextBox.TabIndex = 4;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerNameLabel.Location = new System.Drawing.Point(39, 187);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(97, 38);
            this.customerNameLabel.TabIndex = 3;
            this.customerNameLabel.Text = "Name:";
            // 
            // contactDetailsLabel
            // 
            this.contactDetailsLabel.AutoSize = true;
            this.contactDetailsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactDetailsLabel.Location = new System.Drawing.Point(39, 125);
            this.contactDetailsLabel.Name = "contactDetailsLabel";
            this.contactDetailsLabel.Size = new System.Drawing.Size(294, 41);
            this.contactDetailsLabel.TabIndex = 2;
            this.contactDetailsLabel.Text = "Your contact details:";
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.AutoSize = true;
            this.checkoutLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkoutLabel.Location = new System.Drawing.Point(39, 75);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(184, 50);
            this.checkoutLabel.TabIndex = 1;
            this.checkoutLabel.Text = "Checkout";
            // 
            // bookStoreLabel
            // 
            this.bookStoreLabel.AutoSize = true;
            this.bookStoreLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookStoreLabel.Location = new System.Drawing.Point(284, 10);
            this.bookStoreLabel.Name = "bookStoreLabel";
            this.bookStoreLabel.Size = new System.Drawing.Size(229, 54);
            this.bookStoreLabel.TabIndex = 0;
            this.bookStoreLabel.Text = "Book Store";
            // 
            // createOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 742);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "createOrderForm";
            this.Text = "createOrderForm";
            this.Activated += new System.EventHandler(this.createOrderForm_Activated);
            this.Load += new System.EventHandler(this.createOrderForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private Label deliveryLabel;
        private Label deliveryDetailsLabel;
        private TextBox customerPhoneNumberTextBox;
        private Label phoneNumberLabel;
        private TextBox customerNameTextBox;
        private Label customerNameLabel;
        private Label contactDetailsLabel;
        private Label checkoutLabel;
        private Label bookStoreLabel;
        private ComboBox chooseDeliveryComboBox;
        private TextBox deliveryAddressTextBox;
        private Label deliveryArddressLabel;
        private TextBox postOfficeNumberTextBox;
        private Label postNumberLabel;
        private Button finishCreateOrderButton;
        private ComboBox chooseDeliveryCompanyComboBox;
        private Label choosePostCompanyLabel;
    }
}