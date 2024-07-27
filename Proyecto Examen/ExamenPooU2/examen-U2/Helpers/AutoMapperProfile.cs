using AutoMapper;
using examen_U2.Database.Entities;
using examen_U2.Dtos.Clientes;


namespace BlogUNAH.API.Helpers;
//esta clase se usa con le extension AutoMapper

//la herencia de Profile viene  de la extension
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        MapsForClientes();
        
    }
    //Esto tiene que añadirse a los servicios del Startup se repite de abajo


    private void MapsForClientes()
    {
        //convertir de base a api
        //origen,   //todas las caracteristica similares
        CreateMap<ClienteEntity, ClienteDto>();

        //convertir de api a base
        //origen del api            //
        CreateMap<ClienteCreateDto, ClienteEntity>();

        
    }
    //Esto tiene que añadirse a los servicios del Startup


}
