using System;
using System.Collections.Generic;
using ThemeDemo.Themes;
using Xamarin.Forms;

namespace ThemeDemo.Page
{
    public partial class SelectThemePage : ContentPage
    {
        private Theme _theme = UserSettings.Current.Theme;
        public Theme Theme { get => _theme;
            private set
            {
                _theme = value;
                ThemeManager.ApplyTheme(Theme);

                Init();
            }
        }

        public bool IsSystem { get; private set; }
        public bool IsLight { get; set; }
        public bool IsDark { get; set; }

        public bool IsSystemEnable { get; private set; }
        public bool IsLightEnable { get; private set; }
        public bool IsDarkEnable { get; private set; }

        public SelectThemePage()
        {
            InitializeComponent();
            BindingContext = this;

            Init();
        }

        private void Init()
        {
            IsSystem = Theme == Theme.System;
            IsSystemEnable = !IsSystem;

            IsLight = Theme == Theme.Light;
            IsLightEnable = !IsLight;

            IsDark = Theme == Theme.Dark;
            IsDarkEnable = !IsDark;
        }

        void FollowSystemCheckedChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        {
            if (e.Value)
                Theme = Theme.System;
        }

        void LightCheckedChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        {
            if (e.Value)
                Theme = Theme.Light;
        }

        void DarkCheckedChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        {
            if (e.Value)
                Theme = Theme.Dark;
        }
    }
}
