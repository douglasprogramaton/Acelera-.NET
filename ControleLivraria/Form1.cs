using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControlLivraria.DAO;
using Livraria;
using Newtonsoft.Json;

namespace ControleLivraria
{
    public partial class ControleDeBiblioteca : Form
    {
        ListaDeUsuarios ListaUsuarios;
        ListaDeLivros ListaLivros;
        ListaDeEmprestimos emprestimos;
        Livraria.Data.LivrariaContext contextoDB;

        public ControleDeBiblioteca()
        {
            InitializeComponent();
            contextoDB = new Livraria.Data.LivrariaContext();
            ListaLivros = new ListaDeLivros(); // Inicializa a lista de livros
            emprestimos = new ListaDeEmprestimos(); // Inicializa a lista de empréstimos

            // Popula a lista de usuários após inicializar o contextoDB
            // Certifique-se de que o contextoDB.Usuarios retorne uma lista válida de usuários
            if (contextoDB != null && contextoDB.Usuarios != null)
            {
                // Aqui vamos converter os usuários do tipo dynamic para Usuario
                var usuarios = contextoDB.Usuarios.Select(u => new Usuario(u.Nome, u.Login, u.Senha)).ToList();
                ListaUsuarios = new ListaDeUsuarios(usuarios);
            }
            else
            {
                ListaUsuarios = new ListaDeUsuarios(new List<Usuario>());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNome.Text) || string.IsNullOrEmpty(txbLogin.Text) || string.IsNullOrEmpty(txbSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else
            {
                using (var context = new LivrariaContext())
                {
                    Usuario novoUsuario = new Usuario(txbNome.Text, txbLogin.Text, txbSenha.Text);

                    context.Usuarios.Add(novoUsuario);
                    context.SaveChanges();
                }

                atualizaDGUsuarios();
            }
        }

        private void btn_adicionarLivro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxLivro.Text) || string.IsNullOrEmpty(txtBoxCod.Text) || string.IsNullOrEmpty(txtBoxValor.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
            else
            {
                string novoLivro = txtBoxLivro.Text;
                Livros novoLivroObj = new Livros(txtBoxLivro.Text, Convert.ToInt32(txtBoxPaginas.Text), Convert.ToInt32(txtBoxCod.Text), Convert.ToDecimal(txtBoxValor.Text));
                ListaLivros.CadastraLivro(novoLivro);
                contextoDB.Livros.Add(novoLivroObj);
                contextoDB.SaveChanges();
                atualizaDGLivros();
            }
        }

        private void atualizaDGUsuarios()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ListaUsuarios.GetUsuarios();
            dgvUsuarios.DataSource = bs;
        }

        private void atualizaDGLivros()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ListaLivros.Lista();
            dgvLivros.DataSource = bs;
        }

        private void atualizaDGEmprestimos()
        {
            BindingSource bsLivros = new BindingSource();
            bsLivros.DataSource = ListaLivros.Lista();
            dgvEmprestimos.DataSource = bsLivros;

            BindingSource bsUsuarios = new BindingSource();
            bsUsuarios.DataSource = ListaUsuarios.GetUsuarios();
            dgvEmprestimos.DataSource = bsUsuarios;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Verifica se contextoDB e contextoDB.Usuarios não são nulos
            if (contextoDB != null && contextoDB.Usuarios != null)
            {
                // Aqui vamos converter os usuários do tipo dynamic para Usuario
                var usuarios = contextoDB.Usuarios.Select(u => new Usuario(u.Nome, u.Login, u.Senha)).ToList();
                ListaUsuarios = new ListaDeUsuarios(usuarios);
            }
            else
            {
                // Se contextoDB ou contextoDB.Usuarios forem nulos, inicialize ListaUsuarios com uma lista vazia
                ListaUsuarios = new ListaDeUsuarios(new List<Usuario>());
            }
        }


        private void btnSalvarUsuarioCSVClick(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo .CSV (.csv) | *.csv";
            string nomeArquivo;
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                nomeArquivo = saveFileDialog1.FileName;

                ListaUsuarios.SalvaLocalCSV(nomeArquivo);
            }
        }

        private void btnExpCSV_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo .CSV (.csv) | *.csv";
            string nomeArquivo;
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                nomeArquivo = saveFileDialog1.FileName;
                // Implemente a lógica para exportar os livros em formato CSV
            }
        }

        private void btnSalvarUsuarioJson_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo .JSON (.json) | *.json";
            string nomeArquivo;
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                nomeArquivo = saveFileDialog1.FileName;

                ListaUsuarios.SalvaLocalJSON(nomeArquivo);
            }
        }

        private void btnCarregarUsuario_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivo .CSV (.csv) | *.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ListaUsuarios.CarregaLocal(openFileDialog1.FileName);
            }

            atualizaDGUsuarios();
        }

        private void btnAssociarLivro_Click(object sender, EventArgs e)
        {
            if (comboBoxUsuario.SelectedItem == null || comboBoxLivros.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um usuário e um livro para associar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o usuário selecionado
            Usuario usuarioSelecionado = (Usuario)comboBoxUsuario.SelectedItem;

            // Obtém o livro selecionado
            string livroSelecionado = comboBoxLivros.SelectedItem.ToString();

            // Verifica se o livro já está associado a algum usuário
            if (ListaLivros.VerificaAssociacao(livroSelecionado))
            {
                MessageBox.Show($"O livro '{livroSelecionado}' já está associado a outro usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Associa o livro ao usuário
            ListaLivros.AssociaUsuario(livroSelecionado, usuarioSelecionado);

            // Atualiza os DataGridViews
            atualizaDGEmprestimos();

            MessageBox.Show($"Usuário '{usuarioSelecionado.Nome}' associado ao livro '{livroSelecionado}'.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            var textoFiltro = txtPesquisar.Text;

            bs.DataSource = ListaUsuarios.GetUsuarios().Where((usuario) => usuario.Nome.Contains(textoFiltro)).ToList();

            dgvUsuarios.DataSource = bs;
        }
    }
}
