using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sispani.Model.Class.Validations
{
    public class ValidationItem
    {

        public string Value { get; set; }
        public string ValueName { get; set; }

        public ValidationItem(string value, string valueName)
        {
            Value = value;
            ValueName = valueName;
        }
    }
}
