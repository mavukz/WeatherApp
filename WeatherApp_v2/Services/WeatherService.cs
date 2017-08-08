using System.Collections.Generic;

namespace WeatherApp_v2
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
