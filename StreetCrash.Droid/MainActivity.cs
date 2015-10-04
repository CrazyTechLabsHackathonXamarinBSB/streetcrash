using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Locations;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetCrash.Droid
{
    [Activity(Label = "StreetCrash.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        TextView enderecoText;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            //SetContentView(Resource.Layout.cadastroOcorrencia);

            //button imageButton1 = FindViewById<Button>(Resource.Id.MyButton);
            //imageButton1.Click += delegate { enderecoText.Text = string.Format("{0} clicks!", count++); };

        }
    }
}

