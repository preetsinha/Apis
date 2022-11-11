using DatabaseProject.DatabaseContext;
using DatabaseProject.Interfaces;
using DatabaseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseProject.Repositories
{

    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _ProductContext;

        public ProductRepository(ProductContext productContext)
        {
            _ProductContext = productContext;
        }

        public List<Product> GetProduct()
        {
            var ListProduct = _ProductContext.Product.ToList();
            return ListProduct;
        }

        public Product GetProduct(int id)
        {
            var product = _ProductContext.Product.FirstOrDefault(x => x.ProductId == id);
            return product;
        }

        public Product AddProduct(Product product)
        {
            _ProductContext.Product.Add(product);
            _ProductContext.SaveChanges();
            return product;
        }

        public Product DeleteProduct(int id)
        {
            var product = _ProductContext.Product.Remove(x => x.ProductId == id);
            return product;
        }

    }

}
