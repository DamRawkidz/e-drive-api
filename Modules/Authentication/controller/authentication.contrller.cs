using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;


[Route("api/authentication", Name = "authentication")]
[ApiController]
public class AuthenticationController : Controller
{
    public readonly AuthenticationService AuthenticationService;
    public AuthenticationController(AuthenticationService _AuthenticationService)
    {
        AuthenticationService = _AuthenticationService;
    }


    [HttpPost]
    public async Task<ActionResult> createAuthentication([FromBody] t_employee request)
    {
        var result = await AuthenticationService.checkEmployeeIsCorrect(request);
        return Ok(result);
    }


}