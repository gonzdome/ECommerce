namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Services;

public class AuthAPIUsersService : AuthAPIUsersGateway, IAuthAPIUsersService
{
    public AuthAPIUsersService(APIClient apiClient) : base(apiClient)
    {
    }

    public async Task<DetailUserViewModelResponse> AuthAPIDetailUserById(string id)
    {
        var userDetails = await DetailUserById(id);
        return userDetails;
    }

    public async Task<GetUsersViewModelResponse> AuthAPIGetUsers()
    {
        var usersListed = await GetUsers();
        return usersListed;
    }

    public async Task<CreateUserViewModelResponse> AuthAPICreateUser(CreateUserViewModel user)
    {
        var createdUser = await CreateUser(user);
        return createdUser;
    }

    public async Task<UpdateUserViewModelResponse> AuthAPIUpdateUserById(UpdateUserViewModel user)
    {
        var updatedUser = await UpdateUserById(user);
        return updatedUser;
    }

    public async Task<DetailUserViewModelResponse> AuthAPIDeleteUserById(string id)
    {
        var deletedUser = await DeleteUserById(id);
        return deletedUser;
    }
}
