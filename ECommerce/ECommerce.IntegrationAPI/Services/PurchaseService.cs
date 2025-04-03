using static PurchaseAPIPostRequest;

namespace ECommerce.IntegrationAPI.Services;

public class PurchaseService : IPurchaseService
{
    private readonly IGatewayUnitOfWork _gatewayUnitOfWork;

    public PurchaseService(IGatewayUnitOfWork gatewayUnitOfWork)
    {
        _gatewayUnitOfWork = gatewayUnitOfWork;
    }

    public async Task<PurchaseAPIPostResponse> Purchase(SendPurchaseRequest request, string ApiName, string ApiUri)
    {
        var mapRequest = MapPayload(request);
        var purchaseResponse = await _gatewayUnitOfWork.PurchaseAPIService.PurchaseAPISend(mapRequest, ApiName, ApiUri);
        return purchaseResponse;
    }

    private PurchaseAPIPostRequest MapPayload(SendPurchaseRequest request)
    {
        var subTotal = request.itens.Sum(i => i.precoUnitario * i.quantidade).Value;
        var discount = GetDiscount(request.cliente.categoria, subTotal);

        PurchaseAPIPostRequest apiRequest = new PurchaseAPIPostRequest();
        apiRequest.identificador = request.identificador != null ? request.identificador : Guid.NewGuid().ToString();
        apiRequest.subTotal = subTotal;
        apiRequest.valorTotal = (subTotal - (subTotal * discount));
        apiRequest.descontos = discount;

        apiRequest.itens = request.itens.Select(i => new PurchaseItems()
        {
            precoUnitario = i.precoUnitario.Value,
            quantidade = i.quantidade,
        }).ToList();

        return apiRequest;
    }

    private static decimal GetDiscount(string category, decimal subTotal)
    {
        decimal discount = 0m;

        if (category == "REGULAR" && subTotal > 500)
            discount = 0.05m;
        else if (category == "PREMIUM" && subTotal > 300)
            discount = 0.10m;
        else if (category == "VIP")
            discount = 0.15m;

        return discount;
    }
}
