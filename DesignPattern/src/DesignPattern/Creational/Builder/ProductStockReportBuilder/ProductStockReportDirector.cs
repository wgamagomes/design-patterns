namespace DesignPattern.Creational.Builder.ProductStockReportBuilder
{
    public class ProductStockReportDirector
    {
        private readonly IProductStockReportBuilder _productStockReportBuilder;

        public ProductStockReportDirector(IProductStockReportBuilder productStockReportBuilder)
        {
            _productStockReportBuilder = productStockReportBuilder;
        }

        public ProductStockReport BuildStockReport()
        {
            return _productStockReportBuilder.WithHeader()
            .WithBody()
            .WithFooter()
            .Build();
        }
    }
}
