using System;
using System.Collections.Generic;

namespace BookStore_app
{
    class Program
    {
        static void Main(string[] args)
        {
            PublishingHouse ph1 = new PublishingHouse("Publishing house of US", "USA");
            Book myBook = new Book("Joanne Rowling", Genres.Fantasy, "Harry Potter");
            Edition myEdition = new Edition("The second", 525, 2012, myBook, ph1, CoverTypes.Hard);

            PublishingHouse ph2 = new PublishingHouse("Publishing house of London", "Great Britan");
            Book myBook2 = new Book("Mark Twen", Genres.TravelBooks, "Tom Sawyer");
            Edition myEdition2 = new Edition("The third", 355, 1990, myBook2, ph2, CoverTypes.Hard);

            PublishingHouse ph3 = new PublishingHouse("Publishing house of Kyiv", "Ukraine");
            Book myBook3 = new Book("John R. R. Tolkien", Genres.TravelBooks, "Lord of the Rings");
            Edition myEdition3 = new Edition("The third", 355, 1990, myBook3, ph3, CoverTypes.Hard);

            Book myBook4 = new Book("Andrzej Sapkowski", Genres.Fantasy, "The Witcher. The Last Wish. Book 1");
            Edition myEdition4 = new Edition("The third", 355, 1990, myBook4, ph1, CoverTypes.Hard);

            Book myBook5 = new Book("Andrzej Sapkowski", Genres.Fantasy, "The Witcher. The Last Wish. Book 2");
            Edition myEdition5 = new Edition("The third", 355, 1990, myBook5, ph1, CoverTypes.Hard);

            Book myBook6 = new Book("Andrzej Sapkowski", Genres.Fantasy, "The Witcher. The Last Wish. Book 3");
            Edition myEdition6 = new Edition("The third", 355, 1990, myBook6, ph1, CoverTypes.Hard);

            Book myBook7 = new Book("Walter Isaacson", Genres.Autobiography, "Steve Jobs");
            Edition myEdition7 = new Edition("The first", 567, 2012, myBook7, ph1, CoverTypes.Hard);
            
            Book myBook8 = new Book("Winston Churchill", Genres.Autobiography, "My Early Life: 1874-1904");
            Edition myEdition8 = new Edition("The first", 567, 1930, myBook8, ph2, CoverTypes.Hard);
            
            
            Book myBook9 = new Book("Dale Carnegie", Genres.Business, "How to win friends and influence people");
            Edition myEdition9 = new Edition("The first", 495, 1948, myBook9, ph2, CoverTypes.Hard);



            Product product1 = new Product(myEdition, 899);
            Product product2 = new Product(myEdition2, 559);
            Product product3 = new Product(myEdition3, 499);
            Product product4 = new Product(myEdition4, 899);
            Product product5 = new Product(myEdition5, 899);
            Product product6 = new Product(myEdition6, 899);
            Product product7 = new Product(myEdition7, 1200);
            Product product8 = new Product(myEdition8, 600);
            Product product9 = new Product(myEdition9, 789);





            //Delivery delivery1 = new DeliveryToPostOffice(Delivery.deliveryCompaines.NovaPoshta, 179);
            //Order order1 = new Order("Alina Niechkina", delivery1, 0668120524, productsList);


            BookStore myBookStore = new BookStore();
            myBookStore.Title = "Central Book Store";

            myBookStore.ProductsList.AddRange(new List<Product> { product1, product2, product3, product4, product5, product6, product7, product8, product9 });







            List<Product> filteredList = myBookStore.filter(myBookStore.ProductsList, Product => Product.Edition.Book.Name.StartsWith("t"));

            foreach (Product product in filteredList)
            {
                Console.WriteLine(product.Edition.Book.Name);
            }

            String file = @"..\xmlFiles\bookStore.xml";

            myBookStore.WriteToFile(file);

            BookStore readedBookStore = BookStore.ReadFromFile(file);

            Console.WriteLine(readedBookStore.ProductsList[0].Edition.Book.Name);
            Console.WriteLine(readedBookStore.ProductsList[1].Edition.Book.Name);

        }
    }
}
