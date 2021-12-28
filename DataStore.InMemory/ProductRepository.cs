using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStore;

namespace DataStore.InMemory
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>()
            {
                new Product{ProductId=1,CategoryId=1,Name="Apple",Quantity=100,Price=20},
                new Product{ProductId=2,CategoryId=1,Name="Banana",Quantity=50,Price=40},
                new Product{ProductId=3,CategoryId=2,Name="Potato",Quantity=70,Price=10}
            };

        }
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
