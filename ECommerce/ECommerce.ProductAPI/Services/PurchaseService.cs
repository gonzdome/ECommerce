namespace ECommerce.ProductAPI.Services;

public class PurchaseService : IPurchaseService
{
    private readonly IUnitOfWork _unitOfWork;

    public PurchaseService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<PurchaseDTO> DetailPurchase(string id)
    {
        var purchase = await GetAndReturnPurchase(id);

        return purchase.MapToPurchaseDTO();
    }

    public async Task<IEnumerable<PurchaseDTO>> GetPurchases()
    {
        IEnumerable<Purchase> purchases = (await _unitOfWork.PurchaseRepository.GetAll()).Where(p => !p.Excluded && p.Active); ;

        var purchasesMapped = purchases.Select(p => p.MapToPurchaseDTO());

        return purchasesMapped;
    }

    public async Task<PurchaseDTO> CreatePurchase(PurchaseDTO purchaseToCreate)
    {
        Purchase mappedToPurchase = purchaseToCreate.MapToPurchase();

        var purchaseCreated = await _unitOfWork.PurchaseRepository.Create(mappedToPurchase);

        await _unitOfWork.Commit();

        return purchaseCreated.MapToPurchaseDTO();
    }

    public async Task<PurchaseDTO> DeletePurchaseById(string id)
    {
        var foundPurchase = await GetAndReturnPurchase(id);

        await _unitOfWork.PurchaseRepository.Delete(foundPurchase);

        await _unitOfWork.Commit();

        return foundPurchase.MapToPurchaseDTO();
    }

    public async Task<PurchaseDTO> UpdatePurchaseById(string id, PurchaseDTO purchase)
    {
        var foundPurchase = await GetAndReturnPurchase(id);

        await _unitOfWork.PurchaseRepository.Update(foundPurchase);

        await _unitOfWork.Commit();

        return foundPurchase.MapToPurchaseDTO();
    }

    private async Task<Purchase> GetAndReturnPurchase(string id)
    {
        var purchase = await _unitOfWork.PurchaseRepository.Details(p => p.Id == Guid.Parse(id) && !p.Excluded && p.Active);
        if (purchase == null)
            throw new Exception($"Purchase with id {id} not found!");

        return purchase;
    }
}
