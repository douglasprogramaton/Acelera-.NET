using Livraria;

public class Emprestimo
{
    public Livros Livros { get; set; }
    public Usuario Usuario { get; set; }
    public DateTime Retirada { get; set; }
    public DateTime Devolucao { get; set; }

    public Emprestimo(Livros livros, Usuario usuario)
    {
        Livros = livros;
        Usuario = usuario;
        Retirada = DateTime.Now;
        Devolucao = DateTime.Now.AddDays(3);
    }
}
