namespace BookStoreForms
{
    partial class shoppingCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shoppingCart));
            this.shoppingCartPanel = new System.Windows.Forms.Panel();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.totalPriceValueLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.shoppingCartDataGridView = new System.Windows.Forms.DataGridView();
            this.goShopButton = new System.Windows.Forms.Button();
            this.shoppingCartLabel = new System.Windows.Forms.Label();
            this.shoppingCartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shoppingCartPanel
            // 
            this.shoppingCartPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shoppingCartPanel.Controls.Add(this.createOrderButton);
            this.shoppingCartPanel.Controls.Add(this.totalPriceValueLabel);
            this.shoppingCartPanel.Controls.Add(this.totalPriceLabel);
            this.shoppingCartPanel.Controls.Add(this.shoppingCartDataGridView);
            this.shoppingCartPanel.Controls.Add(this.goShopButton);
            this.shoppingCartPanel.Controls.Add(this.shoppingCartLabel);
            this.shoppingCartPanel.Location = new System.Drawing.Point(111, 58);
            this.shoppingCartPanel.Name = "shoppingCartPanel";
            this.shoppingCartPanel.Size = new System.Drawing.Size(966, 619);
            this.shoppingCartPanel.TabIndex = 0;
            // 
            // createOrderButton
            // 
            this.createOrderButton.BackColor = System.Drawing.Color.ForestGreen;
            this.createOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createOrderButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createOrderButton.Location = new System.Drawing.Point(375, 542);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(157, 50);
            this.createOrderButton.TabIndex = 9;
            this.createOrderButton.Text = "Create order";
            this.createOrderButton.UseVisualStyleBackColor = false;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // totalPriceValueLabel
            // 
            this.totalPriceValueLabel.AutoSize = true;
            this.totalPriceValueLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPriceValueLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.totalPriceValueLabel.Location = new System.Drawing.Point(743, 547);
            this.totalPriceValueLabel.Name = "totalPriceValueLabel";
            this.totalPriceValueLabel.Size = new System.Drawing.Size(71, 31);
            this.totalPriceValueLabel.TabIndex = 8;
            this.totalPriceValueLabel.Text = "value";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPriceLabel.Location = new System.Drawing.Point(675, 546);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(73, 31);
            this.totalPriceLabel.TabIndex = 7;
            this.totalPriceLabel.Text = "Total:";
            // 
            // shoppingCartDataGridView
            // 
            this.shoppingCartDataGridView.AllowUserToAddRows = false;
            this.shoppingCartDataGridView.AllowUserToDeleteRows = false;
            this.shoppingCartDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.shoppingCartDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shoppingCartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingCartDataGridView.Location = new System.Drawing.Point(150, 83);
            this.shoppingCartDataGridView.Name = "shoppingCartDataGridView";
            this.shoppingCartDataGridView.ReadOnly = true;
            this.shoppingCartDataGridView.RowHeadersWidth = 51;
            this.shoppingCartDataGridView.RowTemplate.Height = 29;
            this.shoppingCartDataGridView.Size = new System.Drawing.Size(658, 433);
            this.shoppingCartDataGridView.TabIndex = 6;
            // 
            // goShopButton
            // 
            this.goShopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goShopButton.Location = new System.Drawing.Point(47, 546);
            this.goShopButton.Name = "goShopButton";
            this.goShopButton.Size = new System.Drawing.Size(127, 42);
            this.goShopButton.TabIndex = 5;
            this.goShopButton.Text = "go shop";
            this.goShopButton.UseVisualStyleBackColor = true;
            this.goShopButton.Click += new System.EventHandler(this.goShopButton_Click);
            // 
            // shoppingCartLabel
            // 
            this.shoppingCartLabel.AutoSize = true;
            this.shoppingCartLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shoppingCartLabel.Location = new System.Drawing.Point(349, 10);
            this.shoppingCartLabel.Name = "shoppingCartLabel";
            this.shoppingCartLabel.Size = new System.Drawing.Size(288, 54);
            this.shoppingCartLabel.TabIndex = 4;
            this.shoppingCartLabel.Text = "Shopping cart";
            // 
            // shoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 742);
            this.Controls.Add(this.shoppingCartPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "shoppingCart";
            this.Text = "shoppingCart";
            this.Activated += new System.EventHandler(this.shoppingCart_Activated);
            this.Load += new System.EventHandler(this.shoppingCart_Load);
            this.shoppingCartPanel.ResumeLayout(false);
            this.shoppingCartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel shoppingCartPanel;
        private Button goShopButton;
        private Label shoppingCartLabel;
        private DataGridView shoppingCartDataGridView;
        private Label totalPriceValueLabel;
        private Label totalPriceLabel;
        private Button createOrderButton;

        public BookStore_app.ShoppingCart myShoppingCart { get; set; }


    }
}