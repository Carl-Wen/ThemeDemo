using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.Res;
using ThemeDemo.Themes;

namespace ThemeDemo.Droid
{
    [Activity(
        Label = "@string/app_name",
        Icon = "@mipmap/icon",
        Theme = "@style/MainTheme",
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            ////App.ApplyTheme();
            //if (UserSettings.Current.Theme == ThemeDemo.Theme.System)
            //{
            //    var isDark = newConfig.UiMode == (UiMode.NightYes | UiMode.TypeNormal);
            //    try
            //    {
            //        /**/
            //        var realTheme = ThemeManager.RealTheme;
            //        if (realTheme == ThemeDemo.Theme.Light && isDark)
            //        {
            //            ThemeManager.ApplyTheme(ThemeDemo.Theme.System);
            //        }
            //        else if (realTheme == ThemeDemo.Theme.Dark && !isDark)
            //        {
            //            ThemeManager.ApplyTheme(ThemeDemo.Theme.System);
            //        }
            //    }
            //    catch (System.Exception ex)
            //    {

            //    }
            //}
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}