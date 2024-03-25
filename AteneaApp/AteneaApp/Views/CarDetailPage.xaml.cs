using AteneaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AteneaApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarDetailPage : ContentPage
	{
		public CarDetailPage (CarModel model)
		{
			InitializeComponent ();
			BindingContext = model;
		}
	}
}