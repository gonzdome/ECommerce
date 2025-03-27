

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
        Product product = productToCreate.MapToProduct();

        var productCreated = _unitOfWork.ProductRepository.Create(productToCreate);

        _unitOfWork.Commit();

        return productCreated.MapToProductDTO();
    }

    public ProductDTO DeleteProduct(string id)
    {

        var product = _unitOfWork.ProductRepository.DeleteProduct();
    }

    public ProductDTO UpdateProduct(string id, ProductDTO product)
    {
        var product = _unitOfWork.ProductRepository.UpdateProduct();
    }

    private Product? GetAndReturnProduct(string id)
    {
        var product = _unitOfWork.ProductRepository.Get(p => p.ProdutoId == id);
        if (product == null)
            throw new Exception($"Product with id {id} not found!");

        return product;
    }
}
