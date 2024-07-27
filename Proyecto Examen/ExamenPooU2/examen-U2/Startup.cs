using BlogUNAH.API.Helpers;
using examen_U2.Database;
using examen_U2.Services;
using examen_U2.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace examen_U2
{
    public class Startup
    {
        private IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            var name = Configuration.GetConnectionString("DefaultConnection");

            //Add DbContext
            services.AddDbContext<ExamenContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
  

            //Add custom services
            services.AddTransient<IClienteService, ClientesSQLService>();
            services.AddTransient<IAuthService, AuthService>();

            //Add Automapper
            services.AddAutoMapper(typeof(AutoMapperProfile));
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
