using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace OpenWebpage
{
    [Activity(Label = "OpenWebpage", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Get out button from the layout resource
            //and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += (sender, e) =>
            {
                var uri = Android.Net.Uri.Parse("http://ojc.asia");

                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };
        }
    }
}

