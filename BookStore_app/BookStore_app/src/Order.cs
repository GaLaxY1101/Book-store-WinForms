using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_app
{
    public class Order : ShoppingCart
    {
        
        public String CustomerName { get; set; }

        public Delivery Delivery { get; set; }
        public int CustomerPhoneNumber { get; set; }

        public Order(String customerName, Delivery delivery, int customerPhoneNumber, List<Item> addedItemsList)
        :base(addedItemsList)
        {
            CustomerName = customerName;
            Delivery = delivery;
            CustomerPhoneNumber = customerPhoneNumber;
        }

        public Order():base()
        { }

    }
}
