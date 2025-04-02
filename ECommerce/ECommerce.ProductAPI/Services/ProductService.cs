namespace ECommerce.ProductAPI.Services;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<ProductDTO> DetailProductById(string id)
    {
        var product = await GetAndReturnProduct(id);

        return product.MapToProductDTO();
    }

    public async Task<IEnumerable<ProductDTO>> GetProducts()
    {
        IEnumerable<Product> products = (await _unitOfWork.ProductRepository.GetAll()).Where(p => !p.Excluded && p.Active);

        var productsMapped = products.Select(p => p.MapToProductDTO());

        return productsMapped;
    }

    public async Task<ProductDTO> CreateProduct(ProductDTO productToCreate)
    {
        Product mappedToProduct = productToCreate.MapToProduct();

        mappedToProduct.CreatedAt = DateTime.Now;
        mappedToProduct.UpdatedAt = DateTime.Now;

        var productCreated = await _unitOfWork.ProductRepository.Create(mappedToProduct);
        await _unitOfWork.Commit();

        return productCreated.MapToProductDTO();
    }

    public async Task<ProductDTO> UpdateProductById(ProductDTO productToUpdate)
    {
        await GetAndReturnProduct(productToUpdate.Id.ToString());

        productToUpdate.UpdatedAt = DateTime.Now;

        var mappedProduct = productToUpdate.MapToProduct();

        await _unitOfWork.ProductRepository.Update(mappedProduct);
        await _unitOfWork.Commit();

        return mappedProduct.MapToProductDTO();
    }

    public async Task<ProductDTO> DeleteProductById(string id)
    {
        var foundProduct = await GetAndReturnProduct(id);
        
        foundProduct.Excluded = true;

        await _unitOfWork.ProductRepository.Update(foundProduct);
        await _unitOfWork.Commit();

        return foundProduct.MapToProductDTO();
    }

    private async Task<Product> GetAndReturnProduct(string id)
    {
        var product = await _unitOfWork.ProductRepository.Details(p => p.Id == Guid.Parse(id) && !p.Excluded && p.Active);
        if (product == null)
            throw new Exception($"Product with id {id} not found!");

        return product;
    }
}
