namespace ECommerce.AggregatorWebAPI.Models.ViewModels.User;

public class DetailUserViewModel
{
    public Guid Id { get; set; }

    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }

    [MinLength(3)]
    [MaxLength(200)]
    public string Email { get; set; }
    public string Document { get; set; }
    public string Password { get; set; }
    public string OldPassword { get; set; }

    public Guid CategoryId { get; set; }

    public DateTime CreatedAt { get; set; }
}
