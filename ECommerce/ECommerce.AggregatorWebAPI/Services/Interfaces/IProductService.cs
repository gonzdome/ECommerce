namespace ECommerce.AggregatorWebAPI.Services.Interfaces;

public interface IProductService
{
    public Task<IEnumerable<GetProductsViewModel>> GetProducts();
    public Task<DetailProductViewModel> DetailProduct(string id);
    public Task<CreateProductViewModel> CreateProduct(CreateProductViewModel product);
    public Task<UpdateProductViewModel> UpdateProductById(string id, UpdateProductViewModel product);
    public Task<DetailProductViewModel> DeleteProductById(string id);
}
