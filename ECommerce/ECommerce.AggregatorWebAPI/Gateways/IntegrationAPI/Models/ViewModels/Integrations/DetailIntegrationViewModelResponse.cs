namespace ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels.Integrations;

public class DetailIntegrationViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public DetailIntegrationViewModel? Data { get; set; }
}
