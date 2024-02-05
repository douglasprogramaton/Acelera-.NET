using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Livros LivroAssociado { get; set; }

        public Usuario(string nome, string login, string senha)
        {
            Nome = nome;
            Id = Guid.NewGuid().ToString();
            Login = login;
            Senha = senha;

            Console.WriteLine($"Usuário {Id} cadastrado com sucesso!");
            Console.WriteLine("");
        }

        public Usuario(string id, string nome, string login, string senha)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Senha = senha;

            Console.WriteLine($"Usuário {Id} cadastrado com sucesso!");
            Console.WriteLine("");
        }

        public static Usuario FromCsv(string csvLine)
        {
            string[] campos = csvLine.Split(',');
            Usuario usu = new Usuario(campos[0], campos[1], campos[2], campos[3]);
            return usu;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
