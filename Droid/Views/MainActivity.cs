using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace WeatherMeUp.Droid
{
	[Activity]
	public class MainActivity : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.main);
			Title = "Weather Me Now";
		}
	}
}