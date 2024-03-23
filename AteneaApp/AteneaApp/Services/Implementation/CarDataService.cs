using AteneaApp.Models;
using Supabase;
using AteneaApp.Secrets;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace AteneaApp.Services.Implementation
{
    // La implementación también será genérica
    public class CarDataService : IApiDataService<CarModel>
    {
        private readonly string _supabaseUrl = UserSecretsManager.Settings["supabaseUrl"];
        private readonly string _supabaseKey = UserSecretsManager.Settings["supabaseKey"];

        public Task<bool> AddItemAsync(CarModel item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CarModel> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CarModel>> GetItemsAsync()
        {
            Debug.Print("Iniciando obtencion de datos");

            var options = new SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            var supabase = new Client(_supabaseUrl, _supabaseKey, options);
            await supabase.InitializeAsync();

            var result = await supabase.From<CarModel>().Get();
            var cars = result.Models;

            if (cars.Count == 0)
            {
                Debug.Print("La lista de carros esta vacia");
            }
            else
            {
                foreach (var c in cars)
                {
                    Debug.Print(message: $"Auto: {c.Modelo}");
                }
            }

            return cars;
        }

        public Task<bool> UpdateItemAsync(CarModel item)
        {
            throw new NotImplementedException();
        }
    }
}
