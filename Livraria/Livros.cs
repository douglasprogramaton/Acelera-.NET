using Livraria;

public class Livros
{
    public string Livro { get; set; }
    public int Paginas { get; set; }
    public double Codigo { get; set; }
    public decimal Valor { get; set; }
    public Usuario UsuarioAssociado { get; set; }

    public Livros(string livro, int paginas, double codigo, decimal valor)
    {
        Livro = livro;
        Paginas = paginas;
        Codigo = codigo;
        Valor = valor;
    }

    public override string ToString()
    {
        return Livro;
    }

    public static Livros LivroFromCsv(string csvLine)
    {
        string[] campos = csvLine.Split(' ');
        if (campos.Length <= 1)
        {
            throw new Exception("O arquivo não contém campos suficientes");
        }
        Livros livrosCSV = new Livros(campos[0], int.Parse(campos[1]), double.Parse(campos[2]), decimal.Parse(campos[3]));
        return livrosCSV;
    }
}
