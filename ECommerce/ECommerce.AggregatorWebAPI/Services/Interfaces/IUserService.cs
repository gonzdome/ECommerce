namespace ECommerce.AggregatorWebAPI.Services.Interfaces;

public interface IUserService
{
    Task<GetUsersViewModelResponse> GetUsers();
    Task<DetailUserViewModelResponse> DetailUserById(string id);
    Task<CreateUserViewModelResponse> CreateUser(CreateUserViewModel user);
    Task<UpdateUserViewModelResponse> UpdateUserById(UpdateUserViewModel user);
    Task<DetailUserViewModelResponse> DeleteUserById(string id);
}
