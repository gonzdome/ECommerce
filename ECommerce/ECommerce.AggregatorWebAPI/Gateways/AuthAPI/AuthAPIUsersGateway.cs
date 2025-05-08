namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI;

public class AuthAPIUsersGateway
{
    private readonly APIClient _apiClient;
    private const string apiEndpoint = "https://localhost:7131/User";

    public AuthAPIUsersGateway(APIClient apiClient)
    {
        _apiClient = apiClient;
    }

    protected internal async Task<DetailUserViewModelResponse> DetailUserById(string id)
    {
        var apiResponse = await _apiClient.Handle("GET", "AuthAPI", $"{apiEndpoint}/GetUserDetailsById?id={id}");

        var response = new DetailUserViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<DetailUserViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<GetUsersViewModelResponse> GetUsers()
    {
        var apiResponse = await _apiClient.Handle("GET", "AuthAPI", $"{apiEndpoint}/GetUsers");

        var response = new GetUsersViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<IEnumerable<GetUsersViewModel>>(apiResponse.Data);
        return response;
    }

    protected internal async Task<CreateUserViewModelResponse> CreateUser(CreateUserViewModel userToCreate)
    {
        var apiResponse = await _apiClient.Handle("POST", "AuthAPI", $"{apiEndpoint}/CreateUser", userToCreate);

        var response = new CreateUserViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<CreateUserViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<UpdateUserViewModelResponse> UpdateUserById(UpdateUserViewModel userToUpdate)
    {
        var apiResponse = await _apiClient.Handle("PUT", "AuthAPI", $"{apiEndpoint}/UpdateUserById", userToUpdate);

        var response = new UpdateUserViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (response.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<UpdateUserViewModel>(apiResponse.Data);
        return response;
    }

    protected internal async Task<DetailUserViewModelResponse> DeleteUserById(string id)
    {
        var apiResponse = await _apiClient.Handle("DELETE", "AuthAPI", $"{apiEndpoint}/DeleteUserById?id={id}");

        var response = new DetailUserViewModelResponse() { Success = apiResponse.Success, Code = apiResponse.Code, Message = apiResponse.Message };
        if (apiResponse.Success == false) return response;

        response.Data = JsonConvert.DeserializeObject<DetailUserViewModel>(apiResponse.Data);
        return response;
    }
}
