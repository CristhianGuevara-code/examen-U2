using BlogUNAH.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace examen_U2.Database
{
    public class ExamenContext : DbContext
    {
        private readonly IAuthService _authService;
        public ExamenContext(DbContextOptions options,
              IAuthService authService
              ) : base(options)
        {
            this._authService = authService;
        }
    }
}
