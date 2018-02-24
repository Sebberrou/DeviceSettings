using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WifiSettings;
using Xamarin.Forms;
using WifiSettings.iOS;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceSettings))]
namespace WifiSettings.iOS
{
    class DeviceSettings : ISettings
    {
        public void  OpenWifi()
        {
            //TO BE TESTED

            var WiFiURL = new NSUrl("prefs:root=WIFI");
            if (UIApplication.SharedApplication.CanOpenUrl(WiFiURL))
            {   //Pre iOS 10
                UIApplication.SharedApplication.OpenUrl(WiFiURL);
            }
            else
            {   //iOS 10
                UIApplication.SharedApplication.OpenUrl(new NSUrl("App-Prefs:root=WIFI"));
            }
        }
    }
}