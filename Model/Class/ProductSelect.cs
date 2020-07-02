using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sispani.Model.Class
{
    class ProductSelect : Product
    {
        public ProductSelect(string barCode, string name, string description, string stock, string unity, string cost, string sale)
        {
            BarCode = barCode;
            Name = name;
            Description = description;
            Stock = stock;
            Unity = unity;
            Cost = cost;
            Sale = sale;
        }
    }
}
