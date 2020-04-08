using DesignPattern.Repositories;
using System.Diagnostics;

namespace DesignPattern.Creational.Builder.ProductStockReport
{
    public class Usage
    {
        static void Main()
        {
            var builder = new ProductStockReportBuilder(new ProductRepository());
            var director = new ProductStockReportDirector(builder);
            var report = director.BuildStockReport();           
            Debug.WriteLine(report);
        }
    }
}
