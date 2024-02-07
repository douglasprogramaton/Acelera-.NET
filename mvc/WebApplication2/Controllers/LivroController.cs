using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System.Linq;
using System.Collections.Generic;

namespace WebApplication2.Controllers
{
    public class LivroController : Controller
    {
        List<LivroModel> usas = new List<LivroModel> { };
        Data.ContextoDB contexto = new Data.ContextoDB();

        public IActionResult Index(bool success = false)
        {
           
            var livros = contexto.Livros.ToList();
            return View(livros);
        }

        public IActionResult Cadastra()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LivroModel livrosss)
        {
            contexto.Livros.Add(livrosss);

            contexto.SaveChanges();

            var livroBD = contexto.Livros.ToList();

            return View(livroBD);
        }

        [HttpPost]
        public IActionResult Cadastra(LivroModel livrosss)
        {
            if (ModelState.IsValid)
            {
                contexto.Livros.Add(livrosss);
                contexto.SaveChanges();
                ViewBag.Success = true;
                return RedirectToAction("Index", new { success = true });
            }
        
            return View("Cadastra", livrosss);
        }
    }
}
