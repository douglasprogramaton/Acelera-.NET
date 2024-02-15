using Microsoft.EntityFrameworkCore;
using Livraria.Domain.Models;
using Livraria.Application.Interfaces;

namespace Livraria.Infrastructure.Data
{
    public class LivrariaContext : DbContext, ILivrariaContext
    {
        public LivrariaContext(DbContextOptions<LivrariaContext> options, string connectionString) : base(options)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }

        public DbSet<Livros> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString));
            }
        }
    }
}
