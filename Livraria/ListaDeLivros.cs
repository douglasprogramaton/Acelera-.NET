using Newtonsoft.Json;
using System.Data;
using System.Text;
using System.Xml;

public class ListaDLivros
{
    List<Livros> LivrosLista;

    public ListaDLivros()
    {
        LivrosLista = new List<Livros>();
    }

    public void CadastraLivro(Livros livro)
    {
        LivrosLista.Add(livro);
    }

    public List<Livros> Lista()
    {
        return LivrosLista;
    }

    public List<Livros> GetLivros()
    {
        return LivrosLista;
    }

    public void SalvaLocalJSON(string arquivo)
    {
        using (var stream = File.CreateText(arquivo))
        {
            var serializer = new JsonSerializer();
            serializer.Serialize(stream, LivrosLista);
        }
    }

    public void SalvaComoCSV(string arquivo, JsonSerializer jsonSerializer)
    {
        string json;
        using (var stream = new StringWriter())
        {
            jsonSerializer.Serialize(stream, LivrosLista);
            json = stream.ToString();
        }

        try
        {
            XmlNode xml = JsonConvert.DeserializeXmlNode("{\"record\": {\"record\": " + json + "}}");
            XmlDocument xmlDoc = new XmlDocument(); xmlDoc.LoadXml(xml.InnerXml);
            DataSet dataSet = new DataSet(); dataSet.ReadXml(new XmlNodeReader(xmlDoc));
            string csv = DTableToCsv(dataSet.Tables[0], ";");
            File.WriteAllText(arquivo, csv);
        }
        catch { throw; }
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
        LivrosLista = File.ReadAllLines(arquivo)
                          .Skip(1)
                          .Select(v => Livros.LivroFromCsv(v))
                          .ToList();
    }
}