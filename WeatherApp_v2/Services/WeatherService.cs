using System.Collections.Generic;

namespace WeatherMeUp
{
	public class WeatherService : IWeatherService
	{
		IWeatherApi _api;

		public WeatherService(IWeatherApi api) 
		{
			_api = api;
		}

		public ApiRequest<Dictionary<string, string>> GetWeather(string city)
		{
			return new ApiRequest<Dictionary<string, string>>(() => _api.GetCity(city));
		}
	}
}
