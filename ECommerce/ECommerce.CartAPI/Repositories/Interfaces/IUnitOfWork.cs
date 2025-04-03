namespace ECommerce.CartAPI.Repositories.Interfaces;

public interface IUnitOfWork
{
    ICartRepository CartRepository { get; }

    Task Commit();
}
