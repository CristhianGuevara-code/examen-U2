using examen_U2.Dtos.Clientes;
using examen_U2.Dtos.Common;
using System.Threading.Tasks;

namespace examen_U2.Services.Interface
{
    public interface IClienteService
    {
       // Task<ResponseDto<List<ClienteDto>>> GetClientesListAsync();
        Task<ResponseDto<ClienteDto>> GetClienteByIdAsync(Guid id);
        Task<ResponseDto<ClienteDto>> CreateAsync(ClienteCreateDto dto);
    }
}
