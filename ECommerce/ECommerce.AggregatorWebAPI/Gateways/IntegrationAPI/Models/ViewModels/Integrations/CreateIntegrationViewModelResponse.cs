namespace ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels.Integrations;

public class CreateIntegrationViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public CreateIntegrationViewModel? Data { get; set; }
}
