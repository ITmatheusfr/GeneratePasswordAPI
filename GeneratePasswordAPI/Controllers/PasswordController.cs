using Microsoft.AspNetCore.Mvc;
using GeneratePasswordAPI.Models;
using GeneratePasswordAPI.Services;

[ApiController]
[Route("api/[controller]")]
public class PasswordController : ControllerBase
{
    private readonly IPasswordService _passwordService;

    public PasswordController(IPasswordService passwordService)
    {
        _passwordService = passwordService;
    }

    [HttpPost("generate")]
    public IActionResult GeneratePassword([FromBody] PasswordRequestModel request)
    {
        try
        {
            var password = _passwordService.GeneratePassword(request);
            return Ok(new { Password = password });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
    }
}
