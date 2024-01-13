namespace BookStoreForms
{
    partial class ordersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordersForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.goShopButton = new System.Windows.Forms.Button();
            this.myOrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.chooseDeliveryCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.chooseDeliveryComboBox = new System.Windows.Forms.ComboBox();
            this.orderstLabel = new System.Windows.Forms.Label();
            this.bookStoreLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myOrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPanel.Controls.Add(this.goShopButton);
            this.mainPanel.Controls.Add(this.myOrdersDataGridView);
            this.mainPanel.Controls.Add(this.chooseDeliveryCompanyComboBox);
            this.mainPanel.Controls.Add(this.chooseDeliveryComboBox);
            this.mainPanel.Controls.Add(this.orderstLabel);
            this.mainPanel.Controls.Add(this.bookStoreLabel);
            this.mainPanel.Location = new System.Drawing.Point(125, 62);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(821, 619);
            this.mainPanel.TabIndex = 2;
            // 
            // goShopButton
            // 
            this.goShopButton.BackColor = System.Drawing.Color.ForestGreen;
            this.goShopButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goShopButton.Location = new System.Drawing.Point(43, 566);
            this.goShopButton.Name = "goShopButton";
            this.goShopButton.Size = new System.Drawing.Size(105, 39);
            this.goShopButton.TabIndex = 19;
            this.goShopButton.Text = "go shop";
            this.goShopButton.UseVisualStyleBackColor = false;
            this.goShopButton.Click += new System.EventHandler(this.goShopButton_Click);
            // 
            // myOrdersDataGridView
            // 
            this.myOrdersDataGridView.AllowUserToAddRows = false;
            this.myOrdersDataGridView.AllowUserToDeleteRows = false;
            this.myOrdersDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.myOrdersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myOrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myOrdersDataGridView.Location = new System.Drawing.Point(55, 140);
            this.myOrdersDataGridView.Name = "myOrdersDataGridView";
            this.myOrdersDataGridView.ReadOnly = true;
            this.myOrdersDataGridView.RowHeadersWidth = 51;
            this.myOrdersDataGridView.RowTemplate.Height = 29;
            this.myOrdersDataGridView.Size = new System.Drawing.Size(528, 383);
            this.myOrdersDataGridView.TabIndex = 18;
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
            this.chooseDeliveryCompanyComboBox.Location = new System.Drawing.Point(594, 621);
            this.chooseDeliveryCompanyComboBox.Name = "chooseDeliveryCompanyComboBox";
            this.chooseDeliveryCompanyComboBox.Size = new System.Drawing.Size(270, 36);
            this.chooseDeliveryCompanyComboBox.TabIndex = 17;
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
            this.chooseDeliveryComboBox.Location = new System.Drawing.Point(594, 672);
            this.chooseDeliveryComboBox.Name = "chooseDeliveryComboBox";
            this.chooseDeliveryComboBox.Size = new System.Drawing.Size(270, 36);
            this.chooseDeliveryComboBox.TabIndex = 9;
            // 
            // orderstLabel
            // 
            this.orderstLabel.AutoSize = true;
            this.orderstLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderstLabel.Location = new System.Drawing.Point(43, 70);
            this.orderstLabel.Name = "orderstLabel";
            this.orderstLabel.Size = new System.Drawing.Size(199, 50);
            this.orderstLabel.TabIndex = 1;
            this.orderstLabel.Text = "My orders";
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
            // ordersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookStoreForms.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1071, 742);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ordersForm";
            this.Text = "ordersForm";
            this.Activated += new System.EventHandler(this.ordersForm_Activated);
            this.Load += new System.EventHandler(this.ordersForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myOrdersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private ComboBox chooseDeliveryCompanyComboBox;
        private ComboBox chooseDeliveryComboBox;
        private Label orderstLabel;
        private Label bookStoreLabel;
        private DataGridView myOrdersDataGridView;
        private Button goShopButton;
    }
}