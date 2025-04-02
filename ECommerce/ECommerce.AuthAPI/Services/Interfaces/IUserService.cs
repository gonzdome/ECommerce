namespace ECommerce.AuthAPI.Services.Interfaces;

public interface IUserService
{
    public Task<IEnumerable<UserDTO>> GetUsers();
    public Task<UserDTO> DetailUserById(string id);
    public Task<UserDTO> CreateUser(UserDTO purchase);
    public Task<UserDTO> UpdateUserById(UserDTO purchase);
    public Task<UserDTO> DeleteUserById(string id);
}
