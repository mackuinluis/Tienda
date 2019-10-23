using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tienda.Models;

namespace Tienda.Controllers
{
    public class ProductosController : Controller
    {
        private TiendaContext _context;
        public ProductosController(TiendaContext x) {
            _context = x;
        }

        public IActionResult Index()
        {
            var lista = _context.Productos.Include(x => x.Categoria).ToList();
            return View(lista);
        }

        public IActionResult Registrar()
        {
            ViewBag.Categorias = _context.Categorias.ToList();
            return View();
        }        

        [HttpPost]
        public IActionResult Registrar(Producto x)
        {
            ViewBag.Categorias = _context.Categorias.ToList();
            
            if (ModelState.IsValid) {
                _context.Add(x);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(x);
        }
    }
}