using System.Threading.Tasks;
using AteneaApp.Secrets;
using Supabase;

namespace AteneaApp.Data
{
    public static class SupabaseContext
    {
        private static readonly string _supabaseUrl = UserSecretsManager.Settings["supabaseUrl"];
        private static readonly string _supabaseKey = UserSecretsManager.Settings["supabaseKey"];
        public static async Task<Client> InitializeClientAsync()
        {
            var options = new SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            var supabase = new Client(_supabaseUrl, _supabaseKey, options);
            await supabase.InitializeAsync();

            return supabase;
        } 
    }
}