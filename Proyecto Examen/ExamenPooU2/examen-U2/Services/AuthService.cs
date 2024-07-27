using BlogUNAH.API.Services.Interfaces;

namespace BlogUNAH.API.Services;
//authenteticacion service
public class AuthService : IAuthService
{
    public string GetUserId()
    {
        //anteriormente es logica de seguridad para saber
        //el id del usuario
        //id temporal del usuario:
        return "134e6069-f364-4dc2-b6a9-cdf6f6a61b45";
    }
}
