using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.CrossCore;

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
            ShowViewModel<CadastroOcorrenciaViewModel>();
        }
        
    }
}
