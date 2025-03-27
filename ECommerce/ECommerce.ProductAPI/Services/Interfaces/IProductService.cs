namespace ECommerce.ProductAPI.Services.Interfaces;

public interface IProductService
{
    public IEnumerable<ProductDTO> GetProducts();
    public ProductDTO DetailProduct(string id);
    public ProductDTO CreateProduct(ProductDTO product);
    public ProductDTO UpdateProduct(string id, ProductDTO product);
    public ProductDTO DeleteProduct(string id);
}
