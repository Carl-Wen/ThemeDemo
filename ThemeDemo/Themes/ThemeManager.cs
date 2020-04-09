using System;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ThemeDemo.Themes
{
    public static class ThemeManager
    {
        public static void ApplyTheme(Theme theme)
        {
            ResourceDictionary temp;
            switch (theme)
            {
                case Theme.Light:
                    temp = new LightTheme();
                    break;
                case Theme.Dark:
                    temp = new DarkTheme();
                    break;
                case Theme.System:
                default:
                    if (AppInfo.RequestedTheme == AppTheme.Dark)
                    {
                        temp = new DarkTheme();
                    }
                    else
                    {
                        temp = new LightTheme();
                    }
                    break;
            }

            var dics = App.Current.Resources;
            dics.MergedDictionaries.Clear();
            dics.Add(temp);

            UserSettings.Current.Theme = theme;
        }

        public static Theme RealTheme
        {
            get
            {
                var dics = App.Current.Resources;
                var isCurrentDark = dics.MergedDictionaries.Any(x => x is DarkTheme);
                return isCurrentDark ? Theme.Dark : Theme.Light;
            }
        }

        public static void OnResume()
        {
            if (UserSettings.Current.Theme != Theme.System)
                return;

            var realTheme = RealTheme;
            ResourceDictionary temp = null;
            if (AppInfo.RequestedTheme == AppTheme.Dark && realTheme == Theme.Light)
            {
                temp = new DarkTheme();
            }
            else if (AppInfo.RequestedTheme == AppTheme.Light && realTheme == Theme.Dark)
            {
                temp = new LightTheme();
            }

            if (null == temp)
                return;

            var dics = App.Current.Resources;
            dics.MergedDictionaries.Clear();
            dics.Add(temp);
        }
    }
}
