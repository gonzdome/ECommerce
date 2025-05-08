namespace ECommerce.AuthAPI.Services.Interfaces;

public interface ICategoryService
{
    public Task<IEnumerable<CategoryDTO>> GetCategories();
    public Task<CategoryDTO> DetailCategoryById(string id);
    public Task<CategoryDTO> CreateCategory(CategoryDTO purchase);
    public Task<CategoryDTO> UpdateCategoryById(CategoryDTO purchase);
    public Task<CategoryDTO> DeleteCategoryById(string id);
}
