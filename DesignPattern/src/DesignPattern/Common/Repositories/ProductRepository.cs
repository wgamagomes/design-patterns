using DesignPattern.Common.Entities;
using DesignPattern.Common.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPattern.Repositories.Common
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            yield return new Product { Name = "Phone", Price = 587 , Id = Guid.NewGuid()};
            yield return new Product { Name = "Tablet", Price = 800, Id = Guid.NewGuid() };
            yield return new Product { Name = "PC", Price = 1200, Id = Guid.NewGuid() };
        }
    }
}
