using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace WeatherApp_v2.iOS
{
    public partial class MainViewController : MvxViewController<MainViewModel>
    {

        public MainViewController() : base("MainViewController", null)
        {
        }

        public bool Visibility
        {
            get 
            {
                return ActivityIndicator.Hidden;
            }
            set
            {
                ActivityIndicator.Hidden = !value;
                ActivityIndicator.StartAnimating();
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationController.NavigationBarHidden = true;

            var bindingSet = this.CreateBindingSet<MainViewController, MainViewModel>();
            bindingSet.Bind(CityTextField).To(ViewModel => ViewModel.City);
            bindingSet.Bind(GetWeatherButton).To(ViewModel => ViewModel.GetWeatherAsync);
            bindingSet.Bind(this).For(view => view.Visibility).To(ViewModel => ViewModel.Busy);
            bindingSet.Apply();
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            GetWeatherButton.Layer.CornerRadius = 5f;
        }
    }
}

