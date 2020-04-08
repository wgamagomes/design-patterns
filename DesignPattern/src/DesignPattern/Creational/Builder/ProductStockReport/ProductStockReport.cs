namespace DesignPattern.Creational.Builder.ProductStockReport
{
    public class ProductStockReport
    {
        public string HeaderPart { get; set; }
        public string BodyPart { get; set; }
        public string FooterPart { get; set; }
        public override string ToString() => $"{HeaderPart} {BodyPart} {FooterPart}";           
    }
}
