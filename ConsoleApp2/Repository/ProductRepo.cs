using ConsoleApp2.DAL;
using ConsoleApp2.Models;
using ConsoleApp2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Repository
{
    internal class ProductRepo : IProductRepo
    {
        public void Addproduct(Product product)
        {
            ProductDAL.product.Add((product));
        }

        public void DeleteProduct(int pid)
        {
            ProductDAL.product.RemoveAll(m => m.pid == pid);

        }
        public List<Product> GetProduct()
        {
            return ProductDAL.product;
        }

        public void UpdateProduct(int pid , Product product)
        {

            Product p1 = (Product)ProductDAL.product.First(m => m.pid == pid);

            p1.name = product.name;

            p1.description = product.description;

            p1.price = product.price;
        }

      /*  public List<Product> SearchProduct(int pid)
        {
            var r = ProductDAL.product.Where(m => m.pid == pid);
            return r.ToList();
        }
      */

    }
}
