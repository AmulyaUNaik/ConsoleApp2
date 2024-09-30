using ConsoleApp2.Models;
using ConsoleApp2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Repository;
using System.Security.Cryptography;
using ConsoleApp2.DAL;

namespace ConsoleApp2.Repository
{
    class Program
    {
       // public static ProductRepo productrepo;
        public Program()
        {
          
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            IProductRepo productrepo = new ProductRepo();
            List<Product> products = new List<Product>();
            int input;
            for (; ; )
            {
                Console.WriteLine("1.Add  2.Display  3.Delete 4.Update 5.Search 6.Exit");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: 
                        Product p = new Product();
                        Console.WriteLine("Enter ID:");
                        p.pid = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Name:");
                        p.name = Console.ReadLine();

                        Console.WriteLine("Enter Description:");
                        p.description = Console.ReadLine();

                        Console.WriteLine("Enter Price:");
                        p.price = float.Parse(Console.ReadLine());

                        productrepo.Addproduct(p);

                        break;

                    case 2:
                        products=productrepo.GetProduct();
                        foreach(Product p1 in products)
                        {
                           Console.WriteLine("Product Id: " + p1.pid + " Product Name: " + p1.name + " Description: " + p1.description + " Price: " + p1.price);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter an id");
                        int k = Convert.ToInt32(Console.ReadLine());
                        productrepo.DeleteProduct(k);
                        Console.WriteLine("Selected element deleted");
                        break;
                    case 4:

                        Console.WriteLine("Enter id to ");
                        int n = Convert.ToInt32(Console.ReadLine());

                        Product product = new Product();

                        Console.WriteLine("Enter Name:");
                        product.name = Console.ReadLine();

                        Console.WriteLine("Enter Description:");
                        product.description = Console.ReadLine();

                        Console.WriteLine("Enter Price:");
                        product.price = float.Parse(Console.ReadLine());

                        productrepo.UpdateProduct(n, product); 

                        break;

                    case 5:
                      /* Console.WriteLine("Enter id to search");
                        int id_search = Convert.ToInt32(Console.ReadLine());
                        Product p2 = new Product();
                        p2 =productrepo.SearchProduct(id_search);
                        foreach (var s in p2)
                        {
                            Console.WriteLine("Product Id: " + s.pid + " Product Name: " + s.name + " Description: " + s.description + " Price: " + s.price);

                        }
                        break;
                      */
                    case 6:
                        return;
                        
                }
            }
        }
    }
}

