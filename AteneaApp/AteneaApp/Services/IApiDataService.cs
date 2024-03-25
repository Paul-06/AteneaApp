using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AteneaApp.Services
{
    public interface IApiDataService<T> where T : class
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> DeleteItemAsync(int id);
        Task<T> GetItemAsync(int id);
        Task<IEnumerable<T>> GetItemsAsync();
    }
}
