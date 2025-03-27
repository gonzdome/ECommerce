namespace ECommerce.ProductAPI.Repositories.Interfaces;

public interface IUnitOfWork
{
    IProductRepository ProductRepository { get; }
    IPurchaseRepository PurchaseRepository { get; }

    void Commit();
}
