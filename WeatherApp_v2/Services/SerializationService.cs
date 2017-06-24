using Newtonsoft.Json;

namespace WeatherMeUp
{
	public class SerializationService : ISerializationService
	{
		public T Deserialize<T>(string item)
		{
			return JsonConvert.DeserializeObject<T>(item);	
		}

		public string Serialize(object item)
		{
			return JsonConvert.SerializeObject(item);
		}
	}
}