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
        Button btnMap;
        Button btnList;
        Button btnBluetooth;
        Button btnMessage;
        protected override void OnCreate(Bundle savedInstanceState)
            {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Home);

            // Create your application here
            username = FindViewById<TextView>(Resource.Id.lblWelcome);
            username.Text = Intent.GetStringExtra("AccName");

            btnMap = FindViewById<Button>(Resource.Id.btnMap);
            btnList = FindViewById<Button>(Resource.Id.btnList);
            btnBluetooth = FindViewById<Button>(Resource.Id.btnBluetooth);
            btnMessage = FindViewById<Button>(Resource.Id.btnMessage);

            btnMap.Click += (Sender, e) =>
            {
                Intent MainActivityIntent = new Intent(this, typeof(MainActivity));
                StartActivity(MainActivityIntent);
            };

            btnList.Click += (Sender, e) =>
            {
                Intent PlayQuoteActivityIntent = new Intent(this, typeof(PlayQuoteActivity));
                StartActivity(PlayQuoteActivityIntent);
            };

          



            }
        }
    }

//HomeActivity// //update 2.0//