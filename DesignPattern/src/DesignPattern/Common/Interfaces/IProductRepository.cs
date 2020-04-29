using DesignPattern.Common.Entities;
using System.Collections.Generic;

namespace DesignPattern.Common.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
