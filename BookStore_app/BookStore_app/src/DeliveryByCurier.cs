using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_app
{
    public class DeliveryByCurier : Delivery
    {
        public string Adress { get; set; }
        public DeliveryByCurier(deliveryCompaines deliveryCompany, string adress) 
            :base(deliveryCompany)
        {
            Adress = adress;
        }
        public DeliveryByCurier() { }
    }
}
