using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sispani.View.UC
{
    public partial class MainUC : UserControl
    {
        public MainUC()
        {
            InitializeComponent();
        }

        private void MainUC_Load(object sender, EventArgs e)
        {

        }

        public void LoadGraphic()
        {
            // Grafico pagina inicial
            //chartMainPage.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartMainPage.Series[0].Color = Color.Gray;

            chartMainPage.Series[0].Points.AddXY("15/12", 5390.79);
            chartMainPage.Series[0].Points.AddXY("16/12", 2240.23);
            chartMainPage.Series[0].Points.AddXY("17/12", 3232.41);
            chartMainPage.Series[0].Points.AddXY("18/12", 2666.36);
            chartMainPage.Series[0].Points.AddXY("19/12", 3232.11);
            chartMainPage.Series[0].Points.AddXY("20/12", 4666.38);
            chartMainPage.Series[0].Points.AddXY("21/12", 6258.52);
        }
    }
}
