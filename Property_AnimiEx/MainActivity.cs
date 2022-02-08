using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;
using Android.Widget.ImageView;
using System;

namespace Property_AnimiEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ImageView imageView;
        Button button1, button2, button3, button4, button5, button6;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            button1 = FindViewById<Button>(Resource.Id.zoom_in);
            button1.Click += delegate
            {
                Animation startAnimation = AnimationUtils.LoadAnimation(this, Resource.Animation.fade_in);
                ImageView.StartAnimation(startAnimation);
            };

            imageView = FindViewById<ImageView>(Resource.Id.imgview);
        }

        


    }
}