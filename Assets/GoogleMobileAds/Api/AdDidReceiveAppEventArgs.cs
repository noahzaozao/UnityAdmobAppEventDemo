using System;
using GoogleMobileAds.Common;

namespace GoogleMobileAds.Api
{
	public class AdDidReceiveAppEventArgs : EventArgs
	{
		public string Name { get; set; }
		public string Info { get; set; }
	}
}