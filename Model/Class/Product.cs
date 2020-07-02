namespace Sispani.Model
{
    public class Product
    {
        public string BarCode { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Unity { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }

        // Derivativos
        public double Profit { get; set; }
        public double Percentage { get; set; }

        public Product(string barCode, string description, int stock, string unity, double cost, double sale)
        {
            BarCode = barCode;
            Description = description;
            Stock = stock;
            Unity = unity;
            CostPrice = cost;
            SalePrice = sale;           
        }

        public Product(string barCode, string description, int stock, string unity, double cost, double sale, double profit, double percentage)
        {
            BarCode = barCode;
            Description = description;
            Stock = stock;
            Unity = unity;
            CostPrice = cost;
            SalePrice = sale;
            Profit = profit;
            Percentage = percentage;
        }

        public Product(string barCode, string description, int stock, string unity, double sale)
        {
            BarCode = barCode;
            Description = description;
            Stock = stock;
            Unity = unity;
            SalePrice = sale;
        }
    }
}
