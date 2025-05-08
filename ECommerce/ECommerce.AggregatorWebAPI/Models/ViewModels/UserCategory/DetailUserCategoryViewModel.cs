namespace ECommerce.AggregatorWebAPI.Models.ViewModels.User;

public class DetailUserCategoryViewModel
{
    public Guid Id { get; set; }

    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }

    public ICollection<UpdateUserCategoryViewModel>? Products { get; set; }
}
