using DesignPattern.Common.Repositories;
using System.Diagnostics;

namespace DesignPattern.Structural.Decorator.Order
{
    public class Usage
    {
        static void Main()
        {
            var repository = new ProductRepository();

            var regularOrder = new RegularOrder(repository);
            Debug.WriteLine(regularOrder.CalculateTotalOrderPrice());            

            var preOrder = new Preorder(repository);
            Debug.WriteLine(preOrder.CalculateTotalOrderPrice());          

            var premiumPreorder = new PremiumPreorder(preOrder, repository);
            Debug.WriteLine(premiumPreorder.CalculateTotalOrderPrice());
        }
    }
}
