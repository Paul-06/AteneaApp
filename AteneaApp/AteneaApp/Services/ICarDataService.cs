using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AteneaApp.Models;

namespace AteneaApp.Services
{
    public interface ICarDataService : IApiDataService<CarModel>
    {
        Task<bool> UpdateItemAsync(CarModel item);
    }
}