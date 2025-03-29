namespace ECommerce.AggregatorWebAPI.Services.Interfaces;

public interface ICategoryService
{
    public Task<IEnumerable<GetCategoriesViewModel>> GetCategories();
    public Task<DetailCategoryViewModel> DetailCategoryById(string id);
    public Task<CreateCategoryViewModel> CreateCategory(CreateCategoryViewModel product);
    public Task<UpdateCategoryViewModel> UpdateCategoryById(string id, UpdateCategoryViewModel product);
    public Task<DetailCategoryViewModel> DeleteCategoryById(string id);
}
