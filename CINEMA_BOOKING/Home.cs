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

namespace CINEMA_BOOKING
{
    [Activity(Label = "Home")]
    public class Home : Activity
    {
        ImageButton batman;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.HomePage_Profile);

            batman = FindViewById<ImageButton>(Resource.Id.imageButton1);

            batman.Click += (sender, args) =>
            {
                Intent intent = new Intent(this, typeof(MovieDetails));
                StartActivity(intent);
            };
            // Create your application here
            var View_Profile = FindViewById<Button>(Resource.Id.btnProfile);
            View_Profile.Click += (sender, args) =>
            {
                Intent intent = new Intent(this, typeof(ProfileDetails));
                StartActivity(intent);
            };
        }
    }
}