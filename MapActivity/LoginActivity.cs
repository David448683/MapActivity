﻿using System;
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
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class LoginActivity : Activity
        {
        Button btnLogin;
        Button btnSignUp;
        EditText etAccName;
        EditText etPassword;


        protected override void OnCreate(Bundle savedInstanceState)
            {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Login);

            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            etAccName = FindViewById<EditText>(Resource.Id.etAccName);
            etPassword = FindViewById<EditText>(Resource.Id.etPassword);
            btnSignUp = FindViewById<Button>(Resource.Id.btnSignUp);

            btnLogin.Click += (Sender, e) =>
            {
                Intent HomeActivityIntent = new Intent(this, typeof(HomeActivity));
                HomeActivityIntent.PutExtra("AccName", etAccName.Text);
                HomeActivityIntent.PutExtra("Password", etPassword.Text);
                StartActivity(HomeActivityIntent);
            };

            btnSignUp.Click += (Sender, e) =>
            {
                Intent RegisterActivityIntent = new Intent(this, typeof(RegisterActivity));
                StartActivity(RegisterActivityIntent);
            };

            // Create your application here
            }

        }
    }
//LoginActivity//