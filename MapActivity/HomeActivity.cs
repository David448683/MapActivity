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
    [Activity(Label = "HomeActivity")]
    public class HomeActivity : Activity
        {
        TextView username;
        protected override void OnCreate(Bundle savedInstanceState)
            {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Home);

            // Create your application here
            username = FindViewById<TextView>(Resource.Id.lblWelcome);
            username.Text = Intent.GetStringExtra("AccName");
            }
        }
    }

//HomeActivity//