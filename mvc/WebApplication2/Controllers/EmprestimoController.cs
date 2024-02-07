using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;
using System.Linq;

namespace WebApplication2.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly ContextoDB contexto;

        public EmprestimoController(ContextoDB context)
        {
            contexto = context;
        }

        public IActionResult Index()
        {
            var emprestimos = contexto.Emprestimos.ToList();
            return View(emprestimos);
        }

        [HttpPost]
        public IActionResult Index(EmprestimoModel emprestimo)
        {
            if (ModelState.IsValid)
            {
                contexto.Emprestimos.Add(emprestimo);
                contexto.SaveChanges();
            }

            var emprestimosDB = contexto.Emprestimos.ToList();
            return View(emprestimosDB);
        }

        public IActionResult Cadastra()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastra(EmprestimoModel emprestimo)
        {
            if (ModelState.IsValid)
            {
                contexto.Add(emprestimo);
                contexto.SaveChanges();
            }

            return View(emprestimo);
        }
    }
}
