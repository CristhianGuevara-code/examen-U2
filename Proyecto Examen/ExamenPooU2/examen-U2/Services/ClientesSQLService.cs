using AutoMapper;
using examen_U2.Database;
using examen_U2.Database.Entities;
using examen_U2.Dtos.Clientes;
using examen_U2.Dtos.Common;
using examen_U2.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace examen_U2.Services
{
    public class ClientesSQLService : IClienteService
    {
        private readonly ExamenContext _context;
        private readonly IMapper _mapper;

        public ClientesSQLService(ExamenContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        public async Task<ResponseDto<ClienteDto>> CreateAsync(ClienteCreateDto dto)
        {
            var ClienteEntity = _mapper.Map<ClienteEntity>(dto);

            _context.Clientes.Add(ClienteEntity);
            await _context.SaveChangesAsync();
            var clienteDto = _mapper.Map<ClienteDto>(ClienteEntity);

            return new ResponseDto<ClienteDto>
            {
                StatusCode = 201,
                Status = true,
                Message = "Registro creado Correctamente",
                Data = clienteDto
            };
        }

        public async Task<ResponseDto<ClienteDto>> GetClienteByIdAsync(Guid id)
        {
            var clienteEntity = await _context.Clientes.FirstOrDefaultAsync(c => c.identityNumber == id);
            if (clienteEntity == null) 
            {
                return new ResponseDto<ClienteDto>
                {
                    StatusCode = 400,
                    Status = false,
                    Message = "Registro No encontrado",
                };
            }
            var clienteDto = _mapper.Map<ClienteDto>(clienteEntity);

            return new ResponseDto<ClienteDto>
            {
                StatusCode = 200,
                Status = true,
                Message = "Registro encontrado",
                Data = clienteDto
            };
        }

        //public Task<ResponseDto<List<ClienteDto>>> GetClientesListAsync()
        //{
        //    var clientesEntity = _context.Clientes.ToListAsync();
        //    var clientesDtos = _mapper.Map<List<ClienteDto>>(clientesEntity);

        //    return new ResponseDto<List<ClienteDto>>
        //    {
        //        StatusCode = 200,
        //        Status = true,
        //        Message = "Lista obtenida correctamente",
        //        Data = clientesDtos
        //    };
        //}
    }
}
