namespace ECommerce.AggregatorWebAPI.Services.Interfaces;

public interface ICategoryService
{
    Task<GetCategoriesViewModelResponse> GetCategories();
    Task<DetailCategoryViewModelResponse> DetailCategoryById(string id);
    Task<CreateCategoryViewModelResponse> CreateCategory(CreateCategoryViewModel product);
    Task<UpdateCategoryViewModelResponse> UpdateCategoryById(UpdateCategoryViewModel product);
    Task<DetailCategoryViewModelResponse> DeleteCategoryById(string id);
}
