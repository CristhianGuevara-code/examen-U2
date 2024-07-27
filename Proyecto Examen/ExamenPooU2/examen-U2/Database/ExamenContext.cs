using examen_U2.Database.Entities;
using examen_U2.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;


namespace examen_U2.Database
{
    public class ExamenContext : DbContext
    {
        private readonly IAuthService _authService;

        public ExamenContext(DbContextOptions options) : base(options)
        {
        }

   

        public ExamenContext(DbContextOptions options,
              IAuthService authService
              ) : base(options)
        {
            this._authService = authService;
        }
        
        public DbSet<ClienteEntity> Clientes { get; set; }
    }
}
