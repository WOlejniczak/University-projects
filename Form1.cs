using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsPresentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml;
using U8Xml;


namespace Geo
{
    public partial class Form1 : Form
    {

        double lat = 0;
        double lng = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map.Position = new GMap.NET.PointLatLng(51.76, 19.45);
            map.DragButton = MouseButtons.Right;
            map.MapProvider = GMapProviders.GoogleMap;
            map.MinZoom = 10;
            map.MaxZoom =100;
            map.Zoom = 10;
            map.ShowCenter = false;


        }

        private void map_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void map_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                lat = map.FromLocalToLatLng(e.X, e.Y).Lat;
                lng = map.FromLocalToLatLng(e.X, e.Y).Lng;
            }

            var point = new GMap.NET.PointLatLng(lat, lng);
            GMap.NET.WindowsForms.GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red);
           // map.Overlays.Clear();
            GMapOverlay markers = new GMapOverlay("markers");
            map.Overlays.Add(markers);      
            markers.Markers.Add(marker);

          

           
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlWrapper wrapper = new XmlWrapper("PlikDoTestow.gpx");
            List<Punkt> punkty = wrapper.ReadTrk();
            FileMetadata filemetadata = wrapper.ReadMetadata();

            Console.WriteLine(filemetadata.GetData()); //:)
            
            foreach(Punkt data in punkty)
            {
                Console.WriteLine(data.GetData());
            }
        }
    }
}
