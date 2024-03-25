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
    public class CarDataService : IApiDataService<CarModel>
    {
        private readonly Client _supabase;

        public CarDataService(Client supabase)
        {
            _supabase = supabase;
        }

        // Methods
        public async Task<bool> AddItemAsync(CarModel item)
        {
            try
            {
                var response = await _supabase
                    .From<CarModel>()
                    .Insert(item);

                Debug.Print(response.ResponseMessage.ToString());
                return true;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
                return false;
            }
        }

        public Task<bool> UpdateItemAsync(CarModel item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            try
            {
                await _supabase
                  .From<CarModel>()
                  .Where(x => x.Id == id)
                  .Delete();

                return true;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                return false;
            }
        }

        public async Task<CarModel> GetItemAsync(int id)
        {
            try
            {
                var car = await _supabase.From<CarModel>().Where(x => x.Id == id).Get();
                var carModel = car.Model;
                return carModel;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<CarModel>> GetItemsAsync()
        {
            Debug.Print("Iniciando obtencion de datos");

            var result = await _supabase.From<CarModel>().Get();
            var cars = result.Models;

            if (cars.Count == 0)
            {
                Debug.Print("La lista de carros esta vacia");
                return new List<CarModel>();
            }

            return cars;
        }
    }
}
