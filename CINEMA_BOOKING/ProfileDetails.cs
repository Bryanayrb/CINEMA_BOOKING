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
    [Activity(Label = "ProfileDetails")]
    public class ProfileDetails : Activity
    {
        ImageButton Prev;
        ImageButton Out;
        TextView Username;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ViewProfile);

            // Create your application here

            Prev = FindViewById<ImageButton>(Resource.Id.Previuos);
            Out = FindViewById<ImageButton>(Resource.Id.Logout);
            Username = FindViewById<TextView>(Resource.Id.textboxUsername);

            Username.Text = Intent.GetStringExtra("Username");

            Prev.Click += (sender, args) =>
            {
                Intent intent = new Intent(this, typeof(Home));
                StartActivity(intent);
            };

            Out.Click += (sender, args) =>
            {
                AlertDialog.Builder alert1 = new AlertDialog.Builder(this);
                alert1.SetTitle("Confirmation");
                alert1.SetMessage("Log out");
                alert1.SetPositiveButton("Yes", (senderAlert, args) =>
                {
                    Toast.MakeText(this, "Sign Out", ToastLength.Short).Show();
                    Intent intent = new Intent(this, typeof(Login_Page));
                    StartActivity(intent);
                });
                alert1.SetNegativeButton("No", (senderAlert, args) =>
                {
                    Toast.MakeText(this, "Try again", ToastLength.Short).Show();
                });
                Dialog front = alert1.Create();
                front.Show();
                
            };

        }
    }
}