using Microsoft.AspNetCore.Mvc;

namespace _1.WebApi_Handson.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    private static List<string> values = new()
    {
        "Laptop",
        "Mobile",
        "Keyboard"
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(values);
    }

    [HttpPost]
    public IActionResult Post([FromBody] string value)
    {
        values.Add(value);
        return Ok("Value Added Successfully");
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] string value)
    {
        if (id >= values.Count)
            return BadRequest();

        values[id] = value;
        return Ok("Value Updated Successfully");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (id >= values.Count)
            return BadRequest();

        values.RemoveAt(id);
        return Ok("Value Deleted Successfully");
    }
}