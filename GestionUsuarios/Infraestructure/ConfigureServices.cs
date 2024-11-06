using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionUsuarios.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GestionUsuarios.Infraestructure
{
    public class Startup
    {
              public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<UserDbContext>(options =>
                options.UseSqlServer("YourConnectionString")); // 
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddControllers();
            services.AddMediatR(typeof(Program).Assembly);
        }
    }
}