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
    [Activity(Label = "MovieDetails")]
    public class MovieDetails : Activity
    {
        ImageButton back;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MovieAbout);

            // Create your application here
            back = FindViewById<ImageButton>(Resource.Id.ImageButtonBack);

            back.Click += (sender, args) =>
            {
                Intent intent = new Intent(this, typeof(Home));
                StartActivity(intent);
            };
        }
    }
}