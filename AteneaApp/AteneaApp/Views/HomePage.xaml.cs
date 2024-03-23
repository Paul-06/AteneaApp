using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AteneaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        // Declara la propiedad ImageSources
        public List<string> ImageSources { get; set; }
        public HomePage ()

		{

			InitializeComponent ();

            ImageSources = new List<string>
            {
                "descuent.jpg",
                "descuento.png",
                "descu.png" 
            };
            BindingContext = this;
        }


        private async void Button_ClickedAsync(object sender, EventArgs e)
		{
            string phoneNumber = "51918993755";
            string message = "Hola, quisiera informacion...";
            string  url = $"whatsapp://send?phone={phoneNumber}&text={message}";
            await Browser.OpenAsync(url);

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            string number = "51918993755";
            string message = "Hola.%20Quiero%20información.";
            string url = $"https://wa.me/{number}/?text={message}";

            await Browser.OpenAsync(url);
        }


    }
    }
