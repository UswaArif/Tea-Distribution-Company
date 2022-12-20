using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace FinalProject
{
    public partial class RiderMap : Form
    {
        private List<PointLatLng> points;
        GMapMarker gMapDisplayAreaMarkerForWareHouse;
        PointLatLng pointforWareHouse;

        public static string SetValueForLatitude = "";
        public static string SetValueForLongitude = "";
        public RiderMap()
        {
            InitializeComponent();
            points = new List<PointLatLng>();
        }

        private void RiderMap_Load(object sender, EventArgs e)
        {
            gMapDisplayArea.DragButton = MouseButtons.Left;
            gMapDisplayArea.MapProvider = GMapProviders.OpenStreetMap;
            gMapDisplayArea.ShowCenter = false;
            gMapDisplayArea.MinZoom = 1; // zoom min manually 
            gMapDisplayArea.MaxZoom = 100;
            gMapDisplayArea.Zoom = 10;//by default

            gMapDisplayArea.SetPositionByKeywords("Lahore, Pakistan");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            points.Clear();
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            gMapDisplayArea.DragButton = MouseButtons.Left;
            //gMapDisplayArea.MapProvider = GMapProviders.BingMap;
            gMapDisplayArea.MapProvider = GMapProviders.OpenStreetMap;

            double lattitude = Convert.ToDouble(txtLatitude.Text);
            double longtitude = Convert.ToDouble(txtLongitude.Text);
            LoadMap(new GMap.NET.PointLatLng(lattitude, longtitude));
            AddMarker(new GMap.NET.PointLatLng(lattitude, longtitude));
            gMapDisplayArea.Position = new GMap.NET.PointLatLng(lattitude, longtitude);
            gMapDisplayArea.MinZoom = 1; // zoom min manually 
            gMapDisplayArea.MaxZoom = 100;
            gMapDisplayArea.Zoom = 10;//by default
            pointforWareHouse = new PointLatLng(lattitude, longtitude);
            //pointforCustomer = new PointLatLng(lattitude2, longtitude2);
            gMapDisplayAreaMarkerForWareHouse = new GMarkerGoogle(pointforWareHouse, GMarkerGoogleType.red_dot);// marker adding
            //gMapDisplayAreaMarkerForCustomer = new GMarkerGoogle(pointforCustomer, GMarkerGoogleType.blue_pushpin);
            //overlay to add marker, overlay having all the number of markers then add the overlay to the forms
            GMapOverlay markerCollection = new GMapOverlay("markers");
            markerCollection.Markers.Add(gMapDisplayAreaMarkerForWareHouse);
            //markerCollection.Markers.Add(gMapDisplayAreaMarkerForCustomer);
            gMapDisplayArea.Overlays.Add(markerCollection);
        }

        private void LoadMap(PointLatLng point)
        {
            gMapDisplayArea.Position = point;
        }

        private void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.red_dot)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd, markerType);
            markers.Markers.Add(marker);
            gMapDisplayArea.Overlays.Add(markers);
        }

        private void GetRoute_Click(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = AppConfig.Key;
            var route = GoogleMapProvider.Instance.GetRoute(points[0], points[1], false, false, 14);
            var newRoute = new GMapRoute(route.Points, "New Route")
            {
                Stroke = new Pen(Color.Red, 5)
            };
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(newRoute);
            gMapDisplayArea.Overlays.Add(routes);

            lblDistance.Text = route.Distance + "km";
        }

        private void addPoint_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(txtLatitude.Text);
            double l2 = Convert.ToDouble(txtLongitude.Text);
            PointLatLng p = new PointLatLng(l, l2);
            points.Add(p);
        }

        

        private List<String> GetAddress(PointLatLng point)
        {
            List<Placemark> placemarks = null;
            var statusCode = GMapProviders.OpenStreetMap.GetPlacemarks(point, out placemarks);
            if (statusCode == GeoCoderStatusCode.EXCEPTION_IN_CODE && placemarks != null)
            {
                List<String> addresses = new List<string>();
                foreach (var placemark in placemarks)
                {
                    addresses.Add(placemark.Address);
                }
                return addresses;
            }
            return null;
        }

        private void btnGetPosition1_Click(object sender, EventArgs e)
        {
            gMapDisplayArea.DragButton = MouseButtons.Left;
            gMapDisplayArea.MapProvider = GMapProviders.OpenStreetMap;
            gMapDisplayArea.ShowCenter = false;
            gMapDisplayArea.MinZoom = 1; // zoom min manually 
            gMapDisplayArea.MaxZoom = 100;
            gMapDisplayArea.Zoom = 10;//by default

            gMapDisplayArea.SetPositionByKeywords(txtPlace.Text.ToString());
        }

        private void gMapDisplayArea_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Mouse Click");
            if (chkMouseClick.Checked == true && e.Button == MouseButtons.Left)
            {
                //MessageBox.Show(e.X + " " + e.Y);
                var point = gMapDisplayArea.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                txtLatitude.Text = lat + "";
                txtLongitude.Text = lng + "";
                //To read data of latitude and longitude at form Add Rider
                SetValueForLatitude = txtLatitude.Text;
                SetValueForLongitude = txtLongitude.Text;

                //Load Location
                LoadMap(point);

                //Adding Marker
                AddMarker(point);

                //Get Address
                var addresses = GetAddress(point);

                //Display Address
                if (addresses != null)
                {
                    txtRichAddress.Text = "Address: \n" + addresses[0];
                }
                else
                {
                    txtRichAddress.Text = "Unable to Load Data";
                }
            }
        }
    }
}

//31.57783
//74.28800
//31.58921
//74.31060
