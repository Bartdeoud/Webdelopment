using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GebruikerController : ControllerBase
{
    // GET: api/<Gebruiker>/
    [HttpGet("get_all_gebruikers")]
    public List<Gebruiker> Get()
    {
        return GebruikerHandler.getListGebruiker();
    } 

    //Get api//<Gebruiker>/id
    [HttpGet("get_gebruiker_withID{userID}")]
    public IResult Get(int userID)
    {
        //Gebruiker returnGebruiker = await GebruikerHandler.getGebruikerWithIDAsync(userID);
        //moet eigenlijk await zijn, zie GebruikerHandler
        Gebruiker returnGebruiker = GebruikerHandler.getGebruikerWithIDAsync(userID);

        if (returnGebruiker != null)
        {
            return Results.Ok(returnGebruiker);
        }
        else
        {
            return Results.BadRequest();
        }
    } 

    //POST api/<Gebruiker>
    [HttpPost("add_gebruiker")]
    public async Task<IResult> Post(Gebruiker newGebruiker)
    {
        //Gebruiker returnGebruiker = await GebruikerHandler.getGebruikerWithIDAsync(userID);
        //moet eigenlijk await zijn, zie GebruikerHandler
        bool returnGebruikerBool = await GebruikerHandler.addGebruikerAsync(newGebruiker);

        if (returnGebruikerBool)
        {
            return Results.Ok("Success");
        }
        else
        {
            return Results.BadRequest();
        }
    }

    //PUT api/<Gebruiker/id
    [HttpPut ("{id}")]
    public async Task<IResult> Put(Gebruiker updateGebruiker)
    {
        bool updateGebruikerBool = await GebruikerHandler.updateGebruikerAsync(updateGebruiker);

        if (updateGebruikerBool)
        {
            return Results.Ok("Success");
        }
        else
        {
            return Results.BadRequest();
        }
    } 

    //DELETE api/<Gebruiker/id
    [HttpDelete("delete_gebruiker_with_id/{id}")]
    public async Task<IResult> Delete(int id)
    {
        bool deleteGebruikerBool = await GebruikerHandler.deleteGebruikerAsync(id);

        if (deleteGebruikerBool)
        {
            return Results.Ok("Success");
        }
        else
        {
            return Results.BadRequest();
        }
    }
}
