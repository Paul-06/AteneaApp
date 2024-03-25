using AteneaApp.Models;
using AteneaApp.Views;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AteneaApp.ViewModels
{
    public class CatalogueViewModel : BaseViewModel
    {
        #region FIELDS
        private string _titulo = "Autos Disponibles";
        private ObservableCollection<CarModel> _cars;
        #endregion

        #region CONSTRUCTOR
        public CatalogueViewModel(INavigation navigation)
        {
            Navigation = navigation;
            LoadItems();
        }
        #endregion

        #region PROPERTIES
        public ObservableCollection<CarModel> Cars
        {
            get { return _cars; }
            set
            {
                if (_cars != value)
                {
                    _cars = value;
                    OnPropertyChanged(nameof(Cars)); // Notificar cambios en la propiedad
                }
            }
        }

        public string Titulo
        {
            get { return _titulo; }
        }
        #endregion

        #region METHODS
        private async void LoadItems()
        {
            try
            {
                var carList = await App.WorkUnit.CarDataService.GetItemsAsync();
                Cars = new ObservableCollection<CarModel>(carList);

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error:", ex.Message, "Aceptar");
            }
        }

        private async Task OpenDetailPageAsync(CarModel model)
        {
            await Navigation.PushModalAsync(new CarDetailPage(model));
        }
        #endregion

        #region COMMANDS
        public ICommand ViewDetailsCommand => new Command<CarModel>(async (carModel) => await OpenDetailPageAsync(carModel));
        #endregion
    }
}
