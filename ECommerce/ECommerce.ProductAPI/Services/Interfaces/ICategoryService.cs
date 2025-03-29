namespace ECommerce.ProductAPI.Services.Interfaces;

public interface ICategoryService
{
    public IEnumerable<CategoryDTO> GetCategories();
    public CategoryDTO DetailCategory(string id);
    public CategoryDTO CreateCategory(CategoryDTO purchase);
    public CategoryDTO UpdateCategoryById(string id, CategoryDTO purchase);
    public CategoryDTO DeleteCategoryById(string id);
}
