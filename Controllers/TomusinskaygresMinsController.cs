using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SGK.Models;

namespace SGK.Controllers
{
    public class TomusinskaygresMinsController : Controller
    {
        private readonly ModelContext _context;

        public TomusinskaygresMinsController(ModelContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Graph()
        {
              return View(await _context.TomusinskaygresMins.ToListAsync());
        }
    }
}
