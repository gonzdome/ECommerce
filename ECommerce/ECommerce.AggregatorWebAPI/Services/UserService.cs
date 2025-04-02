namespace ECommerce.AggregatorWebAPI.Services;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;

    public UserService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<GetUsersViewModelResponse> GetUsers()
    {
        var response = await _unitOfWork.AuthAPIUsersService.AuthAPIGetUsers();
        return response;
    }

    public async Task<DetailUserViewModelResponse> DetailUserById(string id)
    {
        var response = await _unitOfWork.AuthAPIUsersService.AuthAPIDetailUserById(id);
        return response;
    }

    public async Task<CreateUserViewModelResponse> CreateUser(CreateUserViewModel product)
    {
        var response = await _unitOfWork.AuthAPIUsersService.AuthAPICreateUser(product);
        return response;
    }

    public async Task<UpdateUserViewModelResponse> UpdateUserById(UpdateUserViewModel product)
    {
        var response = await _unitOfWork.AuthAPIUsersService.AuthAPIUpdateUserById(product);
        return response;
    }

    public async Task<DetailUserViewModelResponse> DeleteUserById(string id)
    {
        var response = await _unitOfWork.AuthAPIUsersService.AuthAPIDeleteUserById(id);
        return response;
    }
}
