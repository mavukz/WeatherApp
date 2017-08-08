using System.Collections.Generic;
using System.Threading.Tasks;

namespace WeatherApp_v2
{
	public interface IWeatherApi
	{
		Task<Dictionary<string, string>> GetCity(string cityName);
	}
}
