using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using liga.Models;

namespace liga.Controllers
{
    public class PokemonController : Controller
    {
        private PokemonContext _context;

        public PokemonController(PokemonContext c) {
            _context = c;
        }

        public IActionResult Index()
        {
            var pokemones = _context.Pokemones.ToList();

            return View(pokemones);
        }

        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Pokemon p)
        {
            if (ModelState.IsValid) {
                _context.Add(p);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(p);
        }
    }
}
