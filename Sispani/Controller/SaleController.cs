using Sispani.Model;
using Sispani.Model.Class;
using System;
using System.Collections.Generic;
using System.Data;

namespace Sispani.Controller
{
    public class SaleController
    {
        public static List<Sale> Select(DateTime start, DateTime end)
        {
            DataTable source = SaleDAO.Select(start, end);

            List<Sale> sale = new List<Sale>();

            if (source != null) 
                for (int i = 0; i < source.Rows.Count; i++)
                    sale.Add(new Sale(Convert.ToDateTime(source.Rows[i][0].ToString()), double.Parse(source.Rows[i][1].ToString()), double.Parse(source.Rows[i][2].ToString())));
            
            return sale;
        }

        public static bool Insert(DateTime date, Customer customer, string money, string card)
        {
            return BillPaymentDAO.Insert(new BillPayment(customer, date, double.Parse(money), double.Parse(card)));
        }

        public static bool Insert(DataTable source, Customer customer, string money, string card, string term)
        {
            List<SaleItem> saleItem = new List<SaleItem>();

            for (int i = 0; i < source.Rows.Count; i++)
                saleItem.Add(new SaleItem(source.Rows[i][1].ToString(), int.Parse(source.Rows[i][3].ToString())));

            DateTime date = DateTime.Now;
            double termD = double.Parse(term);

            Sale sale = new Sale(date, customer, double.Parse(money), double.Parse(card), saleItem);

            if (termD > 0)
            {
                BillItem billItem = new BillItem(date, termD, sale);
                return SaleDAO.Insert(billItem);
            }
            else
                return SaleDAO.Insert(sale);
        }
    }
}
