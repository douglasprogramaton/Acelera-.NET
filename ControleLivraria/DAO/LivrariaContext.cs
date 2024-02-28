using Livraria;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace ControlLivraria.DAO
{
    internal class LivrariaContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                string connect = "server=193.203.175.59;port=3306;database=u123648597_livraria;user=u123648597_livraria;password=Livraria#123";
                options.UseMySql(connect, ServerVersion.AutoDetect(connect));

                options.LogTo(Console.WriteLine);
            }
        }
    }

}