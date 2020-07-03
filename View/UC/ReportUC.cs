using Sispani.Controller;
using Sispani.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sispani.View.UC
{
    public partial class ReportUC : UserControl
    {
        public ReportUC()
        {
            InitializeComponent();
        }

        private void ReportUC_Load(object sender, EventArgs e)
        {
            InitialData();
        }

        public void InitialData()
        {
            List<Revenue> revenues = ReportController.Select(DateTime.Now.AddDays(-30), DateTime.Now);
            GenerateGrafic(revenues);
        }

        private void GenerateGrafic(List<Revenue> revenues)
        {
            for (int i = 0; i < revenues.Count - 1; i++)
            {
                if (revenues[i].Date > revenues[i + 1].Date)
                {
                    Revenue aux = revenues[i];
                    revenues[i] = revenues[i + 1];
                    revenues[i + 1] = aux;
                }
            }

            // Grafico pagina inicial
            chtLastMonthSale.Legends.Clear();
            chtLastMonthSale.Series[0].ChartType = SeriesChartType.Range;
            chtLastMonthSale.Series[0].Color = Color.Gray;

            if (revenues != null)
            {
                foreach (Revenue r in revenues)
                    chtLastMonthSale.Series[0].Points.AddXY(r.Date, r.GetTotal());
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<Revenue> revenues = ReportController.Select(dtpStart.Value, dtpEnd.Value);
            if(revenues != null)
            {
                GenerateGrafic(revenues);
                double totalMoney = 0D;
                double totalCard = 0D;
                double totalTerm = 0D;
                double total;

                foreach (Revenue r in revenues)
                {
                    totalMoney += r.TotalMoney;
                    totalCard += r.TotalCard;
                    totalTerm += r.TotalTerm;
                }
                total = totalMoney + totalCard + totalTerm;

                lblMoney.Text = totalMoney.ToString("N2");
                lblCard.Text = totalCard.ToString("N2");
                lblTerm.Text = totalTerm.ToString("N2");
                lblTotal.Text = total.ToString("N2");
                gbcReportSales.Text = "Vendas totais no periodo solicitado";
            }
            else
            {

                MessageBox.Show("Erro ao carregar dados.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                //MessageBox.Show("Erro: RUC.\nPor favor contate o suporte.");
            }
        }
    }
}
