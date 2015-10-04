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

        public MvxCommand cadastroOcorrencias { get; set; }
        

        public FirstViewModel()
        {

            cadastroOcorrencias = new MvxCommand(ExecutarCadastrarOcorrencia);
        }

        private void ExecutarCadastrarOcorrencia()
        {
            CadastrarOcorrencia cadOcorrencias = new CadastrarOcorrencia();
            cadOcorrencias.Start();
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
