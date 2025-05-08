using ECommerce.ProductAPI.Models.Entities;

namespace ECommerce.CartAPI.Models.Entities;

public class Cliente : CommonModelData
{
        public Guid clienteId { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string categoria { get; set; }
}
