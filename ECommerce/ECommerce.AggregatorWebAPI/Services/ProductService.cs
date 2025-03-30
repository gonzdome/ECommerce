using System.Text.Json;

namespace ECommerce.AggregatorWebAPI.Services;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IHttpClientFactory httpClientFactory, IUnitOfWork unitOfWork)
    {
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
