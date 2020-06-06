using Sispani.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Sispani.Controller
{
    public class ReportController
    {
        public static List<Revenue> Select(DateTime start, DateTime end)
        {
            DateTime start0 = start.AddHours(-DateTime.Now.Hour);
            DateTime end0 = end.AddHours(24 - DateTime.Now.Hour);
            DataTable source = ReportDAO.Select(start0, end0);

            List<Revenue> revenue = new List<Revenue>();

            if (source != null)
            {
                for (int i = 0; i < source.Rows.Count; i++)
                {
                    double totalMoney = double.Parse(source.Rows[i][1].ToString());
                    double totalCard = double.Parse(source.Rows[i][2].ToString());
                    double totalTerm = double.Parse(source.Rows[i][2].ToString());
                    DateTime date = Convert.ToDateTime(source.Rows[i][0].ToString());

                    revenue.Add(new Revenue(totalMoney, totalCard, totalTerm, date));
                }
            }

            return revenue;
        }
    }
}
