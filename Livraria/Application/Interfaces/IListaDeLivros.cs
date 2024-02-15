using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livraria.Domain.Models;

namespace Livraria.Application.Interfaces
{
    public interface IListaDeLivros
    {
        void CadastraLivro(string livro);
        List<string> Lista();
        bool VerificaAssociacao(string livro);
        void AssociaUsuario(string livro, Usuario usuario);
    }
}
