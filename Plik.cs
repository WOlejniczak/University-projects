using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo
{
    public class FileMetadata
    {
        private string link;
        private string text;
        private DateTime time;

        public FileMetadata()
        {

        }

        public FileMetadata(string link, string text, DateTime time)
        {
            this.link = link;
            this.text = text;
            this.time = time;
        }

        public string GetLink()
        {
            return this.link;
        }
        public string GetText()
        {
            return this.text;
        }
        public DateTime GetTime()
        {
            return this.time;
        }
        public void SetLink(String x)
        {
            this.link = x;
        }
        public void SetText(String x)
        {
            this.link = x;
        }
        public void SetTime(DateTime x)
        {
            this.time = x;
        }
        public String GetData()
        {
            return "Link: " + this.link + " Text: " + this.text + "Time: " + this.time + "\n";
        }
    }


    public class Punkt //przechowuje punkty
    { 
        private double lat;
        private double lon;
        private double ele;
        private DateTime time;

        public Punkt(double lat, double lon, double ele, DateTime time)
        {
            this.lat = lat;
            this.lon = lon;
            this.ele = ele;
            this.time = time;
        }
        public Punkt(double lat, double lon, DateTime time)
        {
            this.lat = lat;
            this.lon = lon;
            this.ele = 0;
            this.time = time;
        }
        public Punkt(double lat, double lon, double ele)
        {
            this.lat = lat;
            this.lon = lon;
            this.ele = ele;
            this.time = DateTime.Parse("01/01/1980 00:00:00");
        }
        public Punkt()
        {

        }

        public String GetData()
        {
            return "Lat: " + this.lat + " Lon: " + this.lon + " Ele: " + this.ele + " Time: " + this.time + "\n";
        }
        public double GetLat()
        {
            return this.lat;
        }
        public double GetLon()
        {
            return this.lon;
        }
        public double GetEle()
        {
            return this.ele;
        }
        public DateTime GetTime()
        {
            return this.time;
        }
        public void SetLat(double x)
        {
            this.lat = x;
        }
        public void SetLon(double x)
        {
            this.lon = x;
        }
        public void SetEle(double x)
        {
            this.ele = x;
        }
        public void SetTime(DateTime x)
        {
            this.time = x;
        }
    }

    
}
