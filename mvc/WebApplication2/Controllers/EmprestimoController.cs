//using Microsoft.AspNetCore.Mvc;
//using WebApplication2.Models;

//namespace WebApplication2.Controllers
//{
//    public class EmprestimoController : Controller
//    {
//        Data.ContextoDB contexto = new Data.ContextoDB();

//        public IActionResult Index()
//        {
//            var emprestimo = contexto.Emprestimos.ToList();

//            return View(emprestimo);

//        }
//        [HttpPost]
//        public IActionResult Index(EmprestimoModel empretimossss)
//        {
//            contexto.Emprestimos.Add(empretimossss);
//            contexto.SaveChanges();
//            var emprestimosDB = contexto.Emprestimos.ToList();
//            return View(emprestimosDB);
//        }

//        public IActionResult Cadastra()
//        {

//            var emprestimoModel = new EmprestimoModel(); // inicialize o objeto se necessário
//            return View(emprestimoModel);
//        }
//        [HttpPost]
//        public IActionResult Cadastra(EmprestimoModel rtd)
//        {
//            contexto.Add(rtd);
//            return View(rtd);
//        }

//    }
//}
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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
            var emprestimoModel = new EmprestimoModel();
            return View(emprestimoModel);
        }

        [HttpPost]
        public IActionResult Cadastra(EmprestimoModel rtd, string nomeLivro, string nomeUsuario)
        {
      
            if (string.IsNullOrEmpty(nomeLivro))
            {
                ModelState.AddModelError("NomeLivro", "Nome do livro é obrigatório");
                return View(rtd);
            }

         
            var livro = contexto.Livros.FirstOrDefault(l => l.LIVRO == nomeLivro);
            if (livro == null)
            {
                ModelState.AddModelError("NomeLivro", "Livro não encontrado");
                return View(rtd);
            }


            rtd.IDLIVRO = livro.COD;
            rtd.IDUSUARIO = nomeUsuario;
            rtd.DTEMPRESTIMO = DateTime.Now;

            // Adicionar o empréstimo ao contexto e salvar as mudanças
            contexto.Emprestimos.Add(rtd);
            contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
