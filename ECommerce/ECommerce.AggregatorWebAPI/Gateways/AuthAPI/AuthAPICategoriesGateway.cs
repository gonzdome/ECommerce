namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI;

public class AuthAPICategoriesGateway
{
    private readonly APIClient _apiClient;
    private const string apiEndpoint = "https://localhost:7131/Category";

    public AuthAPICategoriesGateway(APIClient apiClient)
    {
        _apiClient = apiClient;
    }

    protected internal async Task<DetailUserCategoryViewModelResponse> DetailCategoryById(string id)
    {
       var apiResponse = await _apiClient.Handle("GET", "AuthAPI", $"{apiEndpoint}/GetCategoryDetailsById?id={id}");

        var response = new DetailUserCategoryViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<DetailUserCategoryViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<GetUserCategoriesViewModelResponse> GetCategories()
    {
        var apiResponse = await _apiClient.Handle("GET", "AuthAPI", $"{apiEndpoint}/GetCategories");

        var response = new GetUserCategoriesViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<IEnumerable<GetUserCategoriesViewModel>>(apiResponse.Data);
        return response;
    }

    protected internal async Task<CreateUserCategoryViewModelResponse> CreateCategory(CreateUserCategoryViewModel categoryToCreate)
    {
        var apiResponse = await _apiClient.Handle("POST", "AuthAPI", $"{apiEndpoint}/CreateCategory", categoryToCreate);

        var response = new CreateUserCategoryViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<CreateUserCategoryViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<UpdateUserCategoryViewModelResponse> UpdateCategoryById(UpdateUserCategoryViewModel categoryToUpdate)
    {
        var apiResponse = await _apiClient.Handle("PUT", "AuthAPI", $"{apiEndpoint}/UpdateCategoryById", categoryToUpdate);

        var response = new UpdateUserCategoryViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<UpdateUserCategoryViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<DetailUserCategoryViewModelResponse> DeleteCategoryById(string id)
    {
        var apiResponse = await _apiClient.Handle("DELETE", "AuthAPI", $"{apiEndpoint}/DeleteCategoryById?id={id}");

        var response = new DetailUserCategoryViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<DetailUserCategoryViewModel>(apiResponse.Data);
        return response;
    }
}
