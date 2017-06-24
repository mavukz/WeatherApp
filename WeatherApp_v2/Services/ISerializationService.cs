using System;
namespace WeatherMeUp
{
	public interface ISerializationService
	{
		string Serialize(object item);
		T Deserialize<T>(string item);
	}
}
