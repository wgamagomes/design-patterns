using DesignPattern.Common.Entities;
using System.Collections.Generic;

namespace DesignPattern.Interfaces.Common
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
