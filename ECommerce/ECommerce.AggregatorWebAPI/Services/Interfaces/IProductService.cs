namespace ECommerce.AggregatorWebAPI.Services.Interfaces;

public interface IProductService
{
    Task<GetProductsViewModelResponse> GetProducts();
    Task<DetailProductViewModelResponse> DetailProductById(string id);
    Task<CreateProductViewModelResponse> CreateProduct(CreateProductViewModel product);
    Task<UpdateProductViewModelResponse> UpdateProductById(UpdateProductViewModel product);
    Task<DetailProductViewModelResponse> DeleteProductById(string id);
}
