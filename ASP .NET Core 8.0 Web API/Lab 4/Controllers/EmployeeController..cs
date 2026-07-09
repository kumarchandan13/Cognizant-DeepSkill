using Microsoft.AspNetCore.Mvc;
using _4.CRUD_Operations.Models;

namespace _4.CRUD_Operations.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = GetEmployees();

    // GET: api/Employee
    [HttpGet]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(employees);
    }

    // POST: api/Employee
    [HttpPost]
    public ActionResult<Employee> Post([FromBody] Employee employee)
    {
        employees.Add(employee);
        return Ok(employee);
    }

    // PUT: api/Employee/1
    [HttpPut("{id}")]
    public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
    {
        if (id <= 0)
            return BadRequest("Invalid employee id");

        var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

        if (existingEmployee == null)
            return BadRequest("Invalid employee id");

        existingEmployee.Name = employee.Name;
        existingEmployee.Salary = employee.Salary;
        existingEmployee.Permanent = employee.Permanent;
        existingEmployee.Department = employee.Department;
        existingEmployee.Skills = employee.Skills;
        existingEmployee.DateOfBirth = employee.DateOfBirth;

        return Ok(existingEmployee);
    }

    // DELETE: api/Employee/1
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (id <= 0)
            return BadRequest("Invalid employee id");

        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
            return BadRequest("Invalid employee id");

        employees.Remove(employee);

        return Ok("Employee Deleted Successfully");
    }

    private static List<Employee> GetEmployees()
    {
        return new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Anisha",
                Salary = 60000,
                Permanent = true,
                DateOfBirth = new DateTime(2003, 5, 12),
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
                        Name = "SQL"
                    }
                }
            },
            new Employee
            {
                Id = 2,
                Name = "Rahul",
                Salary = 50000,
                Permanent = false,
                DateOfBirth = new DateTime(2001, 8, 20),
                Department = new Department
                {
                    Id = 2,
                    Name = "HR"
                },
                Skills = new List<Skill>
                {
                    new Skill
                    {
                        Id = 3,
                        Name = "Communication"
                    }
                }
            }
        };
    }
}