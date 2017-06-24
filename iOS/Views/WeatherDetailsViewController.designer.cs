// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace WeatherMeUp.iOS
{
	[Register ("WeatherDetailsViewController")]
	partial class WeatherDetailsViewController
	{
		[Outlet]
		UIKit.UILabel DateLabel { get; set; }

		[Outlet]
		UIKit.UILabel DescriptionLabel { get; set; }

		[Outlet]
		UIKit.UITableView DetailsTableView { get; set; }

		[Outlet]
		UIKit.UILabel LocationLabel { get; set; }

		[Outlet]
		UIKit.UIImageView TemperatureImageView { get; set; }

		[Outlet]
		UIKit.UILabel TemperatureLabel { get; set; }
		
		void ReleaseDesignerOutlets()
		{
			if (LocationLabel != null) {
				LocationLabel.Dispose ();
				LocationLabel = null;
			}

			if (TemperatureImageView != null) {
				TemperatureImageView.Dispose ();
				TemperatureImageView = null;
			}

			if (TemperatureLabel != null) {
				TemperatureLabel.Dispose ();
				TemperatureLabel = null;
			}

			if (DescriptionLabel != null) {
				DescriptionLabel.Dispose ();
				DescriptionLabel = null;
			}

			if (DateLabel != null) {
				DateLabel.Dispose ();
				DateLabel = null;
			}

			if (DetailsTableView != null) {
				DetailsTableView.Dispose ();
				DetailsTableView = null;
			}
		}
	}
}
