using Livraria;
using Newtonsoft.Json;
using System.Data;
using System.Text;
using System.Xml;

public class ListaDUsuarios
{
    List<Usuario> ListaUsuarios { get; set; }

    public ListaDUsuarios()
    {
        ListaUsuarios = new List<Usuario>();
    }

    public void AdicionaUsuarios(Usuario usuario)
    {
        ListaUsuarios.Add(usuario);
    }

    public List<Usuario> GetUsuarios()
    {
        return ListaUsuarios;
    }

    public void SalvaLocalJSON(string arquivo)
    {
        string json = JsonConvert.SerializeObject(ListaUsuarios);
        File.WriteAllText(arquivo, json);
    }

    public void SalvaLocalCSV(string arquivo)
    {
        try
        {
            // Converte a lista de usuários diretamente para CSV
            string csv = ToCsv(ListaUsuarios, ",");

            // Escreve o CSV no arquivo
            File.WriteAllText(arquivo, csv);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar o arquivo CSV: {ex.Message}");
            // Lidere com a exceção conforme necessário
        }
    }

    /// <summary>
    /// Converte uma lista de objetos para uma representação CSV.
    /// </summary>
    /// <typeparam name="T">Tipo dos objetos na lista.</typeparam>
    /// <param name="items">Lista de objetos.</param>
    /// <param name="delimiter">Delimitador a ser usado no CSV.</param>
    /// <returns>Uma string representando os objetos em formato CSV.</returns>
    private string ToCsv<T>(List<T> items, string delimiter)
    {
        var csvBuilder = new StringBuilder();

        // Obtém as propriedades públicas de T
        var properties = typeof(T).GetProperties();

        // Escreve os cabeçalhos das colunas no CSV
        csvBuilder.AppendLine(string.Join(delimiter, properties.Select(p => p.Name)));

        // Escreve os dados de cada objeto na lista no CSV
        foreach (var item in items)
        {
            csvBuilder.AppendLine(string.Join(delimiter, properties.Select(p => p.GetValue(item)?.ToString())));
        }

        return csvBuilder.ToString();
    }

    private string DTableToCsv(DataTable table, string delimeter)
    {
        try
        {
            var result = new StringBuilder();

            for (int i = 0; i < table.Columns.Count; i++)
            {
                result.Append(table.Columns[i].ColumnName);
                result.Append(i == table.Columns.Count - 1 ? "\n" : delimeter);
            }

            foreach (DataRow row in table.Rows)
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    result.Append(row[i].ToString());
                    result.Append(i == table.Columns.Count - 1 ? "\n" : delimeter);
                }

            return result.ToString().TrimEnd(new char[] { '\r', '\n' });
        }
        catch { throw; }
    }

    public void CarregaLocal(string arquivo)
    {
        ListaUsuarios = File.ReadAllLines(arquivo)
                                .Skip(1)
                                .Select(v => Usuario.FromCsv(v))
                                .ToList();
    }
}
