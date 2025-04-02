namespace ECommerce.AggregatorWebAPI.Services;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<GetCategoriesViewModelResponse> GetCategories()
    {
        var response = await _unitOfWork.ProductAPICategoriesService.ProductAPIGetCategories();
        return response;
    }

    public async Task<DetailCategoryViewModelResponse> DetailCategoryById(string id)
    {
        var response = await _unitOfWork.ProductAPICategoriesService.ProductAPIDetailCategoryById(id);
        return response;
    }

    public async Task<CreateCategoryViewModelResponse> CreateCategory(CreateCategoryViewModel product)
    {
        var response = await _unitOfWork.ProductAPICategoriesService.ProductAPICreateCategory(product);
        return response;
    }

    public async Task<UpdateCategoryViewModelResponse> UpdateCategoryById(UpdateCategoryViewModel product)
    {
        var response = await _unitOfWork.ProductAPICategoriesService.ProductAPIUpdateCategoryById(product);
        return response;
    }

    public async Task<DetailCategoryViewModelResponse> DeleteCategoryById(string id)
    {
        var response = await _unitOfWork.ProductAPICategoriesService.ProductAPIDeleteCategoryById(id);
        return response;
    }
}
