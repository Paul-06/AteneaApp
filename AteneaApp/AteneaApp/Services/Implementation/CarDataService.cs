using AteneaApp.Models;
using Supabase;
using AteneaApp.Secrets;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using static Postgrest.Constants;
using AteneaApp.Data;

namespace AteneaApp.Services.Implementation
{
    // La implementación también será genérica
    public class CarDataService : IApiDataService<ServiceModel>
    {
        private readonly Client _supabase = Task.Run(
            async () => await SupabaseContext.InitializeClientAsync()
            ).Result;

        // Methods
        public Task<bool> AddItemAsync(ServiceModel item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceModel> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ServiceModel>> GetItemsAsync()
        {
            Debug.Print("Iniciando obtencion de datos");

            var result = await _supabase.From<ServiceModel>().Get();
            var cars = result.Models;

            if (cars.Count == 0)
            {
                Debug.Print("La lista de carros esta vacia");
            }

            return cars;
        }

    }
}
