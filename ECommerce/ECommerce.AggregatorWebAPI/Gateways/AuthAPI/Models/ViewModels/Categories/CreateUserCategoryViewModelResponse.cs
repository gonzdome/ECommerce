namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Models.ViewModels.Categories;

public class CreateUserCategoryViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public CreateUserCategoryViewModel? Data { get; set; }
}
