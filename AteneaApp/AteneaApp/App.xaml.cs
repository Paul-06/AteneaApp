using AteneaApp.Models;
using AteneaApp.Services;
using AteneaApp.Services.Implementation;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AteneaApp
{
    public partial class App : Application
    {
        static IApiDataService<CarModel> _apiDataService;
        public App()
        {
            InitializeComponent();

            MainPage = new HomeTabbedPage();
        }

        public static IApiDataService<CarModel> CarDataService
        {
            get
            {
                if (_apiDataService is null)
                {
                    _apiDataService = new CarDataService();
                }

                return _apiDataService;
            }
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
