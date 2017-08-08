using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherApp_v2
{
	public class ApiRequest<T>
	{
		Func<Task<T>> _toRunFunction;
		private Dictionary<HttpStatusCode, Action> _errorFunctions = new Dictionary<HttpStatusCode, Action>();

		public ApiRequest(Func<Task<T>> toRunFunction)
		{
			_toRunFunction = toRunFunction;
		}

		public ApiRequest<T> OnBadRequest(Action onBadRequest)
		{
			OnStatusCode(HttpStatusCode.BadRequest, onBadRequest);
			return this;
		}

		private ApiRequest<T> OnStatusCode(HttpStatusCode status, Action onStatusCode)
		{
			_errorFunctions.Add(status, onStatusCode);
			return this;
		}

		public async Task<ApiResponse<T>> Request()
		{
			try
			{
				T results = await _toRunFunction();
				return new ApiResponse<T>(results, true);
			}
			catch (HttpRequestException)
			{
				await Task.Delay(5000);
				return await Request();
			}
			catch (TaskCanceledException ex)
			{
				if (ex.CancellationToken.IsCancellationRequested)
					return new ApiResponse<T>(default(T), false);

				await Task.Delay(5000);
				return await Request();
			}

		}
	}
}
