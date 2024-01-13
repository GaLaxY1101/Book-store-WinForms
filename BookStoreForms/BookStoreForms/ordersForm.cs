using BookStore_app;
using System;
using System.Collections;
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
    public partial class ordersForm : Form
    {
        public ordersForm()
        {
            InitializeComponent();
        }

        private void ordersForm_Load(object sender, EventArgs e)
        {
            myOrdersDataGridView.RowHeadersVisible = false;

            myOrdersDataGridView.ColumnCount = 2;
            myOrdersDataGridView.Columns[0].Name = "Products";
            myOrdersDataGridView.Columns[0].Width = 250;
            myOrdersDataGridView.Columns[1].Name = "Total Price";

            myOrdersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            myOrdersDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;

            myOrdersDataGridView.AllowUserToResizeRows = false;

            
        }

        private void goShopButton_Click(object sender, EventArgs e)
        {
            FormProvider.OrderForm.Hide();
            FormProvider.StartPage.Show();
        }

        private void ordersForm_Activated(object sender, EventArgs e)
        {
            if (FormProvider.StartPage.MyBookStore.OrdersList.Count == 0)
            {
                myOrdersDataGridView.Visible = false;
            }
            else 
            {
                myOrdersDataGridView.Rows.Clear();

                List<string> items = new List<string>();
                foreach (Order order in FormProvider.StartPage.MyBookStore.OrdersList)
                {
                    foreach (Item item in order.ItemsList)
                    {
                        items.Add(item.Product.Edition.Book.Name);

                    }
                    string[] row = new String[] { string.Join(",", items), order.TotalPrice.ToString() };
                    myOrdersDataGridView.Rows.Add(row);
                    items.Clear();
                }
            }
            
        }
    }
}
