﻿using ControleGlicemia_002.Context;
using ControleGlicemia_002.Models;

using Microsoft.AspNetCore.Mvc;

namespace ControleGlicemia_002.Controllers
{
    public class GlicemiasController : Controller
    {
        private readonly GlicemiaContext _context;
        public GlicemiasController(GlicemiaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NovaGlicemia()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NovaGlicemia(Glicemia glicemia)
        {
            if (ModelState.IsValid)
            {
                await _context.AddAsync(glicemia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NovaGlicemia));
            }
            return View(glicemia);
        }

    }
}