using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace WeatherMeUp.Droid
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
