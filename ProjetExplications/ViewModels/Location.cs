using MvvmCross.Core.ViewModels;

namespace ProjetExplications.Core.ViewModels
{
	public class Location : MvxNotifyPropertyChanged
	{
		double _lattitude;
		public double Lattitude
		{
			get => _lattitude;
			set
			{
				_lattitude = value;
				RaisePropertyChanged(() => Lattitude);
			}
		}

		double _longitude;
		public double Longitude
		{
			get => _longitude;
			set
			{
				_longitude = value;
				RaisePropertyChanged(() => Longitude);
			}
		}

		public override string ToString()
		{
			return string.Format("{0:0.0000}, {1:0.0000}", Lattitude, Longitude);
		}
	}
}
