using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[Route("api/[controller]")]

[ApiController]
public class PayController : ControllerBase
{
    //POST api/<PayController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
        Console.WriteLine(value);
    }
}
