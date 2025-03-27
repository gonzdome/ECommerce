namespace ECommerce.ProductAPI.DTO.DTOMapping;

public static class PurchaseDTOMappingExtension
{
    public static PurchaseDTO MapToPurchaseDTO(this Purchase Purchase)
    {
        if (Purchase == null)
            return null;

        return new PurchaseDTO()
        {
            Id = Purchase.Id,
            CustomerId = Purchase.CustomerId,
            ProductId = Purchase.ProductId,
            CreatedAt = Purchase.CreatedAt,
            UpdatedAt = Purchase.UpdatedAt,
            Active = Purchase.Active,
            Excluded = Purchase.Excluded,
        };
    }

    public static Purchase MapToPurchase(this PurchaseDTO purchaseDTO)
    {
        if (purchaseDTO == null)
            return null;

        return new Purchase()
        {
            Id = purchaseDTO.Id,
            CustomerId = purchaseDTO.CustomerId,
            ProductId = purchaseDTO.ProductId,
            CreatedAt = purchaseDTO.CreatedAt,
            UpdatedAt = purchaseDTO.UpdatedAt,
            Active = purchaseDTO.Active,
            Excluded = purchaseDTO.Excluded,
        };
    }
}
