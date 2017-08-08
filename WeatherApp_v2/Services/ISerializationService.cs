using System;
namespace WeatherApp_v2
{
	public interface ISerializationService
	{
		string Serialize(object item);
		T Deserialize<T>(string item);
	}
}
