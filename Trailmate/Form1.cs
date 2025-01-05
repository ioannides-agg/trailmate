using MaterialSkin;
using MaterialSkin.Controls;

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
        }
    }
}
