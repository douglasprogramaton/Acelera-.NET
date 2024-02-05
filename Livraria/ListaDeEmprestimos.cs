using Livraria;

public class ListaDEmprestimos
{
    public List<Emprestimo> ListaEmprestimos { get; set; }

    public ListaDEmprestimos()
    {
        ListaEmprestimos = new List<Emprestimo>();
    }

    public void AdicionaEmprestimo(Usuario usuario, Livros livro)
    {
        ListaEmprestimos.Add(new Emprestimo(livro, usuario));
    }
}