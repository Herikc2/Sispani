using System;

namespace Sispani.Model.Class
{
    public class BillItem
    {
        public string ID { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public Sale sale { get; set; }

        public BillItem(string iD, DateTime date, double total, Sale sale)
        {
            ID = iD;
            Date = date;
            Total = total;
            this.sale = sale;
        }

        public BillItem(DateTime date, double total, Sale sale)
        {
            Date = date;
            Total = total;
            this.sale = sale;
        }

        public BillItem(DateTime date, double total)
        {
            Date = date;
            Total = total;
        }
    }
}
