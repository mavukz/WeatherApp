using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using UIKit;

namespace WeatherMeUp.iOS
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
			bindingSet.Bind(TemperatureLabel).To(vm => vm.Temperature);
			bindingSet.Bind(Description).To(vm => vm.Date);
			bindingSet.Bind(DateLabel).To(vm => vm.Date);
			bindingSet.Apply();
		}
	}
}

