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
using static BookStoreForms.Program;

namespace BookStoreForms
{
    public partial class shoppingCart : Form
    {
        public shoppingCart()
        {
            InitializeComponent();
            myShoppingCart = new BookStore_app.ShoppingCart();
        }

        private void goShopButton_Click(object sender, EventArgs e)
        {
            FormProvider.ShoppingCart.Hide();
            FormProvider.StartPage.Show();
        }

        private void shoppingCart_Load(object sender, EventArgs e)
        {
            shoppingCartDataGridView.RowHeadersVisible = false;
            shoppingCartDataGridView.ColumnCount = 4;
            shoppingCartDataGridView.Columns[0].Name = "Title";
            shoppingCartDataGridView.Columns[0].Width = 250;
            shoppingCartDataGridView.Columns[1].Name = "Author";
            shoppingCartDataGridView.Columns[1].Width = 150;
            shoppingCartDataGridView.Columns[2].Name = "Count";
            shoppingCartDataGridView.Columns[2].Width = 70;
            shoppingCartDataGridView.Columns[3].Name = "Price";
            shoppingCartDataGridView.Columns[3].Width = 100;
            shoppingCartDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shoppingCartDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;

            shoppingCartDataGridView.AllowUserToResizeRows = false;

            DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();
            removeButtonColumn.Name = "";
            removeButtonColumn.Text = "a";
            
            removeButtonColumn.Width = 30;
            
            int columnIndex = 4;

 
            shoppingCartDataGridView.Columns.Insert(columnIndex, removeButtonColumn);
  


        }

        private void shoppingCart_Activated(object sender, EventArgs e)
        {
            if (myShoppingCart.ItemsList.Count == 0)
            {
                shoppingCartDataGridView.Visible = false;
                createOrderButton.Visible = false;
                totalPriceValueLabel.Visible = false;
                totalPriceLabel.Visible = false;
            }
            else 
            {
                shoppingCartDataGridView.Visible = true;
                createOrderButton.Visible = true;
                totalPriceValueLabel.Visible = true;
                totalPriceLabel.Visible = true;

                shoppingCartDataGridView.Rows.Clear();
                foreach (Item item in myShoppingCart.ItemsList)
                {
                    string[] row = new String[] { item.Product.Edition.Book.Name, item.Product.Edition.Book.Author, item.Count.ToString(), (item.Count*item.Product.Price).ToString() };
                    shoppingCartDataGridView.Rows.Add(row);
                }
                totalPriceValueLabel.Text = myShoppingCart.TotalPrice.ToString() + " грн";
            }
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            FormProvider.ShoppingCart.Hide();
            FormProvider.CreateOrderForm.Show();
        }
    }
}
