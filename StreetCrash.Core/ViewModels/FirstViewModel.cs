using System;
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

        //public MvxCommand NaoResolvidoCommand { get; private set; }

        //public MvxCommand ResolvidoCommand { get; private set; }

        //public MvxCommand InserirComentarioCommand { get; private set; }

        //public FirstViewModel()
        //{
        //    NaoResolvidoCommand = new MvxCommand(ExecuteNaoResolvidoCommand);
        //    ResolvidoCommand = new MvxCommand(ExecuteResolvidoCommand);
        //    InserirComentarioCommand = new MvxCommand(ExecuteInserirComentarioCommand);
        //}

        //private void ExecuteNaoResolvidoCommand()
        //{
        //    //Lógica  
        //}

        //private void ExecuteResolvidoCommand()
        //{
        //    //marcar como resolvido
        //}

        //private void ExecuteInserirComentarioCommand()
        //{

        //}
    }
}
