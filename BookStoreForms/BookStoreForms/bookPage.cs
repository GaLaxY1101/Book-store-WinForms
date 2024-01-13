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
    public partial class bookPage : Form
    {
        public bookPage()
        {
            InitializeComponent();
            
        }

        private void bookStoreLabel_Click(object sender, EventArgs e)
        {
            FormProvider.StartPage.Show();
            FormProvider.BookPage.Hide();
        }

        private void bookPage_Activated(object sender, EventArgs e)
        {
            bookCountNumericUpDown1.Value = 1;
            bookTitleValueLabel.Text = myProduct.Edition.Book.Name;
            bookAuthorValueLabel.Text = myProduct.Edition.Book.Author;
            bookEditionValueLabel.Text = myProduct.Edition.Name;
            bookGenreValueLabel.Text = myProduct.Edition.Book.Genre.ToString();
            bookPublishingHouseValueLabel.Text = myProduct.Edition.PublishingHouse.Name;
            bookPagesCountValueLabel.Text = myProduct.Edition.PagesCount.ToString();
            bookCoverTypeValueLabel.Text = myProduct.Edition.TypeOfCover.ToString();
            BookPriceValueLabel.Text = myProduct.Price.ToString() + " грн";
            //switch(myProduct.Edition.Book.Genre)
            //{
            //    case (BookStore_app.Genres.Business):
            //        bookGenreValueLabel.Text = "Business";
            //        break;

            //    case (BookStore_app.Genres.History):
            //        bookGenreValueLabel.Text = "History";
            //        break;

            //    case (BookStore_app.Genres.Horror):
            //        bookGenreValueLabel.Text = "Horror";
            //        break;

            //    case (BookStore_app.Genres.TravelBooks):
            //        bookGenreValueLabel.Text = "Travel";
            //        break;

            //    case (BookStore_app.Genres.FairyTale):
            //        bookGenreValueLabel.Text = "Fairy tale";
            //        break;

            //    case (BookStore_app.Genres.Autobiography):
            //        bookGenreValueLabel.Text = "Autobiography";
            //        break;

            //    case (BookStore_app.Genres.Drama):
            //        bookGenreValueLabel.Text = "Drama";
            //        break;
            //}
        }

        private void bookPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addToTheCartButton_Click(object sender, EventArgs e)
        {
            BookStore_app.Item item = new BookStore_app.Item(myProduct, (int)bookCountNumericUpDown1.Value);
            FormProvider.ShoppingCart.myShoppingCart.addItem(item);
            MessageBox.Show("This product have added to your shopping cart successfully!");
        }

        private void bookPage_Load(object sender, EventArgs e)
        {

        }
    }
}
