using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics; 

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]

namespace SliderDemos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
            AppCenter.Start("uwp=23e4974d-37d6-4064-ba24-43ae4a8d8d19;" +
                  "android=23e4974d-37d6-4064-ba24-43ae4a8d8d19" +
                  "ios={Your iOS App secret here}s",
                  typeof(Analytics));
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
