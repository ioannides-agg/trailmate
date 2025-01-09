using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trailmate.Classes
{
    internal class FoodItem
    {
        public string item {  get; private set; }
        public double price { get; private set; }
        private MaterialButton owner;


        public FoodItem(string _item, double _price, MaterialButton _owner) { 
            item = _item;
            price = _price;
            owner = _owner;

            owner.Tag = this;
        }
    }
}
