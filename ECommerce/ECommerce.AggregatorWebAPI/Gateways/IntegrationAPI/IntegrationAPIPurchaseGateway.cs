namespace ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI;

public class IntegrationAPIPurchaseGateway
{
    private readonly APIClient _apiClient;
    private const string apiEndpoint = "https://localhost:7082/Purchase";

    public IntegrationAPIPurchaseGateway(APIClient apiClient)
    {
        _apiClient = apiClient;
    }

    protected internal async Task<SendPurchaseViewModelResponse> IntegrationAPIPurchase(SendPurchaseViewModel sendPurchaseViewModel)
    {
        var apiResponse = await _apiClient.Handle("POST", "IntegrationAPI", $"{apiEndpoint}/SendPurchase", sendPurchaseViewModel);

        var response = new SendPurchaseViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<SendPurchaseViewModelResponse>(apiResponse.Data);
        return response;
    }
}
