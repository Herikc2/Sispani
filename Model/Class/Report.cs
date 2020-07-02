using System.Collections.Generic;

namespace Sispani.Model
{
    public class Report
    {
        public List<Revenue> revenues { get; set; }

        public Report(List<Revenue> revenues)
        {
            this.revenues = revenues;
        }
    }
}
