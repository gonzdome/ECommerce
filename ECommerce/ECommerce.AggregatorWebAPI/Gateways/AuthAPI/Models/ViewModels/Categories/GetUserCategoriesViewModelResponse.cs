namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Models.ViewModels.Categories;

public class GetUserCategoriesViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public IEnumerable<GetUserCategoriesViewModel>? Data { get; set; }
}
