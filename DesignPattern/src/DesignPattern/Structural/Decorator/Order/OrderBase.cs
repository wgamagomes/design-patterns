using DesignPattern.Interfaces;

namespace DesignPattern.Structural.Decorator.Order
{
    public abstract class OrderBase
    {
        protected readonly IProductRepository _repository;

        public OrderBase(IProductRepository repository)
        {
            _repository = repository;
        }
       
        public abstract double CalculateTotalOrderPrice();
    }
}
