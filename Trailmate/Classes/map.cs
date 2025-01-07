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
        }

        private void initializeMap()
        {
            mapControl = new GMapControl
            {
                Dock = DockStyle.Fill,
                MapProvider = GMapProviders.GoogleSatelliteMap,
                MinZoom = 2,
                MaxZoom = 18,
                Zoom = 40,
                Position = new PointLatLng(37.9838, 23.7275),
                ShowCenter = false,
                DragButton = MouseButtons.Left

            };

            tabPage.Controls.Add(mapControl);

        }

        private void initializeMarkers()
        {
            markersOverlay = new GMapOverlay("markers");
            mapControl.Overlays.Add(markersOverlay);

            PointLatLng point1 = new PointLatLng(37.7749, -122.4194);

            GMarkerGoogle marker = new GMarkerGoogle(point1, GMarkerGoogleType.red_dot)
            {
                ToolTipText = "San Francisco",
                ToolTipMode = MarkerTooltipMode.OnMouseOver
            };

            markersOverlay.Markers.Add(marker);
        }
    }
}
