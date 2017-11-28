using System;
using Android;
using Android.App;
using Android.OS;
using Android.Support.V4.App;
using MvvmCross.Droid.Views;

namespace ProjetExplications.Droid.Views
{
	[Activity(Label = "MainView", MainLauncher = true)]
	public class MainView : MvxActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.View_Main);
		}

	}
}
