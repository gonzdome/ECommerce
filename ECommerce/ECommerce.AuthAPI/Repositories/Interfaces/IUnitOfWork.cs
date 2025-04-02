namespace ECommerce.AuthAPI.Repositories.Interfaces;

public interface IUnitOfWork
{
    IUserRepository UserRepository { get; }
    ICategoryRepository CategoryRepository { get; }

    Task Commit();
}
