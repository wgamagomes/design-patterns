using DesignPattern.Interfaces;
using System.Linq;

namespace DesignPattern.Structural.Decorator.Order
{
    public class RegularOrder : OrderBase
    {
        public RegularOrder(IProductRepository repository)
            : base(repository)
        {

        }
        public override double CalculateTotalOrderPrice()
        {   
            return _repository
                .GetAll()
                .ToList()
                .Sum(x => x.Price);
        }
    }
}
