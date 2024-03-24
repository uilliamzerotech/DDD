using Application.Dto;
using Data.Entity;

namespace Application.Mapping
{
    public class ClienteMap
    {
        public ClienteDTO MapToClienteDTO(Cliente cliente)
        {
            return new ClienteDTO
            {
               Id = cliente.Id,
               Email = cliente.Email,
               Endereco = cliente.Endereco,
               Nome = cliente.Nome,
               Telefone = cliente.Telefone
            };
        }

        public Cliente MapToCliente(ClienteDTO cliente)
        {
            return new Cliente
            {
                Id = cliente.Id,
                Email = cliente.Email,
                Endereco = cliente.Endereco,
                Nome = cliente.Nome,
                Telefone = cliente.Telefone
            };
        }
    }
}
