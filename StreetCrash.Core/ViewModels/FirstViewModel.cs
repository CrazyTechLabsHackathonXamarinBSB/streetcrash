using System;
using Cirrious.MvvmCross.ViewModels;

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
