using System;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Plugins.Location;
using Cirrious.MvvmCross.ViewModels;
using System.Diagnostics;
using StreetCrash.Core.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreetCrash.Core;
using System.Net;

namespace StreetCrash.Core.ViewModels
{
    public class CadastroOcorrenciaViewModel
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        {
            get { return _hello; }
            set { _hello = value; RaisePropertyChanged(() => Hello); }
        }
        
        public CadastroOcorrenciaViewModel()
        {

            var locationWatcher = Mvx.Resolve<IMvxLocationWatcher>();
            var options = new MvxLocationOptions
            {
                MovementThresholdInM = 50,
                TimeBetweenUpdates = TimeSpan.FromSeconds(5)
            };

            locationWatcher.Start(options,
            (location) =>
            {
                //locationWatcher.Stop();
                //Debug.WriteLine(location.Coordinates.Latitude + " : " + location.Coordinates.Longitude);
                Debug.WriteLine(location.Coordinates.Latitude + " : " + location.Coordinates.Longitude);
                ReverseGeoLoc reverse = new ReverseGeoLoc();
                ReverseGeoLoc.Address_Components  reverse1 = new ReverseGeoLoc.Address_Components();
                var request = WebRequest.Create("http://maps.google.com/maps/api/geocode/json?latlng=" + location.Coordinates.Latitude + "," + location.Coordinates.Longitude + "&sensor=false") as HttpWebRequest;
                reverse1 = reverse.DeserializeReverse(request.ToString());
                Hello = reverse1.short_name;
            },
            (error) =>
            {
                Debug.WriteLine(error.Code);
            });
            
             //locationWatcher.CurrentLocation.Timestamp.DateTime - DateTime.Now;
        }
       
    }
}
