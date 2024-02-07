using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmprestimoController : Controller
    {
        Data.ContextoDB contexto = new Data.ContextoDB();

        public IActionResult Index()
        {
            var emprestimo = contexto.Emprestimos.ToList();

            return View(emprestimo);

        }
        [HttpPost]
        public IActionResult Index(EmprestimoModel empretimossss)
        {
            contexto.Emprestimos.Add(empretimossss);
            contexto.SaveChanges();
            var emprestimosDB = contexto.Emprestimos.ToList();
            return View(emprestimosDB);
        }

        public IActionResult Cadastra()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastra(EmprestimoModel rtd)
        {
            contexto.Add(rtd);
            return View(rtd);
        }

    }
}
