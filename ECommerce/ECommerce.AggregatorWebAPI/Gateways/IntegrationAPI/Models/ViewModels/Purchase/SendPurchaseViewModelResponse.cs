namespace ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels.Purchase;

public class SendPurchaseViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }

    public object Data { get; set; }
}
