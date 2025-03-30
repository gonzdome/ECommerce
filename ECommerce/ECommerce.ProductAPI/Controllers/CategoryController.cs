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
    public async Task<ActionResult<CategoryDTO>> GetCategoryDetailsById([FromQuery] string id)
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
    public async Task<ActionResult<CategoryDTO>> CreateCategory(CategoryDTO categoryPayload)
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
    public async Task<ActionResult<CategoryDTO>> UpdateCategoryById(CategoryDTO categoryToUpdate)
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
    public async Task<ActionResult<CategoryDTO>> DeleteCategoryById([FromQuery] string id)
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
