namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Models.ViewModels.Categories;

public class DetailUserCategoryViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public DetailUserCategoryViewModel? Data { get; set; }
}
