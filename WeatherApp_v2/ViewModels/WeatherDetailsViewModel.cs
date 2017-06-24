using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace WeatherMeUp
{
	public class WeatherDetailsViewModel : MvxViewModel
	{
		ISerializationService _serializationService;

		public List<WeatherData> ListOfData { get; set; }
		public string PicUrl { get; private set; }
		public string Location { get; private set; }
		public string Temperature { get; private set; }
		public string Description { get; private set; }
		public string Date { get; private set; }

		class Strings 
		{
			public static readonly string Coords = "GeoCoords";
			public static readonly string Humidity = "Humidity";
			public static readonly string Pressure = "Pressure";
			public static readonly string SeaLevel = "Sea level";
			public static readonly string GroundLevel = "Ground level";
			public static readonly string Temperature = "Temperature";
			public static readonly string TemperatureMax = "Temperature max";
			public static readonly string TemperatureMin = "Temperature min";
			public static readonly string Sunrise = "Sunrise";
			public static readonly string Sunset = "Sunset";
			public static readonly string Clouds = "Clouds";
		}

		public WeatherDetailsViewModel(ISerializationService serializationService)
		{
			_serializationService = serializationService;
			 ListOfData = new List<WeatherData>();
		}

		protected override void InitFromBundle(IMvxBundle parameters)
		{
			base.InitFromBundle(parameters);

			var jsonString = parameters.Data["JsonString"];
			var mainPojo = _serializationService.Deserialize<MainPojo>(jsonString);

			Location = "Weather in "+ mainPojo.Name + ", " + mainPojo.Sys.Country;
			Temperature = mainPojo.Main.Temp.Convert(ConversionType.Degrees);
			Date ="get at " + mainPojo.Dt.Convert(ConversionType.Date);

			foreach (var weather in mainPojo.Weather)
			{
				PicUrl = "http://openweathermap.org/img/w/" + weather.Icon + ".png";
				Description = weather.Description;
			}

			ListOfData.Add(new WeatherData(Strings.Temperature, Temperature));
			ListOfData.Add(new WeatherData(Strings.Humidity, mainPojo.Main.Humidity.Convert(ConversionType.Percentage)));
			ListOfData.Add(new WeatherData(Strings.Pressure, mainPojo.Main.Pressure.Convert(ConversionType.Degrees)));
			ListOfData.Add(new WeatherData(Strings.Clouds, mainPojo.Clouds.All));
			ListOfData.Add(new WeatherData(Strings.Sunrise, mainPojo.Sys.Sunrise.Convert(ConversionType.TimeOfDay)));
			ListOfData.Add(new WeatherData(Strings.Sunset, mainPojo.Sys.Sunset.Convert(ConversionType.TimeOfDay)));
			ListOfData.Add(new WeatherData(Strings.Coords, "[" + mainPojo.Coord.Lon + ", " +mainPojo.Coord.Lat + "]"));
		}
	}
}