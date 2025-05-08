namespace ECommerce.AggregatorWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("GetUsers")]
    public async Task<ActionResult<IEnumerable<GetUsersViewModelResponse>>> GetUsers()
    {
        try
        {
            var user = await _userService.GetUsers();
            return Ok(user);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpGet("GetUserDetailsById")]
    public async Task<ActionResult<DetailUserViewModelResponse>> GetUserDetailsById([FromQuery] string id)
    {
        try
        {
            var user = await _userService.DetailUserById(id);
            return Ok(user);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPost]
    [Route("CreateUser")]
    public async Task<ActionResult<CreateUserViewModelResponse>> CreateUser([FromBody] CreateUserViewModel userPayload)
    {
        try
        {
            var user = await _userService.CreateUser(userPayload);
            return Ok(user);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPut("UpdateUserById")]
    public async Task<ActionResult<UpdateUserViewModelResponse>> UpdateUserById([FromBody] UpdateUserViewModel userToUpdate)
    {
        try
        {
            var user = await _userService.UpdateUserById(userToUpdate);
            return Ok(user);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpDelete("DeleteUserById")]
    public async Task<ActionResult<DetailUserViewModelResponse>> DeleteUserById([FromQuery] string id)
    {
        try
        {
            var user = await _userService.DeleteUserById(id);
            return Ok(user);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

}
