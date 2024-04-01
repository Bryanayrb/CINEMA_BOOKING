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
using System.Threading.Tasks;

namespace CINEMA_BOOKING
{
    [Activity(Label = "Login")]
    public class Login : Activity
    {
    
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LoginLayout);

            // Create your application here

            var Log_in = FindViewById<Button>(Resource.Id.btnLogin);
            Log_in.Click += (sender, args) =>
            {
                Intent intent = new Intent(this, typeof(Login_Page));
                StartActivity(intent);
            };

        }
    }
}