using System;
using System.Collections.Generic;
using System.Data;
using System.IO; // Adicionei a importação do namespace System.IO para utilizar File
using System.Linq;
using Newtonsoft.Json; // Removi a importação desnecessária do Newtonsoft.Json
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Livraria;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Livraria
{
    public class ListaDeUsuarios
    {
        List<Usuario> ListaUsuarios { get; set; }

        public ListaDeUsuarios(List<Usuario> usuarios)
        {
            ListaUsuarios = usuarios; // Atribui a lista de usuários passada para ListaUsuarios
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
            string json = JsonSerializer.Serialize(ListaUsuarios);
            File.WriteAllText(arquivo, json);
        }

        public void SalvaLocalCSV(string arquivo)
        {
            string json = JsonSerializer.Serialize(ListaUsuarios);

            try
            {
                XmlNode xml = JsonConvert.DeserializeXmlNode("{records:{record:" + json + "}}");

                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xml.InnerXml);

                DataSet dataSet = new DataSet();
                dataSet.ReadXml(new XmlNodeReader(xmldoc));

                string csv = DTableToCsv(dataSet.Tables[0], ",");

                File.WriteAllText(arquivo, csv);
            }
            catch { throw; }
        }

        private string DTableToCsv(DataTable table, string delimator)
        {
            try
            {
                var result = new StringBuilder();

                for (int i = 0; i < table.Columns.Count; i++)
                {
                    result.Append(table.Columns[i].ColumnName);
                    result.Append(i == table.Columns.Count - 1 ? "\n" : delimator);
                }

                foreach (DataRow row in table.Rows)
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        result.Append(row[i].ToString());
                        result.Append(i == table.Columns.Count - 1 ? "\n" : delimator);
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
}
