namespace WeatherApp_v2
{
	public class ApiResponse<T>
	{
		public T Results { get; }
		public bool IsSuccessful { get; }

		public ApiResponse(T results, bool isSuccessful)
		{
			Results = results;
			IsSuccessful = isSuccessful;
		}
	}
}
