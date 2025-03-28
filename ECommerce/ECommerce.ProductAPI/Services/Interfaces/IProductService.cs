namespace ECommerce.ProductAPI.Services.Interfaces;

public interface IProductService
{
    public IEnumerable<ProductDTO> GetProducts();
    public ProductDTO DetailProduct(string id);
    public ProductDTO CreateProduct(ProductDTO product);
    public ProductDTO UpdateProductById(string id, ProductDTO product);
    public ProductDTO DeleteProductById(string id);
}
