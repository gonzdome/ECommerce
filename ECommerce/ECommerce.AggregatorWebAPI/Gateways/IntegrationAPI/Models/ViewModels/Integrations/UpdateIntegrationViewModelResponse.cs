namespace ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels.Integrations;

public class UpdateIntegrationViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public UpdateIntegrationViewModel? Data { get; set; }
}
