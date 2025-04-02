public class PurchaseAPIPostRequest
{
    public string identificador { get; set; }
    public double subTotal { get; set; }
    public double descontos { get; set; }
    public double valorTotal { get; set; }
    public List<PurchaseItems> itens { get; set; }
    public class PurchaseItems
    {
        public double quantidade { get; set; }
        public double precoUnitario { get; set; }
    }
}
