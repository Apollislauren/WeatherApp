using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace WeatherApp
{
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    namespace weatherApp
    {
        public partial class App : Application
        {
            public App()
            {
                InitializeComponent();

                MainPage = new MainPage();
            }

            private void InitializeComponent()
            {
                throw new NotImplementedException();
            }

            protected override void OnStart()
            {
            }

            protected override void OnSleep()
            {
            }

            protected override void OnResume()
            {
            }
        }
    }
}