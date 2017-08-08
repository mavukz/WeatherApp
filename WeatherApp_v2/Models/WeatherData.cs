using System;
namespace WeatherApp_v2
{
	public class WeatherData
	{
		public string Title { get; private set; }

		public string Value { get; private set; }

		public WeatherData(string title, string value)
		{
			Title = title;
			Value = value;
		}
	}
}
