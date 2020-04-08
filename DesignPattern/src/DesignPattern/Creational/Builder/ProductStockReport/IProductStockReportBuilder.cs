namespace DesignPattern.Creational.Builder.ProductStockReport
{
    public interface IProductStockReportBuilder
    {
        void WithHeader();
        void WithBody();
        void WithFooter();
        ProductStockReport Build();
    }
}
