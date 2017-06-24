using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;

namespace WeatherMeUp.Droid
{
	public class Setup : MvxAndroidSetup
	{
		public Setup(Context appContext) : base(appContext)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new App();
		}

	}
}
