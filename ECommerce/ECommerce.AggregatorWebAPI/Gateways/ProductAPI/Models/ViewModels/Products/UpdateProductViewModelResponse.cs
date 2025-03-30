namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Models.ViewModels.Products;

public class UpdateProductViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public UpdateProductViewModel? Data { get; set; }
}
