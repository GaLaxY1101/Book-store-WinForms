using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_app
{
    public class DeliveryToPostOffice : Delivery
    {
        public int OfficeNumber { get; set; }

        public DeliveryToPostOffice(deliveryCompaines deliveryCompany, int officeNumber)
            : base(deliveryCompany)
        {
            OfficeNumber = officeNumber;
        }
        public DeliveryToPostOffice() { }
    }
}
