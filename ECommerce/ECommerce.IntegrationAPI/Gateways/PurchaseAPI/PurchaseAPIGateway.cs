namespace ECommerce.IntegrationAPI.Gateways.PurchaseAPI;

public class PurchaseAPIGateway
{
    private readonly APIClient _apiClient;

    public PurchaseAPIGateway(APIClient apiClient)
    {
        _apiClient = apiClient;
    }

    protected internal async Task<PurchaseAPIPostResponse> Purchase(PurchaseAPIPostRequest purchaseAPIPostRequest, string ApiName, string ApiUri)
    {
        var purchaseHeaders = new List<ApiHeadersViewModel>();
        purchaseHeaders.Add(new ApiHeadersViewModel() { HeaderProperty = "email", HeaderValue = "" });

        var apiResponse = await _apiClient.Handle("POST", ApiName, ApiUri, purchaseAPIPostRequest, purchaseHeaders);

        var response = new PurchaseAPIPostResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<PurchaseAPIPostResponse.PurchaseResponse>(apiResponse.Data);
        return response;
    }
}