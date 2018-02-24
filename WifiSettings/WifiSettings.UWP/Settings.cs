using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WifiSettings;
using Xamarin.Forms;
using WifiSettings.UWP;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceSettings))]
namespace WifiSettings.UWP
{
    class DeviceSettings : ISettings
    {
        public void  OpenWifi()
        {
            Windows.System.Launcher.LaunchUriAsync(new Uri("ms-settings:network-wifi"));

        }
    }
}