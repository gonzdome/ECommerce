namespace ECommerce.AggregatorWebAPI.Models.ViewModels.User;

public class UpdateUserCategoryViewModel
{
    public Guid Id { get; set; }

    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }
}
