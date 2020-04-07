using DesignPattern.Structural.Decorator.Order.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Decorator.Order
{
    public class PremiumPreorder : OrderDecorator
    {
        public PremiumPreorder(OrderBase order , IProductRepository repository)
            : base(order, repository)
        {
        }

        public override double CalculateTotalOrderPrice()
        {
            return base.CalculateTotalOrderPrice() * 0.9;
        }
    }
}
