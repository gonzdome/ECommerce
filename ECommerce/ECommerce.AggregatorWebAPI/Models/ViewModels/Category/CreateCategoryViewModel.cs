namespace ECommerce.AggregatorWebAPI.Models.ViewModels.Category;

public class CreateCategoryViewModel
{
    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }
}
