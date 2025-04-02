namespace ECommerce.AggregatorWebAPI.Services;

public class UserCategoryService : IUserCategoryService
{
    private readonly IUnitOfWork _unitOfWork;

    public UserCategoryService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<GetUserCategoriesViewModelResponse> GetUserCategories()
    {
        var response = await _unitOfWork.AuthAPICategoriesService.AuthAPIGetCategories();
        return response;
    }

    public async Task<DetailUserCategoryViewModelResponse> DetailUserCategoryById(string id)
    {
        var response = await _unitOfWork.AuthAPICategoriesService.AuthAPIDetailCategoryById(id);
        return response;
    }

    public async Task<CreateUserCategoryViewModelResponse> CreateUserCategory(CreateUserCategoryViewModel product)
    {
        var response = await _unitOfWork.AuthAPICategoriesService.AuthAPICreateCategory(product);
        return response;
    }

    public async Task<UpdateUserCategoryViewModelResponse> UpdateUserCategoryById(UpdateUserCategoryViewModel product)
    {
        var response = await _unitOfWork.AuthAPICategoriesService.AuthAPIUpdateCategoryById(product);
        return response;
    }

    public async Task<DetailUserCategoryViewModelResponse> DeleteUserCategoryById(string id)
    {
        var response = await _unitOfWork.AuthAPICategoriesService.AuthAPIDeleteCategoryById(id);
        return response;
    }
}
