using BookStore_app;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BookStore_app{
    public class Item 
    {
        public int Count {get;set;}

        public Product Product { get;set;}  
        public Item(Product product, int count)

        {
            Product = product;
            Count = count;
        }

        public Item() { }
    }
}
