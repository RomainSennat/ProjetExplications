using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using MvvmCross.Platform;
using ProjetExplications.Core.Services;

namespace ProjetExplications.Core.ViewModels
{
	public class MainViewModel : MvxViewModel
	{
		IResolverService _resolver;

		public MainViewModel(IResolverService resolver)
		{
			_resolver = resolver;
		}

		MvxCommand _showMap;
		public ICommand ShowMap
		{
			get
			{
				_showMap = _showMap ?? new MvxCommand(GoToMap);
				return _showMap;
			}
		}

		MvxCommand _showPlateform;
		public ICommand ShowPlateform
		{
			get
			{
				_showPlateform = _showPlateform ?? new MvxCommand(PrintNotification);
				return _showPlateform;
			}
		}

		MvxCommand _saveEvent;
		public ICommand SaveEvent
		{
			get
			{
				_saveEvent = _saveEvent ?? new MvxCommand(AddEvent);
				return _saveEvent;
			}
		}

		void GoToMap()
		{
			ShowViewModel<MapViewModel>();
		}

		void PrintNotification()
		{
			_resolver.ResolvePlateform().ShowPlateformAsNotification();
		}

		void AddEvent()
		{
			_resolver.ResolveCalendar().CreateEvent();
		}
	}
}
