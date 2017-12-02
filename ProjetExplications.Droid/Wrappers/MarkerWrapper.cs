using System;
using Android.Gms.Maps.Model;
using MvvmCross.Platform.Core;

namespace ProjetExplications.Droid.Wrappers
{
	public class MarkerWrapper
	{
		private readonly Marker _marker;

		public MarkerWrapper(Marker marker)
		{
			_marker = marker;
		}

		public event EventHandler PositionChanged;

		public void FirePositionChanged()
		{
			PositionChanged.Raise(this);
		}

		public LatLng Position
		{
			get => _marker.Position;
			set => _marker.Position = value;
		}
	}
}