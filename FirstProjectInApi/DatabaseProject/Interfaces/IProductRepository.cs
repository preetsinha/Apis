using DatabaseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetProduct();

        Product GetProduct(int id);

        Product AddProduct(Product product);

        Product DeleteProduct(int id);
    }
}
