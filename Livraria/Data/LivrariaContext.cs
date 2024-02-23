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

            var conexao = "server=zapcidade.app;port=3306;database=livraria;uid=livraria;password=aceleranet";
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
            
        }

        public DbSet<Livros> Livros { get; set; } 

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
