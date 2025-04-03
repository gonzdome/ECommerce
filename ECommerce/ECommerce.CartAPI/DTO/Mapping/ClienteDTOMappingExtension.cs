using ECommerce.CartAPI.Models.Entities;

namespace ECommerce.CartAPI.DTO.DTOMapping;

public static class ClienteDTOMappingExtension
{
    public static ClienteDTO MapToClienteDTO(this Cliente cliente)
    {
        if (cliente == null)
            return null;

        return new ClienteDTO()
        {
            clienteId = cliente.clienteId,
            categoria = cliente.categoria,
            cpf = cliente.cpf,
            nome = cliente.nome,
            CreatedAt = cliente.CreatedAt,
            UpdatedAt = cliente.UpdatedAt,
            Active = cliente.Active,
            Excluded = cliente.Excluded,
        };
    }

    public static Cliente MapToCliente(this ClienteDTO clienteDTO)
    {
        if (clienteDTO == null)
            return null;

        return new Cliente()
        {
            clienteId = clienteDTO.clienteId,
            categoria = clienteDTO.categoria,
            cpf = clienteDTO.cpf,
            nome = clienteDTO.nome,
            CreatedAt = clienteDTO.CreatedAt,
            UpdatedAt = clienteDTO.UpdatedAt,
            Active = clienteDTO.Active,
            Excluded = clienteDTO.Excluded,
        };
    }
}
