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

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal900, Primary.Teal800, Primary.Teal700, Accent.Teal700, TextShade.WHITE);

            map Map = new map(setupPage);
        }
    }
}
