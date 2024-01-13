using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_app
{
    public class Delivery
    {
        public enum deliveryCompaines
        {
            NovaPoshta,
            UkrPoshta,
        }
        public deliveryCompaines DeliveryCompany { get; set; }

        public Delivery(deliveryCompaines deliveryCompany) 
        {
            DeliveryCompany = deliveryCompany;
        }
        public Delivery() { }

    }
}
