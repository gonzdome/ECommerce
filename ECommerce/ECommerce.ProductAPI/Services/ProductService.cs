namespace ECommerce.ProductAPI.Services;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public ProductDTO DetailProduct(string id)
    {
        var product = GetAndReturnProduct(id);

        return product.MapToProductDTO();
    }

    public IEnumerable<ProductDTO> GetProducts()
    {
        IEnumerable<Product> products = _unitOfWork.ProductRepository.GetAll();

        var productsMapped = products.Select(p => p.MapToProductDTO());

        return productsMapped;
    }

    public ProductDTO CreateProduct(ProductDTO productToCreate)
    {
        Product mappedToProduct = productToCreate.MapToProduct();

        var productCreated = _unitOfWork.ProductRepository.Create(mappedToProduct);

        _unitOfWork.Commit();

        return productCreated.MapToProductDTO();
    }

    public ProductDTO DeleteProductById(string id)
    {
        var foundProduct = GetAndReturnProduct(id);

        _unitOfWork.ProductRepository.Delete(foundProduct);

        _unitOfWork.Commit();

        return foundProduct.MapToProductDTO();
    }

    public ProductDTO UpdateProductById(string id, ProductDTO product)
    {
        var foundProduct = GetAndReturnProduct(id);

        _unitOfWork.ProductRepository.Update(foundProduct);

        _unitOfWork.Commit();

        return foundProduct.MapToProductDTO();
    }

    private Product? GetAndReturnProduct(string id)
    {
        var product = _unitOfWork.ProductRepository.Details(p => p.Id == Guid.Parse(id));
        if (product == null)
            throw new Exception($"Product with id {id} not found!");

        return product;
    }
}
