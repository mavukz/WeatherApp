using System.Collections.Generic;

namespace WeatherMeUp
{
	public class Sys : IWeatherModel
	{
		public string Message;
		public string Id;
		public string Sunset;
		public string Sunrise;
		public string Type;
		public string Country;
	}
}
