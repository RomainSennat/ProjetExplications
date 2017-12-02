using Android.Gms.Maps.Model;
using MvvmCross.Platform.Converters;
using ProjetExplications.Core.ViewModels;

namespace ProjetExplications.Droid.Converters
{
	public class LocationToLatLngConverter : MvxValueConverter<Location, LatLng>
	{
		protected override LatLng Convert(Location value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return new LatLng(value.Lattitude, value.Longitude);
		}

		protected override Location ConvertBack(LatLng value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return new Location() { Lattitude = value.Latitude, Longitude = value.Longitude };
		}
	}
}