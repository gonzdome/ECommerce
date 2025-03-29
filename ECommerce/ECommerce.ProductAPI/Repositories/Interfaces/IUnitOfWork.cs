namespace ECommerce.ProductAPI.Repositories.Interfaces;

public interface IUnitOfWork
{
    IProductRepository ProductRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    IPurchaseRepository PurchaseRepository { get; }

    Task Commit();
}
