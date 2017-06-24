using System.Collections.Generic;

namespace WeatherMeUp
{
	public interface IWeatherService
	{
		ApiRequest<Dictionary<string, string>> GetWeather(string city);
	}
}
