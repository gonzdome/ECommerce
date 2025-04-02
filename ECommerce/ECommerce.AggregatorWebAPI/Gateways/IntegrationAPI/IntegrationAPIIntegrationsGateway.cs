namespace ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI;

public class IntegrationAPIIntegrationsGateway
{
    private readonly APIClient _apiClient;
    private const string apiEndpoint = "https://localhost:7082/Integration";

    public IntegrationAPIIntegrationsGateway(APIClient apiClient)
    {
        _apiClient = apiClient;
    }

    protected internal async Task<DetailIntegrationViewModelResponse> DetailIntegrationByFlow(string flowName)
    {
        var apiResponse = await _apiClient.Handle("GET", "IntegrationAPI", $"{apiEndpoint}/GetIntegrationDetailsByFlow?flowName={flowName}");

        var response = new DetailIntegrationViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<DetailIntegrationViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<GetIntegrationsViewModelResponse> GetIntegrations()
    {
        var apiResponse = await _apiClient.Handle("GET", "IntegrationAPI", $"{apiEndpoint}/GetIntegrations");

        var response = new GetIntegrationsViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<IEnumerable<GetIntegrationsViewModel>>(apiResponse.Data);
        return response;
    }

    protected internal async Task<CreateIntegrationViewModelResponse> CreateIntegration(CreateIntegrationViewModel integrationToCreate)
    {
        var apiResponse = await _apiClient.Handle("POST", "IntegrationAPI", $"{apiEndpoint}/CreateIntegration", integrationToCreate);

        var response = new CreateIntegrationViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<CreateIntegrationViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<UpdateIntegrationViewModelResponse> UpdateIntegrationById(UpdateIntegrationViewModel integrationToUpdate)
    {
        var apiResponse = await _apiClient.Handle("PUT", "IntegrationAPI", $"{apiEndpoint}/UpdateIntegrationById", integrationToUpdate);

        var response = new UpdateIntegrationViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<UpdateIntegrationViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<DetailIntegrationViewModelResponse> DeleteIntegrationById(string id)
    {
        var apiResponse = await _apiClient.Handle("DELETE", "IntegrationAPI", $"{apiEndpoint}/DeleteIntegrationById?id={id}");

        var response = new DetailIntegrationViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<DetailIntegrationViewModel>(apiResponse.Data);
        return response;
    }
}
