namespace ECommerce.ProductAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("GetCategories")]
    public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategories()
    {
        var category = _categoryService.GetCategories();
        return Ok(category);
    }

    [HttpGet("{id}", Name = "CategoryDetailsById")]
    public async Task<ActionResult<CategoryDTO>> CategoryDetailsById(string id)
    {
        var category = _categoryService.DetailCategoryById(id);
        return Ok(category);
    }

    [HttpPost]
    [Route("CreateCategory")]
    public async Task<ActionResult<CategoryDTO>> CreateCategory(CategoryDTO categoryPayload)
    {
        var category = _categoryService.CreateCategory(categoryPayload);
        return Ok(category);
    }

    [HttpPut("{id}", Name = "UpdateCategoryById")]
    public async Task<ActionResult<CategoryDTO>> UpdateCategoryById(string id, CategoryDTO categoryToUpdate)
    {
        var category = _categoryService.UpdateCategoryById(id, categoryToUpdate);
        return Ok(category);
    }

    [HttpDelete("{id}", Name = "DeleteCategoryById")]
    public async Task<ActionResult<CategoryDTO>> DeleteCategoryById(string id)
    {
        var category = _categoryService.DeleteCategoryById(id);
        return Ok(category);
    }

}
