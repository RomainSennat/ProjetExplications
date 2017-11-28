using Android.Support.V4.App;
using Android.App;
using Android.Content;
using ProjetExplications.Core.Services;

namespace ProjetExplications.Droid.Services
{
	public class PlateformService : IPlateformService
	{
		public void ShowPlateformAsNotification()
		{
			Context context = Application.Context;
			Notification notification = new NotificationCompat.Builder(context)
				  .SetContentTitle("Je suis une notification Android")
				  .SetContentText(string.Format("Cette application tourne sur Android {0}", Android.OS.Build.VERSION.Release))
				  .SetAutoCancel(true)
				  .SetVisibility((int)NotificationVisibility.Public)
				  .SetSmallIcon(Resource.Drawable.common_full_open_on_phone)
				  .Build();
			NotificationManager manager = (NotificationManager)context.GetSystemService(Context.NotificationService);
			manager.Notify(0, notification);
		}
	}
}
