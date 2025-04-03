namespace ECommerce.IntegrationAPI.Models.ViewModels;

public class SendPurchaseRequest
{
    public string? identificador { get; set; } = string.Empty;
    public string? dataVenda { get; set; } = string.Empty;
    public Customer cliente { get; set; }
    public List<ProductItems> itens { get; set; }

    public class Customer
    {
        public string clienteId { get; set; }
        public string? nome { get; set; }
        public string? cpf { get; set; }
        public string? categoria { get; set; }
    }

    public class ProductItems
    {
        //public int produtoId { get; set; }
        public string produtoId { get; set; }
        public string? descricao { get; set; }

        [Precision(18, 1)]
        public decimal quantidade { get; set; } = 1;

        [Precision(18, 2)]
        public decimal? precoUnitario { get; set; }
    }
}
