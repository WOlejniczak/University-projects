using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Geo
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private bool draggingMarker = false;     
        double lat = 0, lng = 0;
        private Point startPoint = new Point(0, 0);           
        private PointLatLng moveMarker = new PointLatLng(0,0);      
        XmlWrapper wrapper = new XmlWrapper();
        List<Punkt> punkty = new List<Punkt>();
        FileMetadata filemetadata = new FileMetadata();
        GMapMarker lastClickedMarker;
        


        public Form1()
        {
            InitializeComponent();
            LoadButton.FlatStyle = FlatStyle.Flat;
            LoadButton.FlatAppearance.BorderSize = 0;
            LoadButton.BackColor = System.Drawing.Color.Gray;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.BackColor = System.Drawing.Color.Gray;
            Graphs.FlatStyle = FlatStyle.Flat;
            Graphs.FlatAppearance.BorderSize = 0;
            Graphs.BackColor = System.Drawing.Color.Gray;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.BackColor = System.Drawing.Color.Gray;
            MaximalizeButton.FlatStyle = FlatStyle.Flat;
            MaximalizeButton.BackColor = System.Drawing.Color.Gray;
            MaximalizeButton.FlatAppearance.BorderSize = 0;
            MinimalizeButton.FlatStyle = FlatStyle.Flat;
            MinimalizeButton.BackColor = System.Drawing.Color.Gray;
            MinimalizeButton.FlatAppearance.BorderSize = 0;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            map.Position = new GMap.NET.PointLatLng(51.76, 19.45);
            map.DragButton = MouseButtons.Right;
            map.MapProvider = GMapProviders.GoogleMap;
            map.MinZoom = 10;
            map.MaxZoom = 100;
            map.Zoom = 10;
            map.ShowCenter = false;
            AddPanel.Visible = false;
            EditPanel.Visible = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "GPX files (*.gpx)|*.gpx";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {   //wczytanie punktów, w przyszłości wyświetlenie na mapie
                wrapper.SetPath(openFileDialog.FileName);
                punkty = wrapper.ReadTrk();
                FileMetadata filemetadata = wrapper.ReadMetadata();
                DrawTrk(punkty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = "C:\\";
            saveFileDialog.Filter = "GPX files (*.gpx)|*.gpx";
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {   //zapis danych do pliku
                wrapper.SaveFile(saveFileDialog.FileName, filemetadata, punkty);
            }
        }

        private void Graphs_Click(object sender, EventArgs e)
        {
            Wykresy wykresy = new Wykresy(punkty, lastClickedMarker); // przekazuję parametry do okna wykresów
            wykresy.StartPosition = FormStartPosition.CenterParent;
            wykresy.ShowDialog(this); //pokazuję tak żeby mieć dobrego parenta (to okno)
        }

        private void DrawTrk(List<Punkt> x)
        {
            map.Overlays.Clear();
            GMapOverlay linie = new GMapOverlay("droga");
            GMapOverlay punkty = new GMapOverlay("Punkty");
            for (int i = 0; i < x.Count - 1; i++)
            {
                Punkt marker = x[i];
                Punkt nextMarker = x[i + 1];
                List<PointLatLng> points = new List<PointLatLng>();
                points.Add(new PointLatLng(marker.GetLat(), marker.GetLon()));
                points.Add(new PointLatLng(nextMarker.GetLat(), nextMarker.GetLon()));
                GMap.NET.WindowsForms.GMapPolygon polygon = new GMap.NET.WindowsForms.GMapPolygon(points, "przebyta droga");
                polygon.Fill = new SolidBrush(System.Drawing.Color.FromArgb(0, System.Drawing.Color.Red));
                polygon.Stroke = new System.Drawing.Pen(System.Drawing.Color.Red, 2);
                linie.Polygons.Add(polygon);
                punkty.Markers.Add(new GMarkerGoogle(new PointLatLng(marker.GetLat(), marker.GetLon()), GMarkerGoogleType.blue_dot)); //tutaj można zmienić styl markera :)
            }
            map.Overlays.Add(punkty);
            map.Overlays.Add(linie);
        }


        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            lastClickedMarker = item; // oznaczam jako ostatnio wybrany element
                      
            if (e.Button == MouseButtons.Right)
            {
                contextMenu.Show(map,e.Location); //pokazuje menu kontextowe  
            }
            if (e.Button == MouseButtons.Left);
            {                
                draggingMarker = true;    //oznaczenie kliknięcia markera                                                       
            }                   
        }
    
        private void map_OnMapClick(object sender, MouseEventArgs e)
        {
            //wczytanie koordynatów kliknięcia
            lat = map.FromLocalToLatLng(e.X, e.Y).Lat;
            lng = map.FromLocalToLatLng(e.X, e.Y).Lng;            
            if (draggingMarker && e.Button == MouseButtons.Left)
              {                     
                    moveMarker = new PointLatLng(lat, lng);  //przypisanie markerowi koordynatów                  

                    for(int i=0;i < punkty.Count; i++)
                    {
                        if(punkty[i].GetLat() == lastClickedMarker.Position.Lat && punkty[i].GetLon() == lastClickedMarker.Position.Lng)
                        {       
                               //przypisanie nowych koordynatów markera do punktu i wyświetlenie
                               punkty[i].SetLat(moveMarker.Lat);
                               punkty[i].SetLon(moveMarker.Lng); 
                               draggingMarker = false;
                               DrawTrk(punkty);
                        }                
                    }
                   
              }
        }

             
        private void RemoveSelected_Click(object sender, EventArgs e) //usuwa wybrany punkt
        {
           for(int i=0;i < punkty.Count; i++)
            {
                if(punkty[i].GetLat() == lastClickedMarker.Position.Lat && punkty[i].GetLon() == lastClickedMarker.Position.Lng)
                {
                    punkty.RemoveAt(i);
                    DrawTrk(punkty);
                }
            }
        }

        private void RemoveAllPrev_Click(object sender, EventArgs e)
        {
            
            for(int i = 0; i < punkty.Count; i++)
            {
                if(punkty[i].GetLat() == lastClickedMarker.Position.Lat && punkty[i].GetLon() == lastClickedMarker.Position.Lng)
                {
                    
                    DrawTrk(punkty);
                    return;
                }
                punkty.RemoveAt(0);
                
            }
        }

        private void RemoveAllNext_Click(object sender, EventArgs e)
        {
            Boolean after = false;
            for (int i = 0; i < punkty.Count; i++)
            {
                if(after == true)
                {
                    punkty.RemoveAt(i);
                }
                if (punkty[i].GetLat() == lastClickedMarker.Position.Lat && punkty[i].GetLon() == lastClickedMarker.Position.Lng)
                {
                    after = true;
                }
            }
            DrawTrk(punkty);
        }

        private void AddOnePrev_Click(object sender, EventArgs e)
        {

        }

        private void EditSelected_Click(object sender, EventArgs e)
        {
            EditPanel.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            EditPanel.Visible = true;
            for(int i = 0; i < punkty.Count; i++)
            {
                if(punkty[i].GetLat() == lastClickedMarker.Position.Lat && punkty[i].GetLon() == lastClickedMarker.Position.Lng)
                {
                    EditEle.Value = (decimal)punkty[i].GetEle();

                }
            }
        }

        

        private void AddOneNext_Click(object sender, EventArgs e)
        {

        }

        
    }
}

