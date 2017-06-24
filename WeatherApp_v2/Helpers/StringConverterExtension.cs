using System;

namespace WeatherApp_v2
{
	public static class StringConverter
	{
		public static string Convert(this string value, ConversionType type) 
		{
			switch (type) 
			{
				case ConversionType.Date:
				return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(long.Parse(value)).ToString("g");
				
				case ConversionType.TimeOfDay:
				return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(long.Parse(value)).ToString("t");
				
				case ConversionType.Degrees:
					return value + " ºC";

				case ConversionType.Metres:
					return value + " m";

				case ConversionType.Percentage:
					return value + " %";

				default:
					return value;
			}
		}
	}
}