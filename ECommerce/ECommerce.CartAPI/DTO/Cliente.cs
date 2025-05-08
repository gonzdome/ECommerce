namespace ECommerce.CartAPI.DTO;

public class ClienteDTO
{
    public Guid clienteId { get; set; }
    public string nome { get; set; }
    public string cpf { get; set; }
    public string categoria { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool Active { get; set; } = true;
    public bool Excluded { get; set; } = false;
}
