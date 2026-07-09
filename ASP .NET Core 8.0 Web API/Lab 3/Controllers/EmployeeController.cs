using Microsoft.AspNetCore.Mvc;
using _3.Custom_Model_Filter.Models;
using _3.Custom_Model_Filter.Filters;

namespace _3.Custom_Model_Filter.Controllers;

[ApiController]
[Route("api/[controller]")]
[CustomAuthFilter]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = GetStandardEmployeeList();

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(employees);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Employee employee)
    {
        employees.Add(employee);
        return Ok("Employee Added Successfully");
    }

    private static List<Employee> GetStandardEmployeeList()
    {
        return new List<Employee>
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
                    new Skill { Id = 1, Name = "C#" },
                    new Skill { Id = 2, Name = "SQL" }
                }
            }
        };
    }
}