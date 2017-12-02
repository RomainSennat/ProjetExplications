using MvvmCross.Core.ViewModels;

namespace ProjetExplications.Core.ViewModels
{
	public class MapViewModel : MvxViewModel
	{
		Location _location;
		public Location Location
		{
			get => _location;
			set
			{
				_location = value;
				RaisePropertyChanged(() => Location);
			}
		}

		public MapViewModel()
		{
			_location = new Location()
			{
				Lattitude = 48.8833,
				Longitude = 2.4667
			};
		}
	}
}
