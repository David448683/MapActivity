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
        EditText etFirstName;
        EditText etLastName;
        EditText etPhone;
        EditText etAddress;
        EditText etCountry;
        EditText etPassword;
        Button btnSignup;
        Button btnBack;
        protected override void OnCreate(Bundle savedInstanceState)
            {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Register);

            etFirstName = FindViewById<EditText>(Resource.Id.etFirstName);
            etLastName = FindViewById<EditText>(Resource.Id.etLastName);
            etPhone = FindViewById<EditText>(Resource.Id.etPhone);
            etAddress = FindViewById<EditText>(Resource.Id.etAddress);
            etCountry = FindViewById<EditText>(Resource.Id.etCountry);
            etPassword = FindViewById<EditText>(Resource.Id.etPassword);
            btnSignup = FindViewById<Button>(Resource.Id.btnSignUp);
            btnBack = FindViewById<Button>(Resource.Id.btnBack);

            // Create your application here
            }
        }
    }