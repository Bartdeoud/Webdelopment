using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GebruikerController : ControllerBase
{
    // GET: api/<Gebruiker>/
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] {"Value1","Value2"};
    }

    //Get api//<Gebruiker>/id
    [HttpGet("pay")]
    public string Get(int id)
    {
        return "Value";
    } 

    //POST api/<Gebruiker>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    //PUT api/<Gebruiker/id
    [HttpPut ("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    } 

    //DELETE api/<Gebruiker/id
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        
    }
}
