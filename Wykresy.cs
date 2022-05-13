using GeoSpatial4Net;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Geo
{
    public partial class Wykresy : Form
    {
        List<Punkt> LocalPunkty = new List<Punkt>();
        GMapMarker lastClickedMarker;
        public Wykresy(List<Punkt> punkty, GMapMarker _lastClickedMarker)
        {
            InitializeComponent();
            LocalPunkty = punkty;
            lastClickedMarker = _lastClickedMarker;
        }

        private void Wykresy_Load(object sender, EventArgs e)
        {

            //wykres wysokosci
            WykresEle.Series.Clear();
            WykresEle.Titles.Add("Średnia wysokość (n.p.m)");
            Series seria = WykresEle.Series.Add("Średnia wysokość (n.p.m)");
            seria.ChartType = SeriesChartType.Line;
            seria.MarkerStyle = MarkerStyle.Circle;

            //teraz dodaje do serii
            double minimum = 10000000000000000000;
            double maximum = -1000000000000000000;
            int counter = 0;
            foreach (Punkt punkt in LocalPunkty)
            {

                if (punkt.GetEle() < minimum)
                {
                    minimum = punkt.GetEle();
                }
                if (punkt.GetEle() > maximum)
                {
                    maximum = punkt.GetEle();
                }
                seria.Points.AddXY(punkt.GetTimeOnly(), punkt.GetEle());
                counter++;

                if (lastClickedMarker != null)
                {
                    if (punkt.GetLat() == lastClickedMarker.Position.Lat && punkt.GetLon() == lastClickedMarker.Position.Lng)
                    {
                        seria.Points[counter - 1].MarkerStyle = MarkerStyle.Circle;
                        seria.Points[counter - 1].MarkerSize = 10;
                        seria.Points[counter - 1].MarkerColor = Color.Red;

                    }
                }


            }
            //ustawiam zakres wykresu
            WykresEle.ChartAreas[0].AxisY.Maximum = maximum + 10;
            WykresEle.ChartAreas[0].AxisY.Minimum = minimum - 10;
            //zaznaczam ostatnio kliknięty element na wykresie




            //wykres sredniej predkosci

            WykresPr.Series.Clear();
            WykresPr.Titles.Add("Średnia prędkość (km/h)");
            Series seriaPr = WykresPr.Series.Add("Średnia prędkość (km/h)");
            seriaPr.ChartType = SeriesChartType.Spline;

            //teraz dodaje do serii
            for (int i = 1; i < LocalPunkty.Count - 1; i++)
            {
                Punkt punkt = LocalPunkty.ElementAt(i);
                Punkt nextpunkt = LocalPunkty.ElementAt(i + 1);
                var distCalc = new GeoDistanceCalculator(DistanceUnit.Kilometer);
                double odleglosc = distCalc.HaversineDistance(punkt.GetLat(), punkt.GetLon(), nextpunkt.GetLat(), nextpunkt.GetLon());
                double czas = (DateTime.Parse(punkt.GetTimeOnly()) - DateTime.Parse(nextpunkt.GetTimeOnly())).Duration().Seconds;
                double predkosc = odleglosc / (czas / 3600);
                if (czas > 0)
                {

                    seriaPr.Points.AddXY(punkt.GetTimeOnly(), predkosc);
                    if (lastClickedMarker != null)
                    {
                        if (punkt.GetLat() == lastClickedMarker.Position.Lat && punkt.GetLon() == lastClickedMarker.Position.Lng)
                        {
                            seriaPr.Points[i - 1].MarkerStyle = MarkerStyle.Circle;
                            seriaPr.Points[i - 1].MarkerSize = 10;
                            seriaPr.Points[i - 1].MarkerColor = Color.Red;

                        }
                    }

                }
            }
        }
    }
}
