using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using liga.Models;

namespace liga.Controllers
{
    public class EntrenadorController : Controller
    {
        private PokemonContext _context;

        public EntrenadorController(PokemonContext c) {
            _context = c;
        }

        public IActionResult Index()
        {
            var entrenadores = _context.Entrenadores.ToList();

            return View(entrenadores);
        }

        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Entrenador x)
        {
            if (ModelState.IsValid)
            {
                _context.Add(x);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(x);
        }
    }
}
