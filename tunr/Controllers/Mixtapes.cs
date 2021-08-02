using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using tunr.Data;
using tunr.Models;


namespace tunr.Controllers
{
    public class Mixtapes : Controller
    {
        private readonly tunrContext _context;

        public Mixtapes(tunrContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Mixtapes.ToListAsync());
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
