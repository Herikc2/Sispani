using System;
using System.Data;

namespace Sispani.Model.DAO
{
    public class ReportDAO
    {
        public static DataTable Select(DateTime start, DateTime end)
        {
            string cmd = string.Format("select * from selecionar_todas_vendas_periodo('{0}','{1}')", start, end);
            return GenericDAO.Select(cmd);
        }
    }
}
