using System;

namespace Sispani.Model
{
    public class BillItem
    {
        public string ID { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public Sale Sale { get; set; }

        public BillItem(string iD, DateTime date, double total, Sale sale)
        {
            ID = iD;
            Date = date;
            Total = total;
            Sale = sale;
        }

        public BillItem(DateTime date, double total, Sale sale)
        {
            Date = date;
            Total = total;
            Sale = sale;
        }

        public BillItem(DateTime date, double total)
        {
            Date = date;
            Total = total;
        }
    }
}
