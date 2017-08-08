using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using UIKit;

namespace WeatherApp_v2.iOS
{
	public partial class WeatherDetailsViewController : MvxViewController<WeatherDetailsViewModel>
	{
		public WeatherDetailsViewController() : base("WeatherDetailsViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var bindingSet = this.CreateBindingSet<WeatherDetailsViewController, WeatherDetailsViewModel>();
			bindingSet.Bind(LocationLabel).To(ViewModel => ViewModel.Location);
			bindingSet.Bind(TemperatureLabel).To(ViewModel => ViewModel.Temperature);
            bindingSet.Bind(DescriptionLabel).To(ViewModel => ViewModel.Description);
			bindingSet.Bind(DateLabel).To(ViewModel => ViewModel.Date);
			bindingSet.Apply();
		}
	}
}

