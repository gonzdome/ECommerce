namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Services.Interfaces;

public interface IProductAPIProductsService
{
    public Task<GetProductsViewModelResponse> ProductAPIGetProducts();
    public Task<DetailProductViewModelResponse> ProductAPIDetailProductById(string id);
    public Task<CreateProductViewModelResponse> ProductAPICreateProduct(CreateProductViewModel product);
    public Task<UpdateProductViewModelResponse> ProductAPIUpdateProductById(UpdateProductViewModel product);
    public Task<DetailProductViewModelResponse> ProductAPIDeleteProductById(string id);
}
