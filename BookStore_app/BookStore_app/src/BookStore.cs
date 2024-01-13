using BookStore_app;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;




namespace BookStore_app
{

    public class BookStore : IWritable
    {
        public String Title {get;set;}
     
        public List<Product> ProductsList { get;set;}

        public List<Order> OrdersList { get; set; }

        public void WriteToFile(String path)
        {
            Type[] types = new Type[] { typeof(DeliveryToPostOffice) };
            XmlSerializer serializer = new XmlSerializer(typeof(BookStore), types);

            
            using (Stream writer = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static BookStore ReadFromFile(String path)
        {
            Type[] types = new Type[] { typeof(DeliveryToPostOffice) };
            XmlSerializer serializer = new XmlSerializer(typeof(BookStore), types);

            using (Stream reader = new FileStream(path, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                return (BookStore)serializer.Deserialize(reader);
            }
        }

        public BookStore() 
        {
            ProductsList = new List<Product>();
            OrdersList = new List<Order>();
        }

        public delegate bool estimationFunc(Product productToEstimate);
        public  List<Product> filter(List<Product> productsList, estimationFunc estimate)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in ProductsList)
            {
                if (estimate(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }
    }
}
