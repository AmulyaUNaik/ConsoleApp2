using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Repository
{
       
        interface IProductRepo
        {
            public void Addproduct(Product product);
            public void DeleteProduct(int pid);
            public List<Product> GetProduct();

            public void UpdateProduct(int pid, Product product);

    //    public List<Product> SearchProduct(int pid);

          

        }
       
    
}
