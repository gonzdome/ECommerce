namespace ECommerce.AuthAPI.Services;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;

    public UserService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<UserDTO> DetailUserById(string id)
    {
        var user = await GetAndReturnUser(id);

        return user.MapToUserDTO();
    }

    public async Task<IEnumerable<UserDTO>> GetUsers()
    {
        IEnumerable<User> users = (await _unitOfWork.UserRepository.GetAll()).Where(p => !p.Excluded && p.Active);

        var usersMapped = users.Select(p => p.MapToUserDTO());

        return usersMapped;
    }

    public async Task<UserDTO> CreateUser(UserDTO userToCreate)
    {
        User mappedToUser = userToCreate.MapToUser();

        mappedToUser.CreatedAt = DateTime.Now;
        mappedToUser.UpdatedAt = DateTime.Now;

        var userCreated = await _unitOfWork.UserRepository.Create(mappedToUser);

        await _unitOfWork.Commit();

        return userCreated.MapToUserDTO();
    }

    public async Task<UserDTO> UpdateUserById(UserDTO userToUpdate)
    {
        await GetAndReturnUser(userToUpdate.Id.ToString());

        userToUpdate.UpdatedAt = DateTime.Now;
        var mappedUser = userToUpdate.MapToUser();

        await _unitOfWork.UserRepository.Update(mappedUser);

        await _unitOfWork.Commit();

        return mappedUser.MapToUserDTO();
    }

    public async Task<UserDTO> DeleteUserById(string id)
    {
        var foundUser = await GetAndReturnUser(id);

        foundUser.Excluded = true;

        await _unitOfWork.UserRepository.Update(foundUser);

        await _unitOfWork.Commit();

        return foundUser.MapToUserDTO();
    }

    private async Task<User> GetAndReturnUser(string id)
    {
        var user = await _unitOfWork.UserRepository.Details(c => c.Id == Guid.Parse(id) && !c.Excluded && c.Active);
        if (user == null)
            throw new Exception($"User with id {id} not found!");

        return user;
    }
}
