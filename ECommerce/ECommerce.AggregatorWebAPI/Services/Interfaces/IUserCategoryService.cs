namespace ECommerce.AggregatorWebAPI.Services.Interfaces;

public interface IUserCategoryService
{
    Task<GetUserCategoriesViewModelResponse> GetUserCategories();
    Task<DetailUserCategoryViewModelResponse> DetailUserCategoryById(string id);
    Task<CreateUserCategoryViewModelResponse> CreateUserCategory(CreateUserCategoryViewModel userCategory);
    Task<UpdateUserCategoryViewModelResponse> UpdateUserCategoryById(UpdateUserCategoryViewModel userCategory);
    Task<DetailUserCategoryViewModelResponse> DeleteUserCategoryById(string id);
}
