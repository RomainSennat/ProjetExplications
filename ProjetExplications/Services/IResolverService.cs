namespace ProjetExplications.Core.Services
{
	public interface IResolverService
	{
		ICalendarService ResolveCalendar();
		IPlateformService ResolvePlateform();
	}
}
