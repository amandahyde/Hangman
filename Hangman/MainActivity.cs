using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;
using System;

namespace Hangman
{
    [Activity(Label = "Hangman", MainLauncher = true)]
    public class MainActivity : Activity
    {

       
        private Button btnNext;
        private EditText EnterName;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

       
        }

        private void Startup() {

            EnterName = FindViewById<EditText>(Resource.Id.ETEnterName);
            btnNext = FindViewById<Button>(Resource.Id.btnNext);

            btnNext.Click += onNext_Click;


        }

        private void onNext_Click(object sender, EventArgs e)
        {
            //toast check to see its working
            Toast.MakeText(this, "Your name is " + EnterName.Text, ToastLength.Long).Show();

            //create an intent to move data to the other activity.
            var gameActivity = new Intent(this, typeof(GameActivity));
            gameActivity.PutExtra("Name", EnterName.Text);

            //start game activity
            StartActivity(typeof(GameActivity));
        }
        }
}

