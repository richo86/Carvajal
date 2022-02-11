using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.API.Controllers
{
    [Route("start")]
    [ApiController]
    public class HomeController : Controller
    {
        public ActionResult<IEnumerable<string>> Index()
        {
            return new string[] { "API:", "Escuchando" };
        }
    }
}
