using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace WeatherMeUp
{
	public class MainViewModel : MvxViewModel
	{
		readonly IWeatherService _weatherService;
		string _city;
		bool _busy;

		public bool Busy
		{
			get
			{
				return _busy;
			}
			private set { _busy = value; RaisePropertyChanged(() => Busy); }
		}

		public MainViewModel(IWeatherService weatherService)
		{
			_weatherService = weatherService;
		}

		public ICommand GetWeatherAsync
		{
			get
			{
				return new MvxCommand(async () =>
				{
					if (string.IsNullOrEmpty(_city)) return;

					Busy = true;
					var response = await _weatherService.GetWeather(_city).OnBadRequest(HandleOnBadRequest).Request();

					if (response.IsSuccessful)
					{
						ShowViewModel<WeatherDetailsViewModel>(response.Results);
						Busy = false;
					}
					else Busy = false;
				});
			}
		}

		public string City
		{
			get
			{
				return _city;
			}
			private set
			{
				_city = value;
			}
		}

		void HandleOnBadRequest()
		{
			
		}
	}
}
