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
        GMarkerGoogle marker;

        public Marker(PointLatLng _point, string _context)
        {

            point = _point;
            context = _context;

            marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot)
            {
                ToolTipText = context,
                ToolTipMode = MarkerTooltipMode.OnMouseOver,
                Tag = this
            };

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

    public class CampMarker : Marker
    {
        public string altitude {  get; private set; }
        public string texture { get; private set; }
        public string flatness { get; private set; }
        public string density { get; private set; }
        public string humidity { get; private set; }

        public CampMarker(PointLatLng _point,string _context,
            string _altitude,
            string _texture,
            string _flatness,
            string _density,
            string _humidity) : base(_point, _context) {

            altitude = _altitude;
            texture = _texture;
            flatness = _flatness;
            density = _density;
            humidity = _humidity;
        }
    }
}
