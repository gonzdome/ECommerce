namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Models.ViewModels.Products;

public class DetailProductViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public DetailProductViewModel? Data { get; set; }
}
