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
        static WorkUnit _workUnit;
        public App()
        {
            InitializeComponent();

            MainPage = new HomeTabbedPage();
        }

        public static WorkUnit WorkUnit
        {
            get
            {
                if (_workUnit is null)
                {
                    _workUnit = new WorkUnit();
                }

                return _workUnit;
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
