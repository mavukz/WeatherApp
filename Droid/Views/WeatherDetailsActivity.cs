using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace WeatherMeUp.Droid
{
	[Activity(Label = "WeatherDetailsActivity")]
	public class WeatherDetailsActivity : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.weather_details);
			Title = "Weather details";
		}
	}
}