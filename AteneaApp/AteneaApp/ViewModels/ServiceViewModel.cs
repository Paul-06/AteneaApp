using AteneaApp.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace AteneaApp.ViewModels
{
    public class ServiceViewModel : BaseViewModel
    {
        #region FIELDS
        private string _titulo = "Nuestros Servicios";
        private ObservableCollection<ServiceModel> _services;
        #endregion

        #region CONSTRUCTOR
        public ServiceViewModel(INavigation navigation)
        {
            Navigation = navigation;
            LoadItems();
        }
        #endregion

        #region PROPERTIES
        public ObservableCollection<ServiceModel> Services
        {
            get { return _services; }
            set
            {
                if (_services != value)
                {
                    _services = value;
                    OnPropertyChanged(nameof(Services)); // Notificar cambios en la propiedad
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
                var serviceList = await App.CarDataService.GetItemsAsync();
                Services = new ObservableCollection<ServiceModel>(serviceList);
                Debug.Print(Services[0].Icon);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error:", ex.Message, "Aceptar");
            }
        }
        #endregion

        #region COMMANDS
        #endregion
    }
}
