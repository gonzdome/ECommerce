namespace ECommerce.IntegrationAPI.Gateways.PurchaseAPI.Models.ViewModels.Purchase;

public class PurchaseAPIPostResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }

    public object? Data { get; set; }
}
