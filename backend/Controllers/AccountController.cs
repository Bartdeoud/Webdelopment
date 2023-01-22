using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace backend.Controllers;

[Route("api/[controller]")]

[ApiController]
public class AccountController : ControllerBase
{
    [HttpGet ("checkloginof{username},{password}")]
    public async Task<IResult> Get(String username, string password){
        bool correctelogin = await Loginhandler.checkLogin(username,password);
        if (correctelogin)
        {
            return Results.Ok("Success");
        }
        else
        {
            return Results.BadRequest();
        }
    }
}