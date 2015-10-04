using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

using Android.Widget;
using Android.Locations;
using Android.Util;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.Runtime;
using Android.Views;


namespace StreetCrash.Droid.Views
{
    [Activity(Label = "View for CadastroOcorrenciaView")]
    public class CadastroOcorrenciaView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.cadastroOcorrenciaView);
        }
    }
}