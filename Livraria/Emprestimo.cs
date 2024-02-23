using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    public class Emprestimo
    {
        /// <summary>
        /// Livro emprestado
        /// </summary>
        public Livros Livros { get; set; }

        /// <summary>
        /// Usuario leitor
        /// </summary>
        public Usuario Usuario { get; set; }

        /// <summary>
        /// Data da Retirada
        /// </summary>
        public DateTime Retirada { get; set; }

        /// <summary>
        /// Data da devolução
        /// </summary>
        public DateTime Devolucao { get; set; }

        /// <summary>
        /// Construct padrão
        /// </summary>
        /// <param name="livros">Livro a emprestar</param>
        /// <param name="usuario">Usuario leitor</param>
        public Emprestimo(Livros livros, Usuario usuario)
        {
            Livros = livros;
            Usuario = usuario;
            Retirada = DateTime.Now;
            Devolucao = DateTime.Now.AddDays(3);
        }

        
    }
}
