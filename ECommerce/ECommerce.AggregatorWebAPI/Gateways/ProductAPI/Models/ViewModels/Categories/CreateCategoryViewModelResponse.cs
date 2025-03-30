namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Models.ViewModels.Categories;

public class CreateCategoryViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public CreateCategoryViewModel? Data { get; set; }
}
