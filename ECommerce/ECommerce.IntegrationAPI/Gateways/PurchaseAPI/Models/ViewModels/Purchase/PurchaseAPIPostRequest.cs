public class PurchaseAPIPostRequest
{
    public string identificador { get; set; }

    [Precision(18, 2)]
    public decimal subTotal { get; set; }

    [Precision(18, 2)]
    public decimal descontos { get; set; }


    public decimal valorTotal { get; set; }
    public List<PurchaseItems> itens { get; set; }
    public class PurchaseItems
    {
        [Precision(18, 1)]
        public decimal quantidade { get; set; }

        [Precision(18, 2)]
        public decimal precoUnitario { get; set; }
    }
}
