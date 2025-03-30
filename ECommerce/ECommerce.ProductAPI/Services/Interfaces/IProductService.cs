namespace ECommerce.ProductAPI.Services.Interfaces;

public interface IProductService
{
    public Task<IEnumerable<ProductDTO>> GetProducts();
    public Task<ProductDTO> DetailProductById(string id);
    public Task<ProductDTO> CreateProduct(ProductDTO product);
    public Task<ProductDTO> UpdateProductById(ProductDTO product);
    public Task<ProductDTO> DeleteProductById(string id);
}
