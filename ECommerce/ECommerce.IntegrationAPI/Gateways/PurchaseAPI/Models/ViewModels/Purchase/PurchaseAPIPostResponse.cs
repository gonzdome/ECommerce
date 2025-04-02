namespace ECommerce.IntegrationAPI.Gateways.PurchaseAPI.Models.ViewModels.Purchase;

public class PurchaseAPIPostResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Code { get; set; }

    public PurchaseResponse? Data { get; set; }

    public class PurchaseResponse
    {
        public string identificador { get; set; }
        public double subTotal { get; set; }
        public double descontos { get; set; }
        public double valorTotal { get; set; }
        public List<Items> itens { get; set; }

        public class Items
        {
            public double quantidade { get; set; }
            public double precoUnitario { get; set; }
        }
    }
}
