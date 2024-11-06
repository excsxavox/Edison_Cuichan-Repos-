using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GestionItems.Infraestructure;
using GestionItemsTest.Data;
using MediatR;

namespace GestionItemsTest.Infraestructure
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ItemDbContext>(options =>
                options.UseSqlServer("YourConnectionString")); // Cambia por tu cadena de conexión
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddControllers();
            services.AddMediatR(typeof(Program).Assembly);
        }
    }
}
