using AteneaApp.Models;
using AteneaApp.ViewModels;
using AteneaApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AteneaApp.Cells
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CatalogItemCard : StackLayout
	{
		public CatalogItemCard()
		{
			InitializeComponent();
			BindingContext = new CatalogueViewModel(Navigation);
		}

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var carModel = this.BindingContext as CarModel; // Asume que el contexto de enlace es de tipo CarModel
            if (carModel != null)
            {
                // Asume que tienes una página llamada CarDetailPage que tiene un constructor que acepta CarModel
                var detailPage = new CarDetailPage(carModel);
                await Navigation.PushModalAsync(detailPage); // Navega a la nueva página con el objeto CarModel
            }
        }

    }
}