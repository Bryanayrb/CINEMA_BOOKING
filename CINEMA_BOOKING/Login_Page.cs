using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace CINEMA_BOOKING
{
    [Activity(Label = "Login_Page")]
    public class Login_Page : Activity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LoginPage);

            // Create your application here
            var Log_in = FindViewById<Button>(Resource.Id.btnSignIn);
            Log_in.Click += (sender, args) =>
            {

                Intent intent = new Intent(this, typeof(Home));
                StartActivity(intent);
            };
        }
    }
}