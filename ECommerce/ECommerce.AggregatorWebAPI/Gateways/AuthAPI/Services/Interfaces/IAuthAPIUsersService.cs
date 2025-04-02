namespace ECommerce.AggregatorWebAPI.Gateways.AuthAPI.Services.Interfaces;

public interface IAuthAPIUsersService
{
    public Task<GetUsersViewModelResponse> AuthAPIGetUsers();
    public Task<DetailUserViewModelResponse> AuthAPIDetailUserById(string id);
    public Task<CreateUserViewModelResponse> AuthAPICreateUser(CreateUserViewModel product);
    public Task<UpdateUserViewModelResponse> AuthAPIUpdateUserById(UpdateUserViewModel product);
    public Task<DetailUserViewModelResponse> AuthAPIDeleteUserById(string id);
}
