using System.ComponentModel.DataAnnotations;

namespace ECommerce.ProductAPI.Models.Entities;

public class Purchase : CommonModelData
{
    [Required]
    public Guid CustomerId { get; set; }

    [Required]
    public Guid ProductId { get; set; }

    public int Quantity { get; set; } = 1;
    public bool Confirmed { get; set; } = false;
}
