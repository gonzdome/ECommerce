namespace ECommerce.AggregatorWebAPI.Models.ViewModels.Category;

public class UpdateCategoryViewModel
{
    public Guid Id { get; set; }

    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }
}
