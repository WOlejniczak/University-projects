using GeoSpatial4Net;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private double rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }
        private double deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }
        private double distance(double lat1, double lon1, double lat2, double lon2, char unit)
        {
            if ((lat1 == lat2) && (lon1 == lon2))
            {
                return 0;
            }
            else
            {
                double theta = lon1 - lon2;
                double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
                dist = Math.Acos(dist);
                dist = rad2deg(dist);
                dist = dist * 60 * 1.1515;
                if (unit == 'K')
                {
                    dist = dist * 1.609344;
                }
                else if (unit == 'N')
                {
                    dist = dist * 0.8684;
                }
                return (dist);
            }
        }
        private void Wykresy_Load(object sender, EventArgs e)
        {
            //wykres wysokosci
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
                if (punkt.GetEle() < minimum)
                {
                    minimum = punkt.GetEle();
                }
                if (punkt.GetEle() > maximum)
                {
                    maximum = punkt.GetEle();
                }
            }
            //ustawiam zakres wykresu
            WykresEle.ChartAreas[0].AxisY.Maximum = maximum + 10;
            WykresEle.ChartAreas[0].AxisY.Minimum = minimum - 10;

            //wykres sredniej predkosci

            WykresPr.Series.Clear();
            WykresPr.Titles.Add("Średnia prędkość (km/h)");
            Series seriaPr = WykresPr.Series.Add("Średnia prędkość (km/h)");
            seriaPr.ChartType = SeriesChartType.Spline;

            //teraz dodaje do serii
            for (int i = 0; i < LocalPunkty.Count - 1; i++)
            {
                Punkt punkt = LocalPunkty.ElementAt(i);
                Punkt nextpunkt = LocalPunkty.ElementAt(i + 1);
                var distCalc = new GeoDistanceCalculator(DistanceUnit.Kilometer);
                double odleglosc = distCalc.HaversineDistance(punkt.GetLat(), punkt.GetLon(), nextpunkt.GetLat(), nextpunkt.GetLon());
                double czas = (DateTime.Parse(punkt.GetTimeOnly()) - DateTime.Parse(nextpunkt.GetTimeOnly())).Duration().Seconds;
                double predkosc = odleglosc / (czas / 3600);
                if (czas > 0)
                {
                    Console.WriteLine(predkosc);
                    seriaPr.Points.AddXY(punkt.GetTimeOnly(), predkosc);
                }
            }
        }
    }
}
