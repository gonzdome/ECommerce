namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Models.ViewModels.Products;

public class CreateProductViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public CreateProductViewModel? Data { get; set; }
}
