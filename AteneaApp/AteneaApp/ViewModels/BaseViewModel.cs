using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AteneaApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        // Navigation property for page navigation
        public INavigation Navigation;

        // Event to notify when a property changes
        public event PropertyChangedEventHandler PropertyChanged;

        // Method to invoke the PropertyChanged event
        public void OnpropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        // Private field for the Foto property
        private ImageSource _foto;

        // Public property for an image source
        public ImageSource Foto
        {
            get { return _foto; }
            set
            {
                _foto = value;
                OnpropertyChanged();
            }
        }

        // Method to invoke the PropertyChanged event
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Method to display an alert dialog with a single cancel button
        public async Task DisplayAlert(string title, string message, string cancel)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        // Method to display an alert dialog with accept and cancel buttons
        public async Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }

        // Method to set a property's value and raise the PropertyChanged event if the value has changed
        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            field = value;
            OnPropertyChanged(propertyName);

            return true;
        }

        // Private field for the Title property
        private string _title;

        // Public property for the title
        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        // Private field for the IsBusy property
        private bool _isBusy;

        // Public property for a busy indicator
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                SetProperty(ref _isBusy, value);
            }
        }

        // Method to set a property's value and raise the PropertyChanged event if the value has changed
        protected void SetValue<T>(ref T backingFieled, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingFieled, value))
            {
                return;
            }

            backingFieled = value;

            OnPropertyChanged(propertyName);
        }
    }
}
