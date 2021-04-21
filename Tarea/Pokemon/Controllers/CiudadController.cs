using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pokemon.Data;
using Pokemon.Models;

namespace Pokemon.Controllers
{
    public class CiudadController : Controller
    {
        private CiudadContext _context;
        public CiudadController(CiudadContext context){
            _context=context;
        }
        public IActionResult Nuevo(){
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Ciudad c){
            if(ModelState.IsValid){
                _context.Add(c);
                _context.SaveChanges();
                return RedirectToAction("Lista");
            }

            return View(c);
        }

        public IActionResult Lista(){
            var ciudades = _context.Ciudades.OrderBy(x => x.Nombre).ToList();
            return View(ciudades);
        }
    }
}