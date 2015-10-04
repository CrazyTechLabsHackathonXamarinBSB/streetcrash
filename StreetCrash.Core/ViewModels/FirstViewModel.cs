using Cirrious.CrossCore;
using Cirrious.MvvmCross.Plugins.Location;
using Cirrious.MvvmCross.ViewModels;
using System.Diagnostics;

namespace StreetCrash.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        public FirstViewModel()
        {
            var locationWatcher = Mvx.Resolve<IMvxLocationWatcher>();
            var options = new MvxLocationOptions();
            locationWatcher.Start(options,
            (location) =>
            {
                //locationWatcher.Stop();
                Debug.WriteLine(location.Coordinates.Latitude + " : " + location.Coordinates.Longitude);
            },
            (error) =>
            {
                Debug.WriteLine(error.Code);
            });
        }
    }
}
