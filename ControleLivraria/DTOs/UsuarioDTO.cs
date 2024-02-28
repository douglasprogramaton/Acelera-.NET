using ControlLivraria.DAO;
using Livraria;
using Newtonsoft.Json;

namespace ControlLivraria.DTOs
{
    internal class UsuarioDTO
    {
        private readonly LivrariaContext _context;

        public UsuarioDTO(LivrariaContext context)
        {
            _context = context;
        }

        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("Login")]
        public string Login { get; set; }

        [JsonProperty("Senha")]
        public string Senha { get; set; }

        public UsuarioDTO() { } // Adicionado para permitir a serialização do JSON

        public void SalvarUsuarioNoBancoDeDados(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        // Outros métodos para trabalhar com o banco de dados...
    }
}