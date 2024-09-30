using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Models;

namespace ConsoleApp2.DAL
{
    internal class ProductDAL
    {
        public static List<Product> product = new List<Product>()
         {
             new Product(1,"AAA","BBB",40000),
             new Product(2,"CCC","DDD",30000),
             new Product(3,"EEE","FFF",20000)
         };
    }
}
