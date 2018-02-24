using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WifiSettings
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        void BtnClick(object sender, EventArgs args)
        {
            System.Diagnostics.Debug.WriteLine("Clicked");
            DependencyService.Get<ISettings>().OpenWifi();
        }
	}
}
