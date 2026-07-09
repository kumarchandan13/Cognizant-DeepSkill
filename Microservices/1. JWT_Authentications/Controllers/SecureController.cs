using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _1.JWT_Authentication.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SecureController : ControllerBase
{
    [Authorize]
    [HttpGet]
    public IActionResult GetSecureData()
    {
        return Ok(new
        {
            Message = "You have successfully accessed the secured endpoint."
        });
    }
}