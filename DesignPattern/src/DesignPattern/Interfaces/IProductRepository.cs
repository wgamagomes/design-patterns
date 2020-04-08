using DesignPattern.Entities;
using System.Collections.Generic;

namespace DesignPattern.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
