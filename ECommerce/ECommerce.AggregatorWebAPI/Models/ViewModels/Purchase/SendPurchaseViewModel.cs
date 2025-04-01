namespace ECommerce.AggregatorWebAPI.Models.ViewModels.Purchase;

public class SendPurchaseViewModel
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
