using System;
using ThemeDemo.Page;
using ThemeDemo.Themes;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThemeDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            ThemeManager.ApplyTheme(UserSettings.Current.Theme);
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            ThemeManager.OnResume();
        }
    }
}
