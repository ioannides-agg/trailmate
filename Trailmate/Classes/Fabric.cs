using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trailmate.Classes
{
    internal class Fabric
    {
        public string name { get; private set; }
        public string description { get; private set; }

        public Bitmap img { get; private set; }

        PictureBox owner;

        public Fabric(string _name, string _desc, Bitmap _img, PictureBox _owner) { 
            this.name = _name;
            this.description = _desc;
            this.img = _img;
            this.owner = _owner;

            owner.Tag = this;
        }
    }
}
