using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
     public class Product
    {
        public int pid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }

        public Product()
        {

        }

        public Product(int pid, string name, string description, float price)
        {
            this.pid = pid;
            this.name = name;
            this.description = description;
            this.price = price;
        }

       /* public static void display(List<Product> lp)
        {
            foreach (Product p in lp)
            {

                Console.WriteLine("Product Id: " + p.pid + " Product Name: " + p.name + " Description: " + p.description + " Price: " + p.price);
            }
        }*/
    }


    
}
