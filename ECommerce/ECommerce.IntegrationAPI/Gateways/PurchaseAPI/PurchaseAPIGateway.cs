namespace ECommerce.IntegrationAPI.Gateways.PurchaseAPI;

public class PurchaseAPIGateway
{
    private readonly APIClient _apiClient;
    private const string apiEndpoint = "";

    public PurchaseAPIGateway(APIClient apiClient)
    {
        _apiClient = apiClient;
    }

    protected internal async Task<PurchaseAPIPostResponse> Purchase(PurchaseAPIPostRequest purchaseAPIPostRequest)
    {
        var purchaseHeaders = new List<ApiHeadersViewModel>();
        purchaseHeaders.Add(new ApiHeadersViewModel() { HeaderProperty = "email", HeaderValue = "email@hotmail.com" });

        var apiResponse = await _apiClient.Handle("POST", "Test", $"{apiEndpoint}", purchaseAPIPostRequest, purchaseHeaders);

        var response = new PurchaseAPIPostResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<PurchaseAPIPostResponse>(apiResponse.Data);
        return response;
    }
}