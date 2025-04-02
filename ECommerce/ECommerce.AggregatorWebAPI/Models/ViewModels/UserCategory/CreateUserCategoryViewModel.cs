namespace ECommerce.AggregatorWebAPI.Models.ViewModels.User;

public class CreateUserCategoryViewModel
{
    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }
}
