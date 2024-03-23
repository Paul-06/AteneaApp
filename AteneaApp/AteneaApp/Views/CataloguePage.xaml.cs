using AteneaApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AteneaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CataloguePage : ContentPage
	{
		public CataloguePage()
		{
			InitializeComponent();
			BindingContext = new CatalogueViewModel(Navigation);
		}
	}
}