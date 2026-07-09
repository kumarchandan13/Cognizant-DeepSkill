using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _3.Custom_Model_Filter.Filters;

public class CustomAuthFilter : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.HttpContext.Request.Headers.ContainsKey("Authorization"))
        {
            context.Result = new BadRequestObjectResult("Invalid request - No Auth token");
            return;
        }

        var token = context.HttpContext.Request.Headers["Authorization"].ToString();

        if (!token.Contains("Bearer"))
        {
            context.Result = new BadRequestObjectResult("Invalid request - Token present but Bearer unavailable");
        }
    }
}