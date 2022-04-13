using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Geo
{
    public partial class Wykresy : Form
    {
        List<Punkt> LocalPunkty = new List<Punkt>();
        public Wykresy(List<Punkt> punkty)
        {
            InitializeComponent();
            LocalPunkty = punkty;
        }

        private void Wykresy_Load(object sender, EventArgs e)
        {
            WykresEle.Series.Clear();
            WykresEle.Titles.Add("Średnia wysokość (n.p.m)");
            Series seria = WykresEle.Series.Add("Średnia wysokość (n.p.m)");
            seria.ChartType = SeriesChartType.Spline;

            //teraz dodaje do serii
            double minimum = 10000000000000000000;
            double maximum = -1000000000000000000;
            foreach (Punkt punkt in LocalPunkty)
            {
                seria.Points.AddXY(punkt.GetTimeOnly(), punkt.GetEle());
                if(punkt.GetEle() < minimum)
                {
                    minimum = punkt.GetEle();
                }
                if(punkt.GetEle() > maximum)
                {
                    maximum = punkt.GetEle();
                }
            }
            WykresEle.ChartAreas[0].AxisY.Maximum = maximum + 10;
            WykresEle.ChartAreas[0].AxisY.Minimum = minimum - 10;
        }
    }
}
