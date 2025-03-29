using System.Text.Json;

namespace ECommerce.AggregatorWebAPI.Services;

public class ProductService : IProductService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private const string apiEndpoint = "/product/";
    private readonly JsonSerializerOptions _options;

    public ProductService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task<CreateProductViewModel> CreateProduct(CreateProductViewModel productToCreate)
    {


        return new CreateProductViewModel() { };
    }

    public async Task<IEnumerable<GetProductsViewModel>> GetProducts()
    {
        throw new NotImplementedException();
    }

    public async Task<DetailProductViewModel> DetailProduct(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<UpdateProductViewModel> UpdateProductById(string id, UpdateProductViewModel product)
    {
        throw new NotImplementedException();
    }

    public async Task<DetailProductViewModel> DeleteProductById(string id)
    {
        throw new NotImplementedException();
    }
}
