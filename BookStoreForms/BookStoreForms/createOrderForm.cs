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
    public partial class createOrderForm : Form
    {
        public createOrderForm()
        {
            InitializeComponent();
        }


        private void createOrderForm_Load(object sender, EventArgs e)
        {
            deliveryAddressTextBox.Visible = false;
            deliveryArddressLabel.Visible = false;
            postOfficeNumberTextBox.Visible = false;
            postNumberLabel.Visible = false;
        }

        private void finishCreateOrderButton_Click(object sender, EventArgs e)
        {

            List<BookStore_app.Item> itemsList = new List<BookStore_app.Item>(FormProvider.ShoppingCart.myShoppingCart.ItemsList);

            switch (chooseDeliveryComboBox.SelectedIndex)
            {
                case 0:

                    MessageBox.Show("You have to choose delivery!");
                    break;

                case 1:

                    BookStore_app.DeliveryToPostOffice delivery = new BookStore_app.DeliveryToPostOffice();
                    delivery.OfficeNumber = Int32.Parse(postOfficeNumberTextBox.Text);

                    if (chooseDeliveryCompanyComboBox.SelectedIndex == 1)
                    {
                        delivery.DeliveryCompany = BookStore_app.Delivery.deliveryCompaines.NovaPoshta;


                        BookStore_app.Order order = new BookStore_app.Order(customerNameTextBox.Text, delivery, Int32.Parse(customerPhoneNumberTextBox.Text), itemsList);
                        FormProvider.StartPage.MyBookStore.OrdersList.Add(order);

                        FormProvider.ShoppingCart.myShoppingCart.ItemsList.Clear();
                        FormProvider.ShoppingCart.myShoppingCart.TotalPrice = 0;

                        FormProvider.CreateOrderForm.Hide();
                        FormProvider.StartPage.Show();

                    }

                    else if (chooseDeliveryCompanyComboBox.SelectedIndex == 2)
                    {
                        delivery.DeliveryCompany = BookStore_app.Delivery.deliveryCompaines.UkrPoshta;



                        BookStore_app.Order order = new BookStore_app.Order(customerNameTextBox.Text, delivery, Int32.Parse(customerPhoneNumberTextBox.Text), itemsList);
                        FormProvider.StartPage.MyBookStore.OrdersList.Add(order);

                        FormProvider.ShoppingCart.myShoppingCart.ItemsList.Clear();
                        FormProvider.ShoppingCart.myShoppingCart.TotalPrice = 0;

                        FormProvider.CreateOrderForm.Hide();
                        FormProvider.StartPage.Show();
                    }
                    else MessageBox.Show("You have to choose delivery company!");



                    break;
                
                case 2:
                    BookStore_app.DeliveryByCurier delivery1 = new BookStore_app.DeliveryByCurier();
                    delivery1.Adress = postOfficeNumberTextBox.Text;

                    if (chooseDeliveryCompanyComboBox.SelectedIndex == 1)
                    {
                        delivery1.DeliveryCompany = BookStore_app.Delivery.deliveryCompaines.NovaPoshta;

                        BookStore_app.Order order2 = new BookStore_app.Order(customerNameTextBox.Text, delivery1, Int32.Parse(customerPhoneNumberTextBox.Text), itemsList);

                        FormProvider.StartPage.MyBookStore.OrdersList.Add(order2);

                        FormProvider.ShoppingCart.myShoppingCart.ItemsList.Clear();
                        FormProvider.ShoppingCart.myShoppingCart.TotalPrice = 0;

                        FormProvider.CreateOrderForm.Hide();
                        FormProvider.StartPage.Show();
                    }

                    else if (chooseDeliveryCompanyComboBox.SelectedIndex == 2)
                    {
                        delivery1.DeliveryCompany = BookStore_app.Delivery.deliveryCompaines.UkrPoshta;

                        BookStore_app.Order order2 = new BookStore_app.Order(customerNameTextBox.Text, delivery1, Int32.Parse(customerPhoneNumberTextBox.Text), itemsList);
                        FormProvider.StartPage.MyBookStore.OrdersList.Add(order2);

                        FormProvider.ShoppingCart.myShoppingCart.ItemsList.Clear();
                        FormProvider.ShoppingCart.myShoppingCart.TotalPrice = 0;

                        FormProvider.CreateOrderForm.Hide();
                        FormProvider.StartPage.Show();
                    }
                    else MessageBox.Show("You have to choose delivery company!");
                    break;

            }
            
        }

        private void chooseDeliveryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseDeliveryComboBox.SelectedIndex == 1)
            {
                deliveryAddressTextBox.Visible = false;
                deliveryArddressLabel.Visible = false;
                postOfficeNumberTextBox.Visible = true;
                postNumberLabel.Visible = true;
            }
            else if (chooseDeliveryComboBox.SelectedIndex == 2)
            {
                postOfficeNumberTextBox.Visible = false;
                postNumberLabel.Visible = false;
                deliveryAddressTextBox.Visible = true;
                deliveryArddressLabel.Visible = true;
            }
            else
            {
                deliveryAddressTextBox.Visible = false;
                deliveryArddressLabel.Visible = false;
                postOfficeNumberTextBox.Visible = false;
                postNumberLabel.Visible = false;
            }
        }

        private void createOrderForm_Activated(object sender, EventArgs e)
        {
            chooseDeliveryCompanyComboBox.SelectedIndex = 0;
            chooseDeliveryComboBox.SelectedIndex = 0;
        }
    }
}
