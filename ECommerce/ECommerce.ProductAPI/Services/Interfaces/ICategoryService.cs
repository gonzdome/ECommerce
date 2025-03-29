namespace ECommerce.ProductAPI.Services.Interfaces;

public interface ICategoryService
{
    public Task<IEnumerable<CategoryDTO>> GetCategories();
    public Task<CategoryDTO> DetailCategoryById(string id);
    public Task<CategoryDTO> CreateCategory(CategoryDTO purchase);
    public Task<CategoryDTO> UpdateCategoryById(string id, CategoryDTO purchase);
    public Task<CategoryDTO> DeleteCategoryById(string id);
}
