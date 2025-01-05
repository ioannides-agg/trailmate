using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace Trailmate.Classes
{
    public class map
    {
        GMapControl mapControl;
        public map()
        {
            mapControl = new GMapControl
            {
                Dock = DockStyle.Fill,
                MapProvider = GMapProviders.GoogleMap,
                MinZoom = 2,
                MaxZoom = 18,
                Zoom = 10
            };

            mapControl.MapProvider = GMapProviders.GoogleMap; // Or OpenStreetMap, Bing, etc.
            mapControl.Position = new PointLatLng(37.9838, 23.7275); // Example: Athens, Greece
            mapControl.MinZoom = 2;
            mapControl.MaxZoom = 18;
            mapControl.Zoom = 10;
            mapControl.ShowCenter = false;
            mapControl.DragButton = MouseButtons.Left;
        }
    }
}
