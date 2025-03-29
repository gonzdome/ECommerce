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
        IEnumerable<Category> categories = _unitOfWork.CategoryRepository.GetAll();

        var categoriesMapped = categories.Select(p => p.MapToCategoryDTO());

        return categoriesMapped;
    }

    public CategoryDTO CreateCategory(CategoryDTO categoryToCreate)
    {
        Category mappedToCategory = categoryToCreate.MapToCategory();

        var categoryCreated = _unitOfWork.CategoryRepository.Create(mappedToCategory);

        _unitOfWork.Commit();

        return categoryCreated.MapToCategoryDTO();
    }

    public CategoryDTO DeleteCategoryById(string id)
    {
        var foundCategory = GetAndReturnCategory(id);

        _unitOfWork.CategoryRepository.Delete(foundCategory);

        _unitOfWork.Commit();

        return foundCategory.MapToCategoryDTO();
    }

    public CategoryDTO UpdateCategoryById(string id, CategoryDTO category)
    {
        var foundCategory = GetAndReturnCategory(id);

        _unitOfWork.CategoryRepository.Update(foundCategory);

        _unitOfWork.Commit();

        return foundCategory.MapToCategoryDTO();
    }

    private Category? GetAndReturnCategory(string id)
    {
        var category = _unitOfWork.CategoryRepository.Details(p => p.Id == Guid.Parse(id));
        if (category == null)
            throw new Exception($"Category with id {id} not found!");

        return category;
    }
}
