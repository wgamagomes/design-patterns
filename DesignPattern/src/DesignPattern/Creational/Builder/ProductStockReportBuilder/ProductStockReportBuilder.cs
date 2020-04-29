using DesignPattern.Interfaces.Common;
using System;
using System.Linq;

namespace DesignPattern.Creational.Builder.ProductStockReportBuilder
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

        public IProductStockReportBuilder WithHeader()
        {
            _productStockReport.HeaderPart = $"STOCK REPORT FOR ALL THE PRODUCTS ON DATE: {DateTime.Now}\n";
            return this;
        }

        public IProductStockReportBuilder WithBody()
        {
            _productStockReport.BodyPart = string.Join(Environment.NewLine, _repository.GetAll().Select(p => $"Product name: {p.Name}, product price: {p.Price}"));
            return this;
        }

        public IProductStockReportBuilder WithFooter()
        {
            _productStockReport.FooterPart = "\nReport provided by the IT_PRODUCTS company.";
            return this;
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
