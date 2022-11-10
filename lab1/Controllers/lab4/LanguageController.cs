using lab1.Services.lab4;
using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers.lab4;

[ApiController]
[Route("/lab4")]
public class LanguageController : ControllerBase
{
    [HttpGet]
    [Route("getLang")]
    public string Get()
    {
        var lang = new Polish("Polski");
        return lang.GetLang();
    }
    
   
}