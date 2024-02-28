using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Data
{
    public class LivrariaContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var conexao = "server=193.203.175.59;port=3306;database=u123648597_livraria;user=u123648597_livraria;password=Livraria#123";
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
            
        }

        public DbSet<Livros> Livros { get; set; } 

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
