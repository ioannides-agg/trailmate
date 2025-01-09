using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Trailmate.Classes
{
    public class Marker
    {
        PointLatLng point;
        string context;
        public string altitude {  get; private set; }
        public string texture { get; private set; }
        public string flatness { get; private set; }
        public string density { get; private set; }
        public string humidity { get; private set; }
        GMarkerGoogle marker;
        GMapOverlay markersOverlay;

        public Marker(PointLatLng _point,string _context, GMapOverlay _markersOverlay,
            string _altitude,
            string _texture,
            string _flatness,
            string _density,
            string _humidity) {
            
            point = _point;
            context = _context;
            markersOverlay = _markersOverlay;

            marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot)
            {
                ToolTipText = context,
                ToolTipMode = MarkerTooltipMode.OnMouseOver,
                Tag = this
            };

            markersOverlay.Markers.Add(marker);

            altitude = _altitude;
            texture = _texture;
            flatness = _flatness;
            density = _density;
            humidity = _humidity;
            

        }

        public GMarkerGoogle getMarker()
        {
            return marker;
        }

        public void changeContext(string text)
        {
            context = text;
            marker.ToolTipText = context;
        }
    }
}
