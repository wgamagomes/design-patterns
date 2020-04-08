using DesignPattern.Interfaces;
using System;
using System.Linq;

namespace DesignPattern.Creational.Builder.ProductStockReport
{
    public class ProductStockReportBuilder : IProductStockReportBuilder
    {
        private ProductStockReport _productStockReport;
        private IProductRepository _repository;

        public ProductStockReportBuilder(IProductRepository  repository)
        {
            _repository = repository;
            _productStockReport = new ProductStockReport();
        }

        public void WithHeader()
        {
            _productStockReport.HeaderPart = $"STOCK REPORT FOR ALL THE PRODUCTS ON DATE: {DateTime.Now}\n";
        }

        public void WithBody()
        {
            _productStockReport.BodyPart = string.Join(Environment.NewLine, _repository.GetAll().Select(p => $"Product name: {p.Name}, product price: {p.Price}"));
        }

        public void WithFooter()
        {
            _productStockReport.FooterPart = "\nReport provided by the IT_PRODUCTS company.";
        }

        public ProductStockReport Build()
        {
            var productStockReport = _productStockReport;
            Clear();
            return productStockReport;
        }

        private void Clear() => _productStockReport = new ProductStockReport();
    }
}
