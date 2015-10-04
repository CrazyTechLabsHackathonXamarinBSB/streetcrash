using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore;
using StreetCrash.Core.ViewModels;

namespace StreetCrash.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            
            var cadastroOcorrencia = new CadastrarOcorrencia();
            Mvx.RegisterSingleton(cadastroOcorrencia);
            
            RegisterAppStart<ViewModels.FirstViewModel>();
        }
    }
}