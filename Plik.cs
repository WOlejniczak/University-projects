using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using U8Xml;

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
            this.text = x;
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

    public class XmlWrapper
    {
        String path = "";

        public XmlWrapper(string path)
        {
            this.path = path;
        }

        public List<Punkt> ReadTrk()
        {
            List<Punkt> punkty = new List<Punkt>();
            using (XmlObject xml = XmlParser.ParseFile(path))
            {
                
                
                U8Xml.XmlNode root = xml.Root;
                U8Xml.XmlNode trkseg = root.Descendants.Find("trkseg");
                
                foreach (U8Xml.XmlNode node in trkseg.Children)
                {

                    Punkt punkt = new Punkt();
                    if (node.Name == "trkpt")
                    {
                        foreach(U8Xml.XmlNode newnode in node.Children)
                        {
                            if (newnode.Name == "ele")
                            {
                                // Console.WriteLine(node.InnerText);
                                punkt.SetEle(Double.Parse(newnode.InnerText.ToString().Replace('.',',')));
                            }
                            if (newnode.Name == "time")
                            {
                                // Console.WriteLine(node.InnerText);
                                punkt.SetTime(DateTime.Parse(newnode.InnerText.ToString().Replace('.', ',')));
                            }
                        }
                        // Console.WriteLine(node.Attributes.Find("lat").Value);
                        // Console.WriteLine(node.Attributes.Find("lon").Value);
                        punkt.SetLat(Double.Parse(node.Attributes.Find("lat").Value.ToString().Replace('.', ',')));
                        punkt.SetLon(Double.Parse(node.Attributes.Find("lon").Value.ToString().Replace('.', ',')));
                    }
                    
                    punkty.Add(punkt);
                }
            }
            return punkty;
        }
        public FileMetadata ReadMetadata()
        {
            FileMetadata output = new FileMetadata();
            using (XmlObject xml = XmlParser.ParseFile(path))
            {
                U8Xml.XmlNode root = xml.Root;
                U8Xml.XmlNode metadata = root.Children.First();
                foreach (U8Xml.XmlNode node in metadata.Descendants)
                {
                    if (node.Name == "link")
                    {
                       // Console.WriteLine(node.Attributes.First());
                        output.SetLink(node.Attributes.First().Value.ToString());
                    }
                    if (node.Name == "text")
                    {
                       // Console.WriteLine(node.InnerText);
                        output.SetText(node.InnerText.ToString());
                    }
                    if (node.Name == "time")
                    {
                       // Console.WriteLine(node.InnerText);
                        output.SetTime(DateTime.Parse(node.InnerText.ToString()));
                    }
                }
            }
            return output;
        }
    }
}
