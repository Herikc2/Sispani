using System;

namespace Sispani.Model
{
    public class BillPayment
    {
        public Customer Customer { get; set; }
        public DateTime PaymentDate { get; set; }
        public double Money { get; set; }
        public double Card { get; set; }

        public BillPayment(Customer customer, DateTime paymentDate, double money, double card)
        {
            Customer = customer;
            PaymentDate = paymentDate;
            Money = money;
            Card = card;
        }
    }
}
