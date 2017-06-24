using System;
namespace WeatherMeUp
{
	public class MainPojo : IWeatherModel 
	{
		public Weather[] Weather;
		public Clouds Clouds;
		public Coord Coord;
		public Wind Wind;
		public Main Main;
		public Sys Sys;
		public string Visibility;
		public string Name;
		public string Base;
		public string Cod;
		public string Dt;
		public string Id;
	}
}
