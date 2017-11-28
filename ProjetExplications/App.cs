using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using ProjetExplications.Core.ViewModels;

namespace ProjetExplications.Core
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();
			RegisterNavigationServiceAppStart<MainViewModel>();
		}
	}
}
