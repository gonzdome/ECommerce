namespace ECommerce.IntegrationAPI.Gateways.PurchaseAPI.Models.ViewModels.Purchase;

public class PurchaseAPIPostRequest
{
    public string ApiUri { get; set; } = string.Empty;
    public string identificador { get; set; }
    public string dataVenda { get; set; }
    public Customer cliente { get; set; }
    public List<ProductItems> itens { get; set; }

    public class Customer
    {
        public string clienteId { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string categoria { get; set; }
    }

    public class ProductItems
    {
        //public int produtoId { get; set; }
        public string produtoId { get; set; }
        public string descricao { get; set; }
        public double quantidade { get; set; }
        public double precoUnitario { get; set; }
    }
}
