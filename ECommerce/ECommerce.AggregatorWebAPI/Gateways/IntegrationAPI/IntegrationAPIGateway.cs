namespace ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI;

public class IntegrationAPIGateway
{
    private readonly APIClient _apiClient;
    private const string apiEndpoint = "https://localhost:0000/Purchase";

    public IntegrationAPIGateway(APIClient apiClient)
    {
        _apiClient = apiClient;
    }

    protected internal async Task<SendPurchaseViewModelResponse> IntegrationAPIPurchase(SendPurchaseViewModel IntegrationAPIPostRequest)
    {
        var apiResponse = await _apiClient.Handle("POST", "IntegrationAPI", $"{apiEndpoint}/SendPurchase", IntegrationAPIPostRequest);

        var response = new SendPurchaseViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<SendPurchaseViewModelResponse>(apiResponse.Data);
        return response;
    }
}
