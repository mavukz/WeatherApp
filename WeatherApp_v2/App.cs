using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace WeatherMeUp
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			RegisterAppStart<MainViewModel>();
			ConfigureServices();
		}

		void ConfigureServices()
		{
			Mvx.LazyConstructAndRegisterSingleton<IWeatherApi, WeatherApi>();
			Mvx.LazyConstructAndRegisterSingleton<IWeatherService, WeatherService>();
			Mvx.LazyConstructAndRegisterSingleton<ISerializationService, SerializationService>();
		}
	}
}
