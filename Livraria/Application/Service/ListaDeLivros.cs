using Livraria.Application.Interfaces;
using Livraria.Domain.Models;

public class ListaDeLivros: IListaDeLivros
{
    private List<string> livrosList { get; set; }

    public ListaDeLivros()
    {
        livrosList = new List<string>();
    }

    public void CadastraLivro(string livro)
    {
        livrosList.Add(livro);
    }

    public List<string> Lista()
    {
        return livrosList;
    }

    public bool VerificaAssociacao(string livro)
    {
        // Verifica se o livro está associado a algum usuário
        // Implemente a lógica necessária para verificar a associação no banco de dados
        return false; // Ajuste conforme necessário
    }

    public void AssociaUsuario(string livro, Usuario usuario)
    {
        // Associa o livro ao usuário no banco de dados
        // Implemente a lógica necessária para associar o livro ao usuário no banco de dados
    }
}
