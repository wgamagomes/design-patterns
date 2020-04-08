namespace DesignPattern.Creational.Builder.ProductStockReport
{
    public interface IProductStockReportBuilder
    {
        IProductStockReportBuilder WithHeader();
        IProductStockReportBuilder WithBody();
        IProductStockReportBuilder WithFooter();
        ProductStockReport Build();
    }
}
