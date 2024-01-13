using BookStore_app;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static BookStoreForms.Program;

namespace BookStoreForms
{
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();
            string file = @"D:\Education\Programming\Term3\Alina\BookStore\BookStore_app\BookStore_app\bin\Debug\xmlFiles\bookStore.xml";
            MyBookStore = BookStore_app.BookStore.ReadFromFile(file);
        }

        private void startPage_Load(object sender, EventArgs e)
        {
            chooseGenreComboBox.SelectedIndex= 0;
            searchedBooksDataGridView.RowHeadersVisible = false;

            searchedBooksDataGridView.ColumnCount = 3;
            searchedBooksDataGridView.Columns[0].Name = "Name";
            searchedBooksDataGridView.Columns[0].Width = 250;
            searchedBooksDataGridView.Columns[1].Name = "Author";
            searchedBooksDataGridView.Columns[1].Width = 150;
            searchedBooksDataGridView.Columns[2].Name = "Genre";
            searchedBooksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchedBooksDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;

            searchedBooksDataGridView.AllowUserToResizeRows = false;

            foreach (Product product in MyBookStore.ProductsList)
            {
                string[] row = new String[] { product.Edition.Book.Name, product.Edition.Book.Author, product.Edition.Book.Genre.ToString() };
                searchedBooksDataGridView.Rows.Add(row);
            }
            //searchedBooksDataGridView.DefaultCellStyle.SelectionBackColor = this.searchedBooksDataGridView.DefaultCellStyle.BackColor;
            //searchedBooksDataGridView.DefaultCellStyle.SelectionForeColor = this.searchedBooksDataGridView.DefaultCellStyle.ForeColor;
        }



        private void searchBookButton_Click(object sender, EventArgs e)
        {

            List<Product> filteredList;
            if (chooseGenreComboBox.SelectedIndex == 0 && searchBookTextBox.Text == "") 
            {
                MessageBox.Show("You didn't enter any of search parameters.");
            }
            else if(chooseGenreComboBox.SelectedIndex == 0 && searchBookTextBox.Text != "")
            {
                

                filteredList = MyBookStore.filter(MyBookStore.ProductsList, Product => Product.Edition.Book.Name.StartsWith(searchBookTextBox.Text));
                

                if (filteredList.Count == 0) MessageBox.Show("No results found.");
                else 
                {
                    searchedBooksDataGridView.Rows.Clear();
                    foreach (Product product in filteredList)
                    {
                        string[] row = new String[] { product.Edition.Book.Name, product.Edition.Book.Author, product.Edition.Book.Genre.ToString() };
                        searchedBooksDataGridView.Rows.Add(row);
                    }
                }
            }
            else 
            {
                var filteredList2 = MyBookStore.ProductsList.Where(Product => (Product.Edition.Book.Genre.ToString() == chooseGenreComboBox.Text) && (Product.Edition.Book.Name.StartsWith(searchBookTextBox.Text)));
                
                filteredList = filteredList2.ToList();

                if (filteredList.Count == 0) MessageBox.Show("No results found.");
                else
                {
                    searchedBooksDataGridView.Rows.Clear();
                    foreach (Product product in filteredList)
                    {
                        string[] row = new String[] { product.Edition.Book.Name, product.Edition.Book.Author, product.Edition.Book.Genre.ToString() };
                        searchedBooksDataGridView.Rows.Add(row);
                    }
                }
            }

            
        }

        private void searchedBooksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void searchedBooksDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string bookName = searchedBooksDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            
            
            List<Product> filteredList = MyBookStore.filter(MyBookStore.ProductsList, Product => Product.Edition.Book.Name.StartsWith(bookName));
            
            
            FormProvider.BookPage.myProduct = filteredList[0];
            FormProvider.BookPage.Show();
      
            FormProvider.StartPage.Hide();
        }

        private void shoppingCartButton_Click(object sender, EventArgs e)
        {
            FormProvider.StartPage.Hide();
            FormProvider.ShoppingCart.Show();
        }

        private void startPage_Activated(object sender, EventArgs e)
        {
            
        }

        private void myOrdersButton_Click(object sender, EventArgs e)
        {
            FormProvider.StartPage.Hide();
            FormProvider.OrderForm.Show();
        }
    }
}
