using System.Text.Json;

namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI;

public class ProductAPICategoriesGateway
{
    private readonly APIClient _apiClient;
    private const string apiEndpoint = "/Category";

    public ProductAPICategoriesGateway(APIClient apiClient)
    {
        _apiClient = apiClient;
    }

    protected internal async Task<DetailCategoryViewModelResponse> DetailCategoryById(string id)
    {
        var apiResponse = await _apiClient.Handle("GET", "ProductAPI", $"{apiEndpoint}/GetCategoryDetailsById?id={id}");

        var response = new DetailCategoryViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<DetailCategoryViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<GetCategoriesViewModelResponse> GetCategories()
    {
        var apiResponse = await _apiClient.Handle("GET", "ProductAPI", $"{apiEndpoint}/GetCategories");

        var response = new GetCategoriesViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<IEnumerable<GetCategoriesViewModel>>(apiResponse.Data);
        return response;
    }

    protected internal async Task<CreateCategoryViewModelResponse> CreateCategory(CreateCategoryViewModel categoryToCreate)
    {
        var apiResponse = await _apiClient.Handle("POST", "ProductAPI", $"{apiEndpoint}/CreateCategory", categoryToCreate);

        var response = new CreateCategoryViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<CreateCategoryViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<UpdateCategoryViewModelResponse> UpdateCategoryById(UpdateCategoryViewModel categoryToUpdate)
    {
        var apiResponse = await _apiClient.Handle("PUT", "ProductAPI", $"{apiEndpoint}/UpdateCategoryById", categoryToUpdate);

        var response = new UpdateCategoryViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<UpdateCategoryViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<DetailCategoryViewModelResponse> DeleteCategoryById(string id)
    {
        var apiResponse = await _apiClient.Handle("DELETE", "ProductAPI", $"{apiEndpoint}/DeleteCategoryById?id={id}");

        var response = new DetailCategoryViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<DetailCategoryViewModel>(apiResponse.Data);
        return response;
    }
}
