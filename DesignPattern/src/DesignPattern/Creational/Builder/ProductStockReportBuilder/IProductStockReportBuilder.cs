namespace DesignPattern.Creational.Builder.ProductStockReportBuilder
{
    public interface IProductStockReportBuilder
    {
        IProductStockReportBuilder WithHeader();
        IProductStockReportBuilder WithBody();
        IProductStockReportBuilder WithFooter();
        ProductStockReport Build();
    }
}
