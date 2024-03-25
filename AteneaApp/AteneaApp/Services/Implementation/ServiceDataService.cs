using AteneaApp.Models;
using Supabase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace AteneaApp.Services.Implementation
{
    public class ServiceDataService : IApiDataService<ServiceModel>
    {
        private readonly Client _supabase;

        public ServiceDataService(Client supabase)
        {
            _supabase = supabase;
        }

        // Methods
        public async Task<bool> AddItemAsync(ServiceModel item)
        {
            try
            {
                var response = await _supabase
                    .From<ServiceModel>()
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

        public Task<bool> UpdateItemAsync(ServiceModel item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            try
            {
                await _supabase
                  .From<ServiceModel>()
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

        public async Task<ServiceModel> GetItemAsync(int id)
        {
            try
            {
                var service = await _supabase.From<ServiceModel>().Where(x => x.Id == id).Get();
                var serviceModel = service.Model;
                return serviceModel;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<ServiceModel>> GetItemsAsync()
        {
            Debug.Print("Iniciando obtencion de datos");

            var result = await _supabase.From<ServiceModel>().Get();
            var services = result.Models;

            if (services.Count == 0)
            {
                Debug.Print("La lista de servicios esta vacia");
                return new List<ServiceModel>();
            }

            return services;
        }
    }
}
