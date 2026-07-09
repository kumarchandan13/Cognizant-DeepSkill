using Microsoft.AspNetCore.Mvc;

namespace Swagger_Postman.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private static readonly List<string> Employees = new()
    {
        "Anisha",
        "Rahul",
        "Priya",
        "Rohan"
    };

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return Ok(Employees);
    }

    [HttpPost]
    public ActionResult Post([FromBody] string employee)
    {
        Employees.Add(employee);
        return Ok("Employee Added Successfully");
    }
}