using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tunr.Controllers
{
    public class Mixtapes : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            return View();
        }

        public IActionResult Submit(string MixtapeTitle, string MixtapeTags)
        {
            return Content("You had submitted" + MixtapeTitle);
        }
    }
}
