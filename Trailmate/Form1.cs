using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using Trailmate.Classes;

namespace Trailmate
{
    public partial class Form1 : MaterialForm
    {
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

            map Map = new map(setupPage);
        }
    }
}
