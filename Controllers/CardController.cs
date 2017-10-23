using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace calling_card.Controllers
{
    public class CardController : Controller
    {
        [HttpGet]
        [Route("{First}/{Last}/{Age}/{Color}")]
        public JsonResult ShowJson(string First, string Last, string Age, string Color)
        {
            var AnonJson = new {
                FirstName = First,
                LastName = Last,
                Age = Age,
                FavoriteColor = Color,
            };
            return Json(AnonJson);
        }
    }
}