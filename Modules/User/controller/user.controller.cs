using Microsoft.AspNetCore.Mvc;
[Route("user", Name = "user")]
[ApiController]
public class UserController : Controller
{
    public readonly UserService _userService;

    public UserController(UserService userService)
    {
        this._userService = userService;
    }


    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] t_user request)
    {


        try
        {
            var user = _userService.registerUser(request);
            return Ok(user);
        }
        catch (System.Exception)
        {
            throw;
        }

    }

    [HttpPost, Route("login")]
    public async Task<IActionResult> login([FromBody] t_user request)
    {
        var loginUser = await _userService.login(request);
        return Ok(loginUser);
    }
}