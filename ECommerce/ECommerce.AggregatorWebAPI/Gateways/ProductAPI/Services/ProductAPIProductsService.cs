namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Services;

public class ProductAPIProductsService : ProductAPIProductsGateway, IProductAPIProductsService
{
    public ProductAPIProductsService(APIClient apiClient) : base(apiClient)
    {
    }

    public async Task<DetailProductViewModelResponse> ProductAPIDetailProductById(string id)
    {
        var productDetails = await DetailProductById(id);
        return productDetails;
    }

    public async Task<GetProductsViewModelResponse> ProductAPIGetProducts()
    {
        var productsListed = await GetProducts();
        return productsListed;
    }

    public async Task<CreateProductViewModelResponse> ProductAPICreateProduct(CreateProductViewModel product)
    {
        var createdProduct = await CreateProduct(product);
        return createdProduct;
    }

    public async Task<UpdateProductViewModelResponse> ProductAPIUpdateProductById(UpdateProductViewModel product)
    {
        var updatedProduct = await UpdateProductById(product);
        return updatedProduct;
    }

    public async Task<DetailProductViewModelResponse> ProductAPIDeleteProductById(string id)
    {
        var deletedProduct = await DeleteProductById(id);
        return deletedProduct;
    }
}
