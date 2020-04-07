using DesignPattern.Structural.Decorator.Order.Entities;
using System.Collections.Generic;

namespace DesignPattern.Structural.Decorator.Order.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
