namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Models.ViewModels.Categories;

public class UpdateUserCategoryViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public UpdateUserCategoryViewModel? Data { get; set; }
}
