using lab1.Services.lab3;
using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers.lab3;

[ApiController]
[Route("api/lab3")]

    public class RectangleController : ControllerBase
    {
        [HttpGet]
        [Route("getArea")]
        public int GetArea()
        {
            var rec = new Rectangle(23,23);
            return rec.GetArea();
        }
        
        [HttpGet]
        [Route("getAreaWithX")]
        public int GetArea(int x)
        {
            var rec = new Rectangle(23,23);
            return rec.GetArea(x);
        }
        
        [HttpGet]
        [Route("sum")]
        public Rectangle GetSumArea()
        {
            var rec = new Rectangle(23,23);
            var rec2 = new Rectangle(63,33);

            return rec + rec2;
        }
       
    }
