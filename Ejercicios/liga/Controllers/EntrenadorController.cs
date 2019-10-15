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
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }
    }
}
