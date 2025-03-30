namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Models.ViewModels.Categories;

public class GetCategoriesViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public IEnumerable<GetCategoriesViewModel>? Data { get; set; }
}
