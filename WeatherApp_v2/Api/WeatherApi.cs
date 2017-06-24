using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherMeUp
{
	public class WeatherApi : IWeatherApi
	{
		const string URL = "http://api.openweathermap.org/data/2.5/weather?q=";
		const string API_KEY = "828ea94910c143295348db6dc5312da6";

		public async Task<Dictionary<string, string>> GetCity(string cityName)
		{
			try
			{
				var client = new HttpClient();
				var stream = await client.GetStreamAsync(URL + "{" + cityName + "}&units=metric&apiKey=" + API_KEY);
				var jsonString = GetJsonStringFromStream(stream);

				var _weatherData = new Dictionary<string, string>
				{
					{"JsonString", jsonString}
				};

				return _weatherData;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private string GetJsonStringFromStream(Stream dataStream)
		{
			var reader = new StreamReader(dataStream);
			string jsonString = "";
			string line;

			while ((line = reader.ReadLine()) != null)
				jsonString += line;

			return jsonString;
		}
	}
}