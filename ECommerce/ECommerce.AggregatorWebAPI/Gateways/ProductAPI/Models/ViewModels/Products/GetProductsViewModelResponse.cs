namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Models.ViewModels.Products;

public class GetProductsViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public IEnumerable<GetProductsViewModel>? Data { get; set; }
}
