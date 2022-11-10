using lab1.Services.lab5;
using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers.lab5;


[ApiController]
[Route("/lab5")]
public class SomeController : ControllerBase
{
    [HttpGet]
    [Route("Print")]
    public string CallMethod()
    {
        var lang = new SomeClass();
        return lang.Print(null);
    }

}