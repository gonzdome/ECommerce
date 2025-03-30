using ECommerce.ProductAPI.Models.Entities;

namespace ECommerce.ProductAPI.Services;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<CategoryDTO> DetailCategoryById(string id)
    {
        var category = await GetAndReturnCategory(id);

        return category.MapToCategoryDTO();
    }

    public async Task<IEnumerable<CategoryDTO>> GetCategories()
    {
        IEnumerable<Category> categories = (await _unitOfWork.CategoryRepository.GetAll()).Where(p => !p.Excluded && p.Active);

        var categoriesMapped = categories.Select(p => p.MapToCategoryDTO());

        return categoriesMapped;
    }

    public async Task<CategoryDTO> CreateCategory(CategoryDTO categoryToCreate)
    {
        categoryToCreate.Id = Guid.NewGuid();
        categoryToCreate.CreatedAt = DateTime.Now;
        categoryToCreate.UpdatedAt = DateTime.Now;
        categoryToCreate.Excluded = false;
        categoryToCreate.Active = true;

        Category mappedToCategory = categoryToCreate.MapToCategory();

        var categoryCreated = await _unitOfWork.CategoryRepository.Create(mappedToCategory);

        await _unitOfWork.Commit();

        return categoryCreated.MapToCategoryDTO();
    }

    public async Task<CategoryDTO> UpdateCategoryById(CategoryDTO categoryToUpdate)
    {
        await GetAndReturnCategory(categoryToUpdate.Id.ToString());

        categoryToUpdate.UpdatedAt = DateTime.Now;
        var mappedCategory = categoryToUpdate.MapToCategory();

        await _unitOfWork.CategoryRepository.Update(mappedCategory);

        await _unitOfWork.Commit();

        return mappedCategory.MapToCategoryDTO();
    }


    public async Task<CategoryDTO> DeleteCategoryById(string id)
    {
        var foundCategory = await GetAndReturnCategory(id);

        foundCategory.Excluded = true;

        await _unitOfWork.CategoryRepository.Update(foundCategory);

        await _unitOfWork.Commit();

        return foundCategory.MapToCategoryDTO();
    }

    private async Task<Category> GetAndReturnCategory(string id)
    {
        var category = await _unitOfWork.CategoryRepository.Details(c => c.Id == Guid.Parse(id) && !c.Excluded && c.Active);
        if (category == null)
            throw new Exception($"Category with id {id} not found!");

        return category;
    }
}
