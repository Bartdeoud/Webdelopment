using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[Route("api/[controller]")]

[ApiController]
public class PayController : ControllerBase
{
    // GET: api/<PayController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] {"Value1","Value2"};
    }

    //Get api//<PayController>/id
    [HttpGet("pay")]
    public string Get(int id)
    {
        return "Value";
    } 

    //POST api/<PayController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    //PUT api/<PayController>/id
    [HttpPut ("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    } 

    //DELETE api/<PayController>/id
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
