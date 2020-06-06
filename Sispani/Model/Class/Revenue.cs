using System;

namespace Sispani.Model
{
    public class Revenue
    {
        public double TotalMoney { get; set; }
        public double TotalCard { get; set; }
        public double TotalTerm { get; set; }
        public DateTime Date { get; set; }

        public Revenue(double totalMoney, double totalCard, double totalTerm, DateTime date)
        {
            TotalMoney = totalMoney;
            TotalCard = totalCard;
            TotalTerm = totalTerm;
            Date = date;
        }

        public double GetTotal()
        {
            return TotalMoney + TotalCard + TotalMoney;
        }
    }
}
