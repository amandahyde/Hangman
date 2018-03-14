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

namespace Hangman
{
    [Activity(Label = "GameActivity")]
    public class GameActivity : Activity
    {
        private TextView txtMessage;
        private String Name;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Game);

            Name = Intent.GetStringExtra("Name");

            txtMessage = FindViewById<TextView>(Resource.Id.txtWelcome);
            txtMessage.Text = "Welcome to the game " + Name;

        }
    }
}