using ECommerce.ProductAPI.Models.Entities;

namespace ECommerce.ProductAPI.Services;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public CategoryDTO DetailCategory(string id)
    {
        var category = GetAndReturnCategory(id);

        return category.MapToCategoryDTO();
    }

    public IEnumerable<CategoryDTO> GetCategories()
    {
        IEnumerable<Category> categories = _unitOfWork.CategoryRepository.GetAll().Where(c => !c.Excluded && c.Active);

        var categoriesMapped = categories.Select(p => p.MapToCategoryDTO());

        return categoriesMapped;
    }

    public CategoryDTO CreateCategory(CategoryDTO categoryToCreate)
    {
        categoryToCreate.Id = Guid.NewGuid();
        categoryToCreate.CreatedAt = DateTime.Now;
        categoryToCreate.UpdatedAt = DateTime.Now;
        categoryToCreate.Excluded = false;
        categoryToCreate.Active = true;

        Category mappedToCategory = categoryToCreate.MapToCategory();

        var categoryCreated = _unitOfWork.CategoryRepository.Create(mappedToCategory);

        _unitOfWork.Commit();

        return categoryCreated.MapToCategoryDTO();
    }

    public CategoryDTO UpdateCategoryById(string id, CategoryDTO categoryToUpdate)
    {
        GetAndReturnCategory(id);

        categoryToUpdate.Id = Guid.Parse(id);
        categoryToUpdate.UpdatedAt = DateTime.Now;
        var mappedCategory = categoryToUpdate.MapToCategory();

        _unitOfWork.CategoryRepository.Update(mappedCategory);

        _unitOfWork.Commit();

        return mappedCategory.MapToCategoryDTO();
    }


    public CategoryDTO DeleteCategoryById(string id)
    {
        var foundCategory = GetAndReturnCategory(id);

        _unitOfWork.CategoryRepository.Delete(foundCategory);

        _unitOfWork.Commit();

        return foundCategory.MapToCategoryDTO();
    }

    private Category? GetAndReturnCategory(string id)
    {
        var category = _unitOfWork.CategoryRepository.Details(c => c.Id == Guid.Parse(id) && !c.Excluded && c.Active);
        if (category == null)
            throw new Exception($"Category with id {id} not found!");

        return category;
    }
}
