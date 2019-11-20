using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MapActivity
    {
    class House
        {
        public long Id { get; set; }

        public double BendRoomNo { get; set; }

        public double BathRoomNo { get; set; }

        public string HouseAddress { get; set; }

        public double RentPerWeek { get; set; }
        }
    }