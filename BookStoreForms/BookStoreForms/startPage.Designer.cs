namespace BookStoreForms
{
    partial class startPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startPage));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.shoppingCartButton = new System.Windows.Forms.Button();
            this.searchedBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.searchBookTextBox = new System.Windows.Forms.TextBox();
            this.chooseGenreComboBox = new System.Windows.Forms.ComboBox();
            this.bookStoreLabel = new System.Windows.Forms.Label();
            this.startPageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myOrdersButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchedBooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPanel.Controls.Add(this.myOrdersButton);
            this.mainPanel.Controls.Add(this.shoppingCartButton);
            this.mainPanel.Controls.Add(this.searchedBooksDataGridView);
            this.mainPanel.Controls.Add(this.searchBookButton);
            this.mainPanel.Controls.Add(this.searchBookTextBox);
            this.mainPanel.Controls.Add(this.chooseGenreComboBox);
            this.mainPanel.Controls.Add(this.bookStoreLabel);
            this.mainPanel.Location = new System.Drawing.Point(150, 70);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(821, 619);
            this.mainPanel.TabIndex = 0;
            // 
            // shoppingCartButton
            // 
            this.shoppingCartButton.BackColor = System.Drawing.Color.LimeGreen;
            this.shoppingCartButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shoppingCartButton.ForeColor = System.Drawing.Color.Black;
            this.shoppingCartButton.Location = new System.Drawing.Point(575, 36);
            this.shoppingCartButton.Name = "shoppingCartButton";
            this.shoppingCartButton.Size = new System.Drawing.Size(94, 36);
            this.shoppingCartButton.TabIndex = 5;
            this.shoppingCartButton.Text = "Cart";
            this.shoppingCartButton.UseVisualStyleBackColor = false;
            this.shoppingCartButton.Click += new System.EventHandler(this.shoppingCartButton_Click);
            // 
            // searchedBooksDataGridView
            // 
            this.searchedBooksDataGridView.AllowUserToAddRows = false;
            this.searchedBooksDataGridView.AllowUserToDeleteRows = false;
            this.searchedBooksDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchedBooksDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchedBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchedBooksDataGridView.Location = new System.Drawing.Point(141, 135);
            this.searchedBooksDataGridView.Name = "searchedBooksDataGridView";
            this.searchedBooksDataGridView.ReadOnly = true;
            this.searchedBooksDataGridView.RowHeadersWidth = 51;
            this.searchedBooksDataGridView.RowTemplate.Height = 29;
            this.searchedBooksDataGridView.Size = new System.Drawing.Size(528, 433);
            this.searchedBooksDataGridView.TabIndex = 4;
            this.searchedBooksDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchedBooksDataGridView_CellDoubleClick);
            // 
            // searchBookButton
            // 
            this.searchBookButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBookButton.Location = new System.Drawing.Point(575, 78);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(94, 36);
            this.searchBookButton.TabIndex = 3;
            this.searchBookButton.Text = "Search";
            this.searchBookButton.UseVisualStyleBackColor = true;
            this.searchBookButton.Click += new System.EventHandler(this.searchBookButton_Click);
            // 
            // searchBookTextBox
            // 
            this.searchBookTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBookTextBox.Location = new System.Drawing.Point(257, 80);
            this.searchBookTextBox.Name = "searchBookTextBox";
            this.searchBookTextBox.Size = new System.Drawing.Size(303, 34);
            this.searchBookTextBox.TabIndex = 2;
            // 
            // chooseGenreComboBox
            // 
            this.chooseGenreComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chooseGenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseGenreComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseGenreComboBox.FormattingEnabled = true;
            this.chooseGenreComboBox.Items.AddRange(new object[] {
            "Choose a genre...",
            "Drama",
            "Fantasy",
            "FairyTale",
            "TravelBooks",
            "Autobiography",
            "History",
            "Thriller",
            "Mystery",
            "Romance",
            "Horror",
            "Business"});
            this.chooseGenreComboBox.Location = new System.Drawing.Point(66, 79);
            this.chooseGenreComboBox.Name = "chooseGenreComboBox";
            this.chooseGenreComboBox.Size = new System.Drawing.Size(176, 36);
            this.chooseGenreComboBox.TabIndex = 1;
            // 
            // bookStoreLabel
            // 
            this.bookStoreLabel.AutoSize = true;
            this.bookStoreLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookStoreLabel.Location = new System.Drawing.Point(297, 0);
            this.bookStoreLabel.Name = "bookStoreLabel";
            this.bookStoreLabel.Size = new System.Drawing.Size(229, 54);
            this.bookStoreLabel.TabIndex = 0;
            this.bookStoreLabel.Text = "Book Store";
            // 
            // myOrdersButton
            // 
            this.myOrdersButton.BackColor = System.Drawing.Color.LimeGreen;
            this.myOrdersButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myOrdersButton.ForeColor = System.Drawing.Color.Black;
            this.myOrdersButton.Location = new System.Drawing.Point(675, 36);
            this.myOrdersButton.Name = "myOrdersButton";
            this.myOrdersButton.Size = new System.Drawing.Size(94, 78);
            this.myOrdersButton.TabIndex = 6;
            this.myOrdersButton.Text = "Orders";
            this.myOrdersButton.UseVisualStyleBackColor = false;
            this.myOrdersButton.Click += new System.EventHandler(this.myOrdersButton_Click);
            // 
            // startPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 742);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "startPage";
            this.Text = "startPage";
            this.Load += new System.EventHandler(this.startPage_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchedBooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private Label bookStoreLabel;
        private ComboBox chooseGenreComboBox;
        private TextBox searchBookTextBox;
        private Button searchBookButton;

        public BookStore_app.BookStore MyBookStore { get; set; }

  

        private BindingSource startPageBindingSource;
        private DataGridView searchedBooksDataGridView;
        private Button shoppingCartButton;
        private Button myOrdersButton;
    }
}