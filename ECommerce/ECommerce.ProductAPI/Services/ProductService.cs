namespace ECommerce.ProductAPI.Services;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IUnitOfWork unitOfWork)
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
        IEnumerable<Product> products = _unitOfWork.ProductRepository.GetAll().Where(p => !p.Excluded && p.Active);

        var productsMapped = products.Select(p => p.MapToProductDTO());

        return productsMapped;
    }

    public ProductDTO CreateProduct(ProductDTO productToCreate)
    {
        productToCreate.Id = Guid.NewGuid();
        productToCreate.CreatedAt = DateTime.Now;
        productToCreate.UpdatedAt = DateTime.Now;
        productToCreate.Excluded = false;
        productToCreate.Active = true;

        Product mappedToProduct = productToCreate.MapToProduct();

        var productCreated = _unitOfWork.ProductRepository.Create(mappedToProduct);

        _unitOfWork.Commit();

        return productCreated.MapToProductDTO();
    }

    public ProductDTO UpdateProductById(string id, ProductDTO productToUpdate)
    {
        GetAndReturnProduct(id);

        productToUpdate.Id = Guid.Parse(id);
        productToUpdate.UpdatedAt = DateTime.Now;
        var mappedProduct = productToUpdate.MapToProduct();

        _unitOfWork.ProductRepository.Update(mappedProduct);

        _unitOfWork.Commit();

        return mappedProduct.MapToProductDTO();
    }

    public ProductDTO DeleteProductById(string id)
    {
        var foundProduct = GetAndReturnProduct(id);

        _unitOfWork.ProductRepository.Delete(foundProduct);

        _unitOfWork.Commit();

        return foundProduct.MapToProductDTO();
    }

    private Product? GetAndReturnProduct(string id)
    {
        var product = _unitOfWork.ProductRepository.Details(p => p.Id == Guid.Parse(id) && !p.Excluded && p.Active);
        if (product == null)
            throw new Exception($"Product with id {id} not found!");

        return product;
    }
}
