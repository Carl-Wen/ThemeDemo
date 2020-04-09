using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;

namespace ThemeDemo
{
    public class UserSettings : INotifyPropertyChanged
    {
        private static UserSettings _current;

        static UserSettings()
        {
            _current = new UserSettings();
        }

        public static UserSettings Current => _current;

        private UserSettings() { }

        const string KeyTheme = "theme";
        public Theme Theme
        {
            get
            {
                var temp = Preferences.Get(KeyTheme, (int)Theme.System);
                return (Theme)temp;
            }

            set
            {
                Preferences.Set(KeyTheme, (int)value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
