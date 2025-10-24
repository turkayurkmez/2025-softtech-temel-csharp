using Catalog.API.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Catalog.API.Extensions
{
    public static class AppExtensions
    {
        public static async Task<WebApplication> MigrateDatabase(this WebApplication app) { 
        
            var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<SampleDBContext>();
            await db.Database.MigrateAsync();

            return app;
        }
    }
}
