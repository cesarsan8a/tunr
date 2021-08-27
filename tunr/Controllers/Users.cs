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
    public class Users : Controller
    {
        private readonly tunrContext _context;
        public Users(tunrContext context)
        {
            _context = context;
        }

        public IActionResult New()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

    }
}
