using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_app
{
    public class Product
    {
        public Edition Edition { get; set; }

        public int Price { get; set; }

        public Product(Edition edition, int price)
        {
            Edition = edition;
            Price = price;
        }

        public Product()
        {
        }
    }
}
