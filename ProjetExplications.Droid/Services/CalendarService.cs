using ProjetExplications.Core.Services;
using Android.Provider;
using Android.App;
using Android.Content;
using Java.Util;
using System.Diagnostics;

namespace ProjetExplications.Droid.Services
{
	public class CalendarService : ICalendarService
	{
		public void CreateEvent()
		{
			Context context = Application.Context;
			Intent intent = new Intent(Intent.ActionInsert);
			intent.PutExtra(CalendarContract.Events.InterfaceConsts.CalendarId, "event");
			intent.PutExtra(CalendarContract.Events.InterfaceConsts.Title, "C'est la fête dans l'application");
			intent.PutExtra(CalendarContract.Events.InterfaceConsts.Description, "Tous au Hayal Chicken les frères !");
			intent.PutExtra(CalendarContract.Events.InterfaceConsts.EventLocation, "A la gare.");
			intent.PutExtra(CalendarContract.ExtraEventBeginTime, GetDateTimeMS(2017, 11, 25, 12, 0));
			intent.PutExtra(CalendarContract.ExtraEventEndTime, GetDateTimeMS(2017, 11, 25, 14, 0));
			intent.PutExtra(CalendarContract.Events.InterfaceConsts.EventTimezone, Java.Util.TimeZone.Default);
			intent.PutExtra(CalendarContract.Events.InterfaceConsts.EventEndTimezone, Java.Util.TimeZone.Default);
			intent.SetData(CalendarContract.Events.ContentUri);
			context.StartActivity(intent);
		}

		private long GetDateTimeMS(int year, int month, int day, int hours, int minutes)
		{
			Calendar c = Calendar.GetInstance(TimeZone.Default);
			c.Set(CalendarField.DayOfMonth, day);
			c.Set(CalendarField.HourOfDay, hours);
			c.Set(CalendarField.Minute, minutes);
			c.Set(CalendarField.Month, month);
			c.Set(CalendarField.Year, year);
			Debug.WriteLine(c.ToString());
			return c.TimeInMillis;
		}
	}

}
