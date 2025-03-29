namespace ECommerce.AggregatorWebAPI.Controllers;

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
    public async Task<ActionResult<IEnumerable<GetCategoriesViewModel>>> GetCategories()
    {
        var category = await _categoryService.GetCategories();
        return Ok(category);
    }

    [HttpGet("{id}", Name = "CategoryDetailsById")]
    public async Task<ActionResult<DetailCategoryViewModel>> CategoryDetailsById(string id)
    {
        var category = await _categoryService.DetailCategoryById(id);
        return Ok(category);
    }

    [HttpPost]
    [Route("CreateCategory")]
    public async Task<ActionResult<CreateCategoryViewModel>> CreateCategory(CreateCategoryViewModel categoryPayload)
    {
        var category = await _categoryService.CreateCategory(categoryPayload);
        return Ok(category);
    }

    [HttpPut("{id}", Name = "UpdateCategoryById")]
    public async Task<ActionResult<UpdateCategoryViewModel>> UpdateCategoryById(string id, UpdateCategoryViewModel categoryToUpdate)
    {
        var category = await _categoryService.UpdateCategoryById(id, categoryToUpdate);
        return Ok(category);
    }

    [HttpDelete("{id}", Name = "DeleteCategoryById")]
    public async Task<ActionResult<DetailCategoryViewModel>> DeleteCategoryById(string id)
    {
        var category = await _categoryService.DeleteCategoryById(id);
        return Ok(category);
    }

}
