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
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
        {
        Button btnSignUp;
        Button btnBack;
      
        protected override void OnCreate(Bundle savedInstanceState)
            {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Register);

            btnSignUp.Click += (Sender, e) =>
            {
                Intent LoginActivityIntent = new Intent(this, typeof(LoginActivity));
                StartActivity(LoginActivityIntent);
            };

            btnBack.Click += (Sender, e) =>
            {
                Intent LoginActivityIntent = new Intent(this, typeof(LoginActivity));
                StartActivity(LoginActivityIntent);
            };

            // Create your application here
            }
            }
    }