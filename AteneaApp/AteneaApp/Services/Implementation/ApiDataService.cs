using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AteneaApp.Services.Implementation
{
    // La implementación también será genérica
    public class ApiDataService<T> : IApiDataService<T> where T : class
    {
        public Task<bool> AddItemAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(T item)
        {
            throw new NotImplementedException();
        }
    }
}
