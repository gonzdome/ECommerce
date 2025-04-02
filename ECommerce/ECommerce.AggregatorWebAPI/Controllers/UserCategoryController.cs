namespace ECommerce.AggregatorWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserCategoryController : ControllerBase
{
    private readonly IUserCategoryService _categoryService;

    public UserCategoryController(IUserCategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("GetCategories")]
    public async Task<ActionResult<IEnumerable<GetCategoriesViewModelResponse>>> GetCategories()
    {
        try
        {
            var category = await _categoryService.GetUserCategories();
            return Ok(category);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpGet("GetUserCategoryDetailsById")]
    public async Task<ActionResult<DetailUserCategoryViewModelResponse>> GetUserCategoryDetailsById([FromQuery] string id)
    {
        try
        {
            var category = await _categoryService.DetailUserCategoryById(id);
            return Ok(category);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPost]
    [Route("CreateUserCategory")]
    public async Task<ActionResult<CreateUserCategoryViewModelResponse>> CreateUserCategory([FromBody] CreateUserCategoryViewModel categoryPayload)
    {
        try
        {
            var category = await _categoryService.CreateUserCategory(categoryPayload);
            return Ok(category);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPut("UpdateUserCategoryById")]
    public async Task<ActionResult<UpdateUserCategoryViewModelResponse>> UpdateUserCategoryById([FromBody] UpdateUserCategoryViewModel categoryToUpdate)
    {
        try
        {
            var category = await _categoryService.UpdateUserCategoryById(categoryToUpdate);
            return Ok(category);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpDelete("DeleteUserCategoryById")]
    public async Task<ActionResult<DetailUserCategoryViewModelResponse>> DeleteUserCategoryById([FromQuery] string id)
    {
        try
        {
            var category = await _categoryService.DeleteUserCategoryById(id);
            return Ok(category);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

}
