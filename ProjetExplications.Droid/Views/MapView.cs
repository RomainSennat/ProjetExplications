using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V4;
using Android.Gms.Maps;
using ProjetExplications.Core.ViewModels;
using Android.Gms.Maps.Model;
using MvvmCross.Binding.BindingContext;
using ProjetExplications.Droid.Wrappers;
using ProjetExplications.Droid.Converters;

namespace ProjetExplications.Droid.Views
{
	[Activity(Label = "MapView")]
	public class MapView : MvxFragmentActivity, IOnMapReadyCallback
	{

		MarkerWrapper _marker;
		GoogleMap _map;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.View_Map);

			MapViewModel viewModel = (MapViewModel)ViewModel;

			SupportMapFragment fragment = (SupportMapFragment)SupportFragmentManager.FindFragmentById(Resource.Id.map);
			fragment.GetMapAsync(this);
		}

		public void OnMapReady(GoogleMap map)
		{
			_map = map;
			_map.UiSettings.ZoomControlsEnabled = true;
			_map.UiSettings.CompassEnabled = true;
			_map.UiSettings.SetAllGesturesEnabled(true);

			LatLng position = new LatLng(48.8833, 2.4667);
			MarkerOptions options = new MarkerOptions();
			options.Draggable(true);
			options.SetTitle("Ma position");
			options.SetPosition(position);
			_marker = new MarkerWrapper(_map.AddMarker(options));
			_map.AnimateCamera(CameraUpdateFactory.NewLatLngZoom(position, 15));

			_map.MarkerDrag += (sender, args) =>
			{
				_marker.FirePositionChanged();
			};

			var set = this.CreateBindingSet<MapView, MapViewModel>();
			set.Bind(_marker).For(m => m.Position).To(vm => vm.Location).WithConversion(new LocationToLatLngConverter(), null).TwoWay();
			set.Apply();
		}
	}
}