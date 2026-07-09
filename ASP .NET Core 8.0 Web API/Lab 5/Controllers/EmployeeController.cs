using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using _5.JWT_Authentication.Models;

namespace _5.JWT_Authentication.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "POC")]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = new()
    {
        new Employee
        {
            Id = 1,
            Name = "Anisha",
            Salary = 60000,
            Permanent = true,
            DateOfBirth = new DateTime(2003,5,12),
            Department = new Department
            {
                Id = 1,
                Name = "IT"
            },
            Skills = new List<Skill>
            {
                new Skill
                {
                    Id = 1,
                    Name = "C#"
                },
                new Skill
                {
                    Id = 2,
                    Name = "ASP.NET Core"
                }
            }
        }
    };

    [HttpGet]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(employees);
    }
}
