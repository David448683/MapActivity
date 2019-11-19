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
    [Activity(Label = "login")]
    public class LoginActivity : Activity
    {
        Button btnsignup;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            //back to login page//

            btnsignup = FindViewById<Button>(Resource.Id.btnsignup);

            btnsignup.Click += (Sender, e) =>
            {
                Intent RegisterActivityIntent = new Intent(this, typeof(RegisterActivity));
             
                StartActivity(RegisterActivityIntent);
            };


        }

        private T FindViewById<T>(object edfirstname)
        {
            throw new NotImplementedException();
        }
    }
}