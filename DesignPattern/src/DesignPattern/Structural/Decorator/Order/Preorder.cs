using DesignPattern.Common.Interfaces;
using System.Linq;

namespace DesignPattern.Structural.Decorator.Order
{
    public class Preorder : OrderBase
    {
        public Preorder(IProductRepository repository)
        : base(repository)
        {

        }

        public override double CalculateTotalOrderPrice()
        {          
            return _repository
                .GetAll()
                .ToList()
                .Sum(x => x.Price) * 0.9;
        }
    }
}
