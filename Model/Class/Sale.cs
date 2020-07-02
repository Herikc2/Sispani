using Sispani.Model.Class;
using System;
using System.Collections.Generic;

namespace Sispani.Model
{
    public class Sale
    {
        public string ID { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public double TotalMoney { get; set; }
        public double TotalCard { get; set; }
        public double Total { get; set; }

        public List<SaleItem> SaleItem_ = new List<SaleItem>();

        public Sale(DateTime data, Customer customer, double totalMoney, double totalCard, double total, List<SaleItem> saleItem)
        {
            Date = data;
            Customer = customer;
            TotalMoney = totalMoney;
            TotalCard = totalCard;
            Total = total;
            SaleItem_ = saleItem;
        }

        public Sale(DateTime data, Customer customer, double totalMoney, double totalCard, List<SaleItem> saleItem)
        {
            Date = data;
            Customer = customer;
            TotalMoney = totalMoney;
            TotalCard = totalCard;
            SaleItem_ = saleItem;
        }

        public Sale(string id, DateTime data, Customer customer, double totalMoney, double totalCard, double total, List<SaleItem> saleItem)
        {
            ID = id;
            Date = data;
            Customer = customer;
            TotalMoney = totalMoney;
            TotalCard = totalCard;
            Total = total;
            SaleItem_ = saleItem;
        }

        public Sale(string id, DateTime data, Customer customer, double totalMoney, double totalCard, double total)
        {
            ID = id;
            Date = data;
            Customer = customer;
            TotalMoney = totalMoney;
            TotalCard = totalCard;
            Total = total;
        }

        public Sale(DateTime date, double totalMoney, double totalCard)
        {
            Date = date;
            TotalMoney = totalMoney;
            TotalCard = totalCard;
        }

        public double GetTotal()
        {
            return TotalMoney + TotalCard;
        }
    }
}
