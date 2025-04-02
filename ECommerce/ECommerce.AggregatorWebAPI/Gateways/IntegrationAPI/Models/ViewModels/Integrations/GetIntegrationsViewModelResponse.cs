namespace ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels.Integrations;

public class GetIntegrationsViewModelResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }


    public IEnumerable<GetIntegrationsViewModel>? Data { get; set; }
}
