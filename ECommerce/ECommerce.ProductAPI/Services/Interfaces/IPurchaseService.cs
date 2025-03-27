namespace ECommerce.ProductAPI.Services.Interfaces;

public interface IPurchaseService
{
    public IEnumerable<PurchaseDTO> GetPurchases();
    public PurchaseDTO DetailPurchase(string id);
    public PurchaseDTO CreatePurchase(PurchaseDTO purchase);
    public PurchaseDTO UpdatePurchase(string id, PurchaseDTO purchase);
    public PurchaseDTO DeletePurchase(string id);
}
