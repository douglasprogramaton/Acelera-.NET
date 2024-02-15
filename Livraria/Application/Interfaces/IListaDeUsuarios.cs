using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livraria.Domain.Models;

namespace Livraria.Application.Interfaces
{
    public interface IListaDeUsuarios
    {
        void AdicionaUsuarios(Usuario usuario);
        List<Usuario> GetUsuarios();
        void SalvaLocalJSON(string arquivo);
        void SalvaLocalCSV(string arquivo);
        void CarregaLocal(string arquivo);
    }
}
