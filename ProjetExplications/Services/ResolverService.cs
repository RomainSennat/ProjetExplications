using MvvmCross.Platform;

namespace ProjetExplications.Core.Services
{
	public class ResolverService : IResolverService
	{
		public ICalendarService ResolveCalendar()
		{
			if (Mvx.CanResolve<ICalendarService>())
			{
				return Mvx.Resolve<ICalendarService>();
			}
			return null;
		}

		public IPlateformService ResolvePlateform()
		{
			if (Mvx.CanResolve<IPlateformService>())
			{
				return Mvx.Resolve<IPlateformService>();
			}
			return null;
		}
	}
}
