using System;
using System.Collections.Generic;
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
        GMapControl mapControl;
        GMapOverlay markersOverlay;
        TabPage tabPage;

        public map(TabPage page)
        {
            tabPage = page;

            initializeMap();
            initializeMarkers();

            mapControl.OnMarkerClick += mapControl_OnMarkerClick;
            mapControl.OnMapClick += mapControl_OnMapClick;
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

        private void initializeMarkers()
        {
            markersOverlay = new GMapOverlay("markers");
            mapControl.Overlays.Add(markersOverlay);

            Marker Campsite1 = new Marker(new PointLatLng(38.196180, 23.736182), "Camp Site 1: 38.196180, 23.736182", markersOverlay,
                "320m", "Smooth", "Relatively flat", "1530 kg/m^3", "47%");

            Marker Campsite2 = new Marker(new PointLatLng(38.195464, 23.740821), "Camp Site 2: 38.195464, 23.740821", markersOverlay,
                "110m", "Smooth", "Flat", "1240 kg/m^3", "25%");

            Marker Campsite3 = new Marker(new PointLatLng(38.196708, 23.735236), "Camp Site 3: 38.196708, 23.735236", markersOverlay,
                "270m", "Rocky", "Relatively flat", "1900 kg/m^3", "31%");

            Marker Campsite4 = new Marker(new PointLatLng(38.193456, 23.746023), "Camp Site 4: 38.193456, 23.746023", markersOverlay,
                "490m", "Rocky", "Relatively flat", "1710 kg/m^3", "62%");

            Marker Campsite5 = new Marker(new PointLatLng(38.197821, 23.741660), "Camp Site 5: 38.197821, 23.741660", markersOverlay,
                "20m", "Smooth", "Flat", "1080 kg/m^3", "17%");
        }

        private void mapControl_OnMarkerClick(GMapMarker marker, MouseEventArgs e)
        {
            if (marker != null)
            {
                Marker markerData = marker.Tag as Marker;
                tabPage.Controls["groundInfoCard"].Visible = true;
                tabPage.Controls["groundInfoCard"].Controls["setAltitude"].Text = markerData.altitude;
                tabPage.Controls["groundInfoCard"].Controls["setTexture"].Text = markerData.texture;
                tabPage.Controls["groundInfoCard"].Controls["setFlatness"].Text = markerData.flatness;
                tabPage.Controls["groundInfoCard"].Controls["setDensity"].Text = markerData.density;
                tabPage.Controls["groundInfoCard"].Controls["setHumidity"].Text = markerData.humidity;
            }
        }

        private void mapControl_OnMapClick(PointLatLng point ,MouseEventArgs e)
        {
            tabPage.Controls["groundInfoCard"].Visible = false;
        }
    }
}
