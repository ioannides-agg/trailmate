using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trailmate.Classes
{
    public enum eventType
    {
        Concert,
        Trip,
        Workshop,
        Hike
    }

    internal class Event
    {
        public eventType type {  get; private set; }

        public string name { get; private set; }
        public string time { get; private set; }
        public string duration { get; private set; }
        public string venue { get; private set; }

        private MaterialButton owner;

        private MaterialButton goingBtn;
        public MaterialCheckbox checkbox { get; private set; }


        public Event(eventType _type, string _name, string _time, string _duration, string _venue, MaterialButton _owner, MaterialButton _goingBtn, MaterialCheckbox _checkbox)
        {
            type = _type;
            name = _name;
            time = _time;
            duration = _duration;
            venue = _venue;
            owner = _owner;

            owner.Tag = this;
            goingBtn = _goingBtn;
            checkbox = _checkbox;

            goingBtn.Tag = this;
        }
    }
}
