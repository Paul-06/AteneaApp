using AteneaApp.Data;
using Supabase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AteneaApp.Services.Implementation
{
    public class WorkUnit
    {
        private readonly Client _client = Task.Run(async () => 
        await SupabaseContext.InitializeClientAsync()).Result;
        
        public CarDataService CarDataService { get; set; }
        public ServiceDataService ServiceDataService { get; set; }

        public WorkUnit()
        {
            CarDataService = new CarDataService(_client);
            ServiceDataService = new ServiceDataService(_client);
        }
    }
}
