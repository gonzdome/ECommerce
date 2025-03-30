using System.Text.Json;

namespace ECommerce.AggregatorWebAPI.Services;

public class ProductService : IProductService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private const string apiEndpoint = "/product/";
    private readonly JsonSerializerOptions _options;
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IHttpClientFactory httpClientFactory, IUnitOfWork unitOfWork)
    {
        _httpClientFactory = httpClientFactory;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        _unitOfWork = unitOfWork;
    }

    public async Task<GetProductsViewModelResponse> GetProducts()
    {
        var response = await _unitOfWork.ProductAPIProductsService.ProductAPIGetProducts();
        return response;
    }

    public async Task<DetailProductViewModelResponse> DetailProductById(string id)
    {
        var response = await _unitOfWork.ProductAPIProductsService.ProductAPIDetailProductById(id);
        return response;
    }

    public async Task<CreateProductViewModelResponse> CreateProduct(CreateProductViewModel product)
    {
        var response = await _unitOfWork.ProductAPIProductsService.ProductAPICreateProduct(product);
        return response;
    }

    public async Task<UpdateProductViewModelResponse> UpdateProductById(UpdateProductViewModel product)
    {
        var response = await _unitOfWork.ProductAPIProductsService.ProductAPIUpdateProductById(product);
        return response;
    }

    public async Task<DetailProductViewModelResponse> DeleteProductById(string id)
    {
        var response = await _unitOfWork.ProductAPIProductsService.ProductAPIDeleteProductById(id);
        return response;
    }
}
