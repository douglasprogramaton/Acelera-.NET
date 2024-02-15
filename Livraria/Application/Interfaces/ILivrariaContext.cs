using Livraria.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Interfaces
{
    internal interface ILivrariaContext
    {
        DbSet<Livros> Livros { get; set; }
        DbSet<Usuario> Usuarios { get; set; }
        int SaveChanges();
    }
}
