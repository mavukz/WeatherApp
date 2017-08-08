using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace WeatherApp_v2.Droid
{
	[Activity]
	public class MainActivity : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
            SetContentView(Resource.Layout.main_layout);
			Title = "Weather Me Now";
		}
	}
}