using Microsoft.AspNetCore.Mvc;

namespace firstapp.Controllers;
using DAL;
using BOL;

[ApiController]
[Route("[controller]")]
public class RolesController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<RolesController> _logger;

    public RolesController(ILogger<RolesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Roles> Get()

    {
        List<Roles> rol = DBManager.GetAllRoles();
        return rol;
    }

    [HttpPost]
    [Route("insert")]


    public IActionResult Add(Roles rol){

        // Roles rol = new Roles();
        DBManager.InsertRoles(rol);

        return Ok(new { name ="Save data Succesfully"});
    }
}
