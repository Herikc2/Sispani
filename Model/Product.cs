namespace Sispani.Model
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Unity { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }

        public Product(string barCode, string description, int stock, string unity, double cost, double sale)
        {
            Code = barCode;
            Name = description;
            Amount = stock;
            Unity = unity;
            CostPrice = cost;
            SalePrice = sale;
        }

        public Product(string barCode, string description, int stock, string unity, double sale)
        {
            Code = barCode;
            Name = description;
            Amount = stock;
            Unity = unity;
            SalePrice = sale;
        }
    }
}
