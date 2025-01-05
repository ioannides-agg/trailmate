using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Trailmate
{
    public partial class Form1 : MaterialForm
    {
        GMapControl mapControl;
        public Form1()
        {

            InitializeComponent();
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);

            skin.Theme = MaterialSkinManager.Themes.LIGHT;
            skin.ColorScheme = new ColorScheme(
                    Primary.Blue400,
                    Primary.Blue300,
                    Primary.Blue300,
                    Accent.Blue100,
                    TextShade.WHITE
                );

            //setup map
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

            setupPage.Controls.Add(mapControl);
        }
    }
}
