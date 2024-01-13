using BookStore_app;

namespace BookStoreForms
{
    partial class bookPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookPage));
            this.bookPanel = new System.Windows.Forms.Panel();
            this.bookCountNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.addToTheCartButton = new System.Windows.Forms.Button();
            this.BookPriceValueLabel = new System.Windows.Forms.Label();
            this.bookPriceLabel = new System.Windows.Forms.Label();
            this.bookCoverTypeValueLabel = new System.Windows.Forms.Label();
            this.bookCoverTypeLabel = new System.Windows.Forms.Label();
            this.bookPagesCountValueLabel = new System.Windows.Forms.Label();
            this.bookPublishingHouseValueLabel = new System.Windows.Forms.Label();
            this.bookGenreValueLabel = new System.Windows.Forms.Label();
            this.bookEditionValueLabel = new System.Windows.Forms.Label();
            this.bookPagesCountLabel = new System.Windows.Forms.Label();
            this.bookPublishingHouseLabel = new System.Windows.Forms.Label();
            this.bookGenreLabel = new System.Windows.Forms.Label();
            this.bookEditionLabel = new System.Windows.Forms.Label();
            this.bookAuthorValueLabel = new System.Windows.Forms.Label();
            this.bookAuthorLabel = new System.Windows.Forms.Label();
            this.bookStoreLabel = new System.Windows.Forms.Label();
            this.bookTitleValueLabel = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.bookAvatarpanel = new System.Windows.Forms.Panel();
            this.bookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCountNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookPanel
            // 
            this.bookPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookPanel.Controls.Add(this.bookCountNumericUpDown1);
            this.bookPanel.Controls.Add(this.addToTheCartButton);
            this.bookPanel.Controls.Add(this.BookPriceValueLabel);
            this.bookPanel.Controls.Add(this.bookPriceLabel);
            this.bookPanel.Controls.Add(this.bookCoverTypeValueLabel);
            this.bookPanel.Controls.Add(this.bookCoverTypeLabel);
            this.bookPanel.Controls.Add(this.bookPagesCountValueLabel);
            this.bookPanel.Controls.Add(this.bookPublishingHouseValueLabel);
            this.bookPanel.Controls.Add(this.bookGenreValueLabel);
            this.bookPanel.Controls.Add(this.bookEditionValueLabel);
            this.bookPanel.Controls.Add(this.bookPagesCountLabel);
            this.bookPanel.Controls.Add(this.bookPublishingHouseLabel);
            this.bookPanel.Controls.Add(this.bookGenreLabel);
            this.bookPanel.Controls.Add(this.bookEditionLabel);
            this.bookPanel.Controls.Add(this.bookAuthorValueLabel);
            this.bookPanel.Controls.Add(this.bookAuthorLabel);
            this.bookPanel.Controls.Add(this.bookStoreLabel);
            this.bookPanel.Controls.Add(this.bookTitleValueLabel);
            this.bookPanel.Controls.Add(this.bookNameLabel);
            this.bookPanel.Controls.Add(this.bookAvatarpanel);
            this.bookPanel.Location = new System.Drawing.Point(82, 70);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(922, 619);
            this.bookPanel.TabIndex = 0;
            this.bookPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bookPanel_Paint);
            // 
            // bookCountNumericUpDown1
            // 
            this.bookCountNumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookCountNumericUpDown1.Location = new System.Drawing.Point(247, 357);
            this.bookCountNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bookCountNumericUpDown1.Name = "bookCountNumericUpDown1";
            this.bookCountNumericUpDown1.Size = new System.Drawing.Size(60, 38);
            this.bookCountNumericUpDown1.TabIndex = 19;
            this.bookCountNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addToTheCartButton
            // 
            this.addToTheCartButton.BackColor = System.Drawing.Color.ForestGreen;
            this.addToTheCartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToTheCartButton.Location = new System.Drawing.Point(63, 354);
            this.addToTheCartButton.Name = "addToTheCartButton";
            this.addToTheCartButton.Size = new System.Drawing.Size(182, 43);
            this.addToTheCartButton.TabIndex = 18;
            this.addToTheCartButton.Text = "Add to the cart";
            this.addToTheCartButton.UseVisualStyleBackColor = false;
            this.addToTheCartButton.Click += new System.EventHandler(this.addToTheCartButton_Click);
            // 
            // BookPriceValueLabel
            // 
            this.BookPriceValueLabel.AutoSize = true;
            this.BookPriceValueLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookPriceValueLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.BookPriceValueLabel.Location = new System.Drawing.Point(457, 500);
            this.BookPriceValueLabel.Name = "BookPriceValueLabel";
            this.BookPriceValueLabel.Size = new System.Drawing.Size(93, 41);
            this.BookPriceValueLabel.TabIndex = 17;
            this.BookPriceValueLabel.Text = "value";
            // 
            // bookPriceLabel
            // 
            this.bookPriceLabel.AutoSize = true;
            this.bookPriceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookPriceLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.bookPriceLabel.Location = new System.Drawing.Point(333, 500);
            this.bookPriceLabel.Name = "bookPriceLabel";
            this.bookPriceLabel.Size = new System.Drawing.Size(95, 41);
            this.bookPriceLabel.TabIndex = 16;
            this.bookPriceLabel.Text = "Price:";
            // 
            // bookCoverTypeValueLabel
            // 
            this.bookCoverTypeValueLabel.AutoSize = true;
            this.bookCoverTypeValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookCoverTypeValueLabel.Location = new System.Drawing.Point(457, 449);
            this.bookCoverTypeValueLabel.Name = "bookCoverTypeValueLabel";
            this.bookCoverTypeValueLabel.Size = new System.Drawing.Size(91, 41);
            this.bookCoverTypeValueLabel.TabIndex = 15;
            this.bookCoverTypeValueLabel.Text = "value";
            // 
            // bookCoverTypeLabel
            // 
            this.bookCoverTypeLabel.AutoSize = true;
            this.bookCoverTypeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookCoverTypeLabel.Location = new System.Drawing.Point(332, 449);
            this.bookCoverTypeLabel.Name = "bookCoverTypeLabel";
            this.bookCoverTypeLabel.Size = new System.Drawing.Size(108, 41);
            this.bookCoverTypeLabel.TabIndex = 14;
            this.bookCoverTypeLabel.Text = "Cover:";
            // 
            // bookPagesCountValueLabel
            // 
            this.bookPagesCountValueLabel.AutoSize = true;
            this.bookPagesCountValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookPagesCountValueLabel.Location = new System.Drawing.Point(457, 399);
            this.bookPagesCountValueLabel.Name = "bookPagesCountValueLabel";
            this.bookPagesCountValueLabel.Size = new System.Drawing.Size(91, 41);
            this.bookPagesCountValueLabel.TabIndex = 13;
            this.bookPagesCountValueLabel.Text = "value";
            // 
            // bookPublishingHouseValueLabel
            // 
            this.bookPublishingHouseValueLabel.AutoSize = true;
            this.bookPublishingHouseValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookPublishingHouseValueLabel.Location = new System.Drawing.Point(457, 348);
            this.bookPublishingHouseValueLabel.Name = "bookPublishingHouseValueLabel";
            this.bookPublishingHouseValueLabel.Size = new System.Drawing.Size(91, 41);
            this.bookPublishingHouseValueLabel.TabIndex = 12;
            this.bookPublishingHouseValueLabel.Text = "value";
            // 
            // bookGenreValueLabel
            // 
            this.bookGenreValueLabel.AutoSize = true;
            this.bookGenreValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookGenreValueLabel.Location = new System.Drawing.Point(457, 298);
            this.bookGenreValueLabel.Name = "bookGenreValueLabel";
            this.bookGenreValueLabel.Size = new System.Drawing.Size(91, 41);
            this.bookGenreValueLabel.TabIndex = 11;
            this.bookGenreValueLabel.Text = "value";
            // 
            // bookEditionValueLabel
            // 
            this.bookEditionValueLabel.AutoSize = true;
            this.bookEditionValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookEditionValueLabel.Location = new System.Drawing.Point(457, 245);
            this.bookEditionValueLabel.Name = "bookEditionValueLabel";
            this.bookEditionValueLabel.Size = new System.Drawing.Size(91, 41);
            this.bookEditionValueLabel.TabIndex = 10;
            this.bookEditionValueLabel.Text = "value";
            // 
            // bookPagesCountLabel
            // 
            this.bookPagesCountLabel.AutoSize = true;
            this.bookPagesCountLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookPagesCountLabel.Location = new System.Drawing.Point(331, 399);
            this.bookPagesCountLabel.Name = "bookPagesCountLabel";
            this.bookPagesCountLabel.Size = new System.Drawing.Size(107, 41);
            this.bookPagesCountLabel.TabIndex = 9;
            this.bookPagesCountLabel.Text = "Pages:";
            // 
            // bookPublishingHouseLabel
            // 
            this.bookPublishingHouseLabel.AutoSize = true;
            this.bookPublishingHouseLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookPublishingHouseLabel.Location = new System.Drawing.Point(332, 348);
            this.bookPublishingHouseLabel.Name = "bookPublishingHouseLabel";
            this.bookPublishingHouseLabel.Size = new System.Drawing.Size(131, 41);
            this.bookPublishingHouseLabel.TabIndex = 8;
            this.bookPublishingHouseLabel.Text = "P.house:";
            // 
            // bookGenreLabel
            // 
            this.bookGenreLabel.AutoSize = true;
            this.bookGenreLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookGenreLabel.Location = new System.Drawing.Point(332, 298);
            this.bookGenreLabel.Name = "bookGenreLabel";
            this.bookGenreLabel.Size = new System.Drawing.Size(109, 41);
            this.bookGenreLabel.TabIndex = 7;
            this.bookGenreLabel.Text = "Genre:";
            // 
            // bookEditionLabel
            // 
            this.bookEditionLabel.AutoSize = true;
            this.bookEditionLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookEditionLabel.Location = new System.Drawing.Point(332, 245);
            this.bookEditionLabel.Name = "bookEditionLabel";
            this.bookEditionLabel.Size = new System.Drawing.Size(127, 41);
            this.bookEditionLabel.TabIndex = 6;
            this.bookEditionLabel.Text = "Edition:";
            // 
            // bookAuthorValueLabel
            // 
            this.bookAuthorValueLabel.AutoSize = true;
            this.bookAuthorValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookAuthorValueLabel.Location = new System.Drawing.Point(457, 193);
            this.bookAuthorValueLabel.Name = "bookAuthorValueLabel";
            this.bookAuthorValueLabel.Size = new System.Drawing.Size(91, 41);
            this.bookAuthorValueLabel.TabIndex = 5;
            this.bookAuthorValueLabel.Text = "value";
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookAuthorLabel.Location = new System.Drawing.Point(332, 193);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(126, 41);
            this.bookAuthorLabel.TabIndex = 4;
            this.bookAuthorLabel.Text = "Author:";
            // 
            // bookStoreLabel
            // 
            this.bookStoreLabel.AutoSize = true;
            this.bookStoreLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookStoreLabel.Location = new System.Drawing.Point(307, 13);
            this.bookStoreLabel.Name = "bookStoreLabel";
            this.bookStoreLabel.Size = new System.Drawing.Size(229, 54);
            this.bookStoreLabel.TabIndex = 3;
            this.bookStoreLabel.Text = "Book Store";
            this.bookStoreLabel.Click += new System.EventHandler(this.bookStoreLabel_Click);
            // 
            // bookTitleValueLabel
            // 
            this.bookTitleValueLabel.AutoSize = true;
            this.bookTitleValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookTitleValueLabel.Location = new System.Drawing.Point(457, 143);
            this.bookTitleValueLabel.Name = "bookTitleValueLabel";
            this.bookTitleValueLabel.Size = new System.Drawing.Size(91, 41);
            this.bookTitleValueLabel.TabIndex = 2;
            this.bookTitleValueLabel.Text = "value";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookNameLabel.Location = new System.Drawing.Point(332, 143);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(90, 41);
            this.bookNameLabel.TabIndex = 1;
            this.bookNameLabel.Text = "Title:";
            // 
            // bookAvatarpanel
            // 
            this.bookAvatarpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookAvatarpanel.BackgroundImage")));
            this.bookAvatarpanel.Location = new System.Drawing.Point(63, 143);
            this.bookAvatarpanel.Name = "bookAvatarpanel";
            this.bookAvatarpanel.Size = new System.Drawing.Size(244, 196);
            this.bookAvatarpanel.TabIndex = 0;
            // 
            // bookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 742);
            this.Controls.Add(this.bookPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bookPage";
            this.Text = "bookPage";
            this.Activated += new System.EventHandler(this.bookPage_Activated);
            this.Load += new System.EventHandler(this.bookPage_Load);
            this.bookPanel.ResumeLayout(false);
            this.bookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCountNumericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel bookPanel;
        private Panel bookAvatarpanel;
        private Label bookTitleValueLabel;
        private Label bookNameLabel;
        private Label bookStoreLabel;
        private Label bookPagesCountLabel;
        private Label bookPublishingHouseLabel;
        private Label bookGenreLabel;
        private Label bookEditionLabel;
        private Label bookAuthorValueLabel;
        private Label bookAuthorLabel;
        private Label bookPagesCountValueLabel;
        private Label bookPublishingHouseValueLabel;
        private Label bookGenreValueLabel;
        private Label bookEditionValueLabel;
        private Label BookPriceValueLabel;
        private Label bookPriceLabel;
        private Label bookCoverTypeValueLabel;
        private Label bookCoverTypeLabel;
        private Button addToTheCartButton;
        private NumericUpDown bookCountNumericUpDown1;

        public Product myProduct { get; set; }
    }
}