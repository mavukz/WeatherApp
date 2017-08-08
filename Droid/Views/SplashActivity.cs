using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace WeatherApp_v2.Droid
{
	[Activity(Label = "WeatherMeUp",
	          MainLauncher= true,
	          Icon="@drawable/weather",
			  Theme="@style/Theme.Splash",
	          NoHistory = true,
	          ScreenOrientation = ScreenOrientation.Portrait
	         )]
	public class SplashActivity : MvxSplashScreenActivity
	{
	}
}
