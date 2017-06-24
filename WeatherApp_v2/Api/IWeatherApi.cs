using System.Collections.Generic;
using System.Threading.Tasks;

namespace WeatherMeUp
{
	public interface IWeatherApi
	{
		Task<Dictionary<string, string>> GetCity(string cityName);
	}
}
