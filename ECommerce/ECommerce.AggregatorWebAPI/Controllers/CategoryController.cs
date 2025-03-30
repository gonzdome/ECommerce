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
    public async Task<ActionResult<IEnumerable<GetCategoriesViewModelResponse>>> GetCategories()
    {
        try
        {
            var category = await _categoryService.GetCategories();
            return Ok(category);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpGet("GetCategoryDetailsById")]
    public async Task<ActionResult<DetailCategoryViewModelResponse>> GetCategoryDetailsById([FromQuery] string id)
    {
        try
        {
            var category = await _categoryService.DetailCategoryById(id);
            return Ok(category);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPost]
    [Route("CreateCategory")]
    public async Task<ActionResult<CreateCategoryViewModelResponse>> CreateCategory([FromBody] CreateCategoryViewModel categoryPayload)
    {
        try
        {
            var category = await _categoryService.CreateCategory(categoryPayload);
            return Ok(category);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPut("UpdateCategoryById")]
    public async Task<ActionResult<UpdateCategoryViewModelResponse>> UpdateCategoryById([FromBody] UpdateCategoryViewModel categoryToUpdate)
    {
        try
        {
            var category = await _categoryService.UpdateCategoryById(categoryToUpdate);
            return Ok(category);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpDelete("DeleteCategoryById")]
    public async Task<ActionResult<DetailCategoryViewModelResponse>> DeleteCategoryById([FromQuery] string id)
    {
        try
        {
            var category = await _categoryService.DeleteCategoryById(id);
            return Ok(category);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

}
