using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore_app
{
    public class ShoppingCart
    {
        private List<Item> _itemsList;
        public List<Item> ItemsList 
        {
            get
            {
                return _itemsList;
            }

            set
            {
                _itemsList = value;
            }
            
        }

        public void addItem(Item item)
        {
            _itemsList.Add(item);
            TotalPrice += item.Count * item.Product.Price;
        }
        public int TotalPrice { get; set; }

        public ShoppingCart() 
        {
            ItemsList = new List<Item>();
        }

        public ShoppingCart(List<Item> addedItemsList)
        {
            ItemsList = addedItemsList;
            foreach (Item item in addedItemsList)
            {
                TotalPrice += item.Product.Price;
            }
        }

    }
}
