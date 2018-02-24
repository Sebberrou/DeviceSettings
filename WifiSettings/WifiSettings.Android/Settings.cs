using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using WifiSettings;
using Xamarin.Forms;
using WifiSettings.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceSettings))]
namespace WifiSettings.Droid
{
    class DeviceSettings : WifiSettings.ISettings
    {
        public void OpenWifi()
        {
            var intent = new Intent(Android.Provider.Settings.ActionWifiSettings);
            intent.AddFlags(ActivityFlags.NewTask);
            Android.App.Application.Context.StartActivity(intent);

        }
    }
}