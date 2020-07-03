using System.Collections.Generic;

namespace Sispani.Model
{
    public class Bill
    {
        public List<BillItem> Items;

        public Bill(List<BillItem> items)
        {
            Items = items;
        }

        public double GetTotal()
        {
            double total = 0D;
            foreach (BillItem bt in Items)
            {
                total += bt.Total;
            }
            return total;
        }
    }
}
