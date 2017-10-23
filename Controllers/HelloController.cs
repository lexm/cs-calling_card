using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("Index")]
        public string Index()
        {
            return "Hello World!";
        }

        [HttpGet]
        [Route("hello/{Name}")]
        public string Method(string Name)
        {
            return "Hello, " + Name;
        }
        [HttpGet]
        [Route("gudbye/{name}")]
        public JsonResult ShowJson(string name)
        {
            var AnonJson = new {
                Name = name,
                Type = "Wat",
            };
            return Json(AnonJson);
        }
    }
}