using System.Collections.Generic;

namespace WeatherApp_v2
{
	public interface IWeatherService
	{
		ApiRequest<Dictionary<string, string>> GetWeather(string city);
	}
}
