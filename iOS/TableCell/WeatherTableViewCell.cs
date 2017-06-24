using System;

using Foundation;
using UIKit;

namespace WeatherMeUp.iOS
{
	public partial class WeatherTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString("WeatherTableViewCell");
		public static readonly UINib Nib;

		static WeatherTableViewCell()
		{
			Nib = UINib.FromName("WeatherTableViewCell", NSBundle.MainBundle);
		}

		protected WeatherTableViewCell(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public static WeatherTableViewCell Create() 
		{
			return Nib.Instantiate(null, null)[0] as WeatherTableViewCell;
		}
	}
}
