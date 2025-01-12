using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Trailmate.Classes
{
    public class map
    {
        private GMapOverlay routesOverlay;
        public GMapControl mapControl { get; private set; }
        public GMapOverlay markersOverlay {  get; private set; }
        TabPage tabPage;

        public map(TabPage page)
        {
            tabPage = page;

            initializeMap();

            markersOverlay = new GMapOverlay("markers");
            mapControl.Overlays.Add(markersOverlay);

            mapControl.OnMarkerClick += mapControl_OnMarkerClick;
            mapControl.OnMapClick += mapControl_OnMapClick;

            routesOverlay = new GMapOverlay("routes");
            mapControl.Overlays.Add(routesOverlay);
        }

        private void initializeMap()
        {
            mapControl = new GMapControl
            {
                Dock = DockStyle.Fill,
                MapProvider = GMapProviders.GoogleSatelliteMap,
                MinZoom = 2,
                MaxZoom = 18,
                Zoom = 16,
                Position = new PointLatLng(38.195362, 23.737576),
                ShowCenter = false,
                DragButton = MouseButtons.Left

            };

            tabPage.Controls.Add(mapControl);

        }

        public void initializeMarkers(List<CampMarker> markers)
        {
            foreach (var marker in markers)
            {
                markersOverlay.Markers.Add(marker.getMarker());
            }
            mapControl.Refresh();
        }

        public void initializeMarkers(List<GMarkerGoogle> markers)
        {
            foreach (var marker in markers)
            {
                markersOverlay.Markers.Add(marker);
            }
            mapControl.Refresh();
        }

        public void initializeMarkers(CampMarker marker)
        {
            markersOverlay.Markers.Add(marker.getMarker());
            mapControl.Refresh();
        }

        public void clearMarkers() {
            markersOverlay.Clear();
        }

        private void mapControl_OnMarkerClick(GMapMarker marker, MouseEventArgs e)
        {
            if (marker != null)
            {
                CampMarker markerData = marker.Tag as CampMarker;
                tabPage.Controls["groundInfoCard"].Visible = true;
                tabPage.Controls["groundInfoCard"].Controls["setAltitude"].Text = markerData.altitude;
                tabPage.Controls["groundInfoCard"].Controls["setTexture"].Text = markerData.texture;
                tabPage.Controls["groundInfoCard"].Controls["setFlatness"].Text = markerData.flatness;
                tabPage.Controls["groundInfoCard"].Controls["setDensity"].Text = markerData.density;
                tabPage.Controls["groundInfoCard"].Controls["setHumidity"].Text = markerData.humidity;

                Form1.selectedCampsite = markerData;
            }
        }

        private void mapControl_OnMapClick(PointLatLng point ,MouseEventArgs e)
        {
            tabPage.Controls["groundInfoCard"].Visible = false;

            Form1.selectedCampsite = null;
        }

        public void setCamp()
        {
            mapControl.OnMarkerClick -= mapControl_OnMarkerClick;
            mapControl.OnMapClick -= mapControl_OnMapClick;
        }

        public void DrawRoute(PointLatLng start, PointLatLng end)
        {

            var route = new List<PointLatLng> { 
                start,
                new PointLatLng(start.Lat + 00.00018, start.Lng + 00.00049),
                new PointLatLng(start.Lat + 00.00048, start.Lng + 00.00109),
                new PointLatLng(end.Lat - 00.00073, end.Lng - 00.00084),
                new PointLatLng(end.Lat - 00.00023, end.Lng - 00.00014),
                end
            };

            var route2 = new List<PointLatLng> {
                start,
                new PointLatLng(start.Lat + 00.00024, start.Lng + 00.00032),
                new PointLatLng(start.Lat + 00.00073, start.Lng + 00.00099),
                new PointLatLng(end.Lat - 00.00173, end.Lng - 00.00044),
                new PointLatLng(end.Lat - 00.00013, end.Lng - 00.00034),
                end
            };

            var r = new GMapRoute(route, "Route to shelter")
            {
                Stroke = new Pen(Color.Red, 2)
            };

            var r2 = new GMapRoute(route2, "Alternate route to shelter")
            {
                Stroke = new Pen(Color.Blue, 2)
            };
            routesOverlay.Routes.Add(r);
            routesOverlay.Routes.Add(r2);
            mapControl.Refresh();
        }

        public void clearRoute()
        {
            routesOverlay.Clear();
        }
    }
}
