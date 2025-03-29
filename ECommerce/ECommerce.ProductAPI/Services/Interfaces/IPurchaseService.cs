namespace ECommerce.ProductAPI.Services.Interfaces;

public interface IPurchaseService
{
    public Task<IEnumerable<PurchaseDTO>> GetPurchases();
    public Task<PurchaseDTO> DetailPurchase(string id);
    public Task<PurchaseDTO> CreatePurchase(PurchaseDTO purchase);
    public Task<PurchaseDTO> UpdatePurchaseById(string id, PurchaseDTO purchase);
    public Task<PurchaseDTO> DeletePurchaseById(string id);
}
