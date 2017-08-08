using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace WeatherApp_v2.iOS
{
	public partial class MainViewController : MvxViewController<MainViewModel>
	{
		
		public MainViewController() : base("MainViewController", null)
        {
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			NavigationController.NavigationBarHidden = true;

			var bindingSet = this.CreateBindingSet<MainViewController, MainViewModel>();
			bindingSet.Bind(CityTextField).To(vm => vm.City);
			bindingSet.Bind(GetWeatherButton).To(vm => vm.GetWeatherAsync);
			bindingSet.Apply();
		}

		public override void ViewDidLayoutSubviews()
		{
			base.ViewDidLayoutSubviews();
			GetWeatherButton.Layer.CornerRadius = 5f;
		}
	}
}

