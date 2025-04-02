namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Models.ViewModels.Categories;

public class UpdateCategoryViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public UpdateCategoryViewModel? Data { get; set; }
}
