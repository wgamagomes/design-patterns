using DesignPattern.Structural.Decorator.Order.Repositories;
using System;

namespace DesignPattern.Structural.Decorator.Order
{
    public class OrderDecorator : OrderBase
    {
        protected OrderBase order;

        public OrderDecorator(OrderBase order, IProductRepository repository):base(repository)
        {
            this.order = order;
        }

        public override double CalculateTotalOrderPrice()
        {           
            return order.CalculateTotalOrderPrice();
        }
    }
}
