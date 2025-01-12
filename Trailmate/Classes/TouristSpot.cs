using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trailmate.Classes
{
    internal class TouristSpot
    {
        public GMarkerGoogle marker { get; private set; }

        public static List<GMarkerGoogle> gMarkers = new List<GMarkerGoogle>();

        PointLatLng point;
        public string name { get; private set; }
        public string distance { get; private set; }
        public string rating { get; private set; }
        public string availability { get; private set; }

        MaterialLabel owner;

        public TouristSpot(PointLatLng point, string name, string distance, string rating, string availability, MaterialLabel owner)
        {
            this.point = point;
            this.name = name;
            this.distance = distance;
            this.rating = rating;
            this.availability = availability;
            this.owner = owner;

            this.marker = new GMarkerGoogle(point, GMarkerGoogleType.green_dot)
            {
                ToolTipText = name,
                ToolTipMode = MarkerTooltipMode.OnMouseOver
            };

            owner.Tag = this;

            gMarkers.Add(marker);
        }
    }
}
