using Xamarin.Forms;
using System;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;

namespace AteneaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
      

        public ProfilePage()
        {
            InitializeComponent();
            

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            string number = "51918993755";
            string message = "Hola.%20Quiero%20información.";
            string url = $"https://wa.me/{number}/?text={message}";

            await Browser.OpenAsync(url);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MapsPage());

        }
    }
}
