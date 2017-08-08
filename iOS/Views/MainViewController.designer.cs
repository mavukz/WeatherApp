// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace WeatherApp_v2.iOS
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		UIKit.UIActivityIndicatorView ActivityIndicator { get; set; }

		[Outlet]
		UIKit.UITextField CityTextField { get; set; }

		[Outlet]
		UIKit.UIButton GetWeatherButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CityTextField != null) {
				CityTextField.Dispose ();
				CityTextField = null;
			}

			if (GetWeatherButton != null) {
				GetWeatherButton.Dispose ();
				GetWeatherButton = null;
			}

			if (ActivityIndicator != null) {
				ActivityIndicator.Dispose ();
				ActivityIndicator = null;
			}
		}
	}
}
