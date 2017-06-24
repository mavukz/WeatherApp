using System;
namespace WeatherMeUp
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
