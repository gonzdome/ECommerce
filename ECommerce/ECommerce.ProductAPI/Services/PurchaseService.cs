
namespace ECommerce.ProductAPI.Services;

public class PurchaseService : IPurchaseService
{
    private readonly IUnitOfWork _unitOfWork;
    PurchaseService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public PurchaseDTO DetailPurchase(string id)
    {
        var purchase = GetAndReturnPurchase(id);

        return purchase.MapToPurchaseDTO();
    }

    public IEnumerable<PurchaseDTO> GetPurchases()
    {
        IEnumerable<Purchase> purchases = _unitOfWork.PurchaseRepository.GetAll();

        var purchasesMapped = purchases.Select(p => p.MapToPurchaseDTO());

        return purchasesMapped;
    }

    public PurchaseDTO CreatePurchase(PurchaseDTO purchaseToCreate)
    {
        Purchase mappedToPurchase = purchaseToCreate.MapToPurchase();

        var purchaseCreated = _unitOfWork.PurchaseRepository.Create(mappedToPurchase);

        _unitOfWork.Commit();

        return purchaseCreated.MapToPurchaseDTO();
    }

    public PurchaseDTO DeletePurchaseById(string id)
    {
        var foundPurchase = GetAndReturnPurchase(id);

        _unitOfWork.PurchaseRepository.Delete(foundPurchase);

        _unitOfWork.Commit();

        return foundPurchase.MapToPurchaseDTO();
    }

    public PurchaseDTO UpdatePurchaseById(string id, PurchaseDTO purchase)
    {
        var foundPurchase = GetAndReturnPurchase(id);

        _unitOfWork.PurchaseRepository.Update(foundPurchase);

        _unitOfWork.Commit();

        return foundPurchase.MapToPurchaseDTO();
    }

    private Purchase? GetAndReturnPurchase(string id)
    {
        var purchase = _unitOfWork.PurchaseRepository.Details(p => p.Id == Guid.Parse(id));
        if (purchase == null)
            throw new Exception($"Purchase with id {id} not found!");

        return purchase;
    }
}
