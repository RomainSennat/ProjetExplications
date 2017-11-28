using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Platform;
using ProjetExplications.Core.Services;
using ProjetExplications.Droid.Services;
using Android;
using ProjetExplications.Core;

namespace ProjetExplications.Droid
{
	public class Setup : MvxAndroidSetup
	{
		public Setup(Context applicationContext) : base(applicationContext)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new App();
		}

		protected override void InitializeLastChance()
		{
			Mvx.RegisterSingleton<IPlateformService>(new PlateformService());
			Mvx.RegisterSingleton<ICalendarService>(new CalendarService());
			base.InitializeLastChance();
		}
	}
}
