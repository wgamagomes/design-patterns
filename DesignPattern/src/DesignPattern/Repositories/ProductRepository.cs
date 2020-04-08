using DesignPattern.Entities;
using DesignPattern.Interfaces;
using System.Collections.Generic;

namespace DesignPattern.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            yield return new Product { Name = "Phone", Price = 587 };
            yield return new Product { Name = "Tablet", Price = 800 };
            yield return new Product { Name = "PC", Price = 1200 };
        }
    }
}
