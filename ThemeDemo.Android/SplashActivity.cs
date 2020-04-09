using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace ThemeDemo.Droid
{
    [Activity(
        Label = "@string/app_name",
        Icon = "@mipmap/icon",
        Theme = "@style/SplashTheme",
        MainLauncher = true,
        NoHistory = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetUp();
        }

        private async Task SetUp()
        {
            await Task.Delay(3);
            StartActivity(new Intent(this, typeof(MainActivity)));
        }
    }
}
