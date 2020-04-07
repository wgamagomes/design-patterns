using DesignPattern.Structural.Decorator.Order.Repositories;

namespace DesignPattern.Structural.Decorator.Order
{
    public abstract class OrderBase
    {
        private readonly IProductRepository _repository;

        public OrderBase(IProductRepository repository)
        {
            _repository = repository;
        }
       
        public abstract double CalculateTotalOrderPrice();
    }
}
