using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Livraria
{
    public class ListaDeEmprestimos
    {

        public List<Emprestimo> ListaEmprestimos { get; set; }

        public ListaDeEmprestimos()
        {
            ListaEmprestimos = new List<Emprestimo>();
        }

        public void AdicionaEmprestimo(Usuario usuario, Livros livro)
        {
            ListaEmprestimos.Add(new Emprestimo(livro,usuario));
        }

        public void SalvaLocalJSON(string arquivo)
        {
            string json = JsonSerializer.Serialize(ListaEmprestimos);
            File.WriteAllText(arquivo, json);

        }
    }
}
