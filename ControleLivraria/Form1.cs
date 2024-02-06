using Livraria;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleLivraria
{
    /// <summary>
    /// Classe principal do formulário de controle da livraria.
    /// </summary>
    public partial class ControleDeBiblioteca : Form
    {
        ListaDeUsuarios ListaUsuarios;
        ListaDeLivros ListaLivros;
        ListaDeEmprestimos emprestimos;
        Livraria.Data.LivrariaContext contextoDB;

        /// <summary>
        /// Construtor da classe Form1.
        /// </summary>
        public ControleDeBiblioteca()
        {
            InitializeComponent();
            ListaUsuarios = new ListaDeUsuarios(); // Inicializa a lista de usuários
            ListaLivros = new ListaDeLivros(); // Inicializa a lista de livros
            emprestimos = new ListaDeEmprestimos(); // Inicializa a lista de empréstimos
            contextoDB = new Livraria.Data.LivrariaContext(); // Inicializa o contexto do banco de dados
        }

        /// <summary>
        /// Evento de clique no botão de fechar o formulário.
        /// </summary>
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento de clique no botão de adicionar usuário.
        /// </summary>
        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNome.Text) || string.IsNullOrEmpty(txbLogin.Text) || string.IsNullOrEmpty(txbSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else
            {
                Usuario novo = new Usuario(txbNome.Text, txbLogin.Text, txbSenha.Text);
                ListaUsuarios.AdicionaUsuarios(novo);
                contextoDB.Usuarios.Add(novo);
                contextoDB.SaveChanges();
                atualizaDGUsuarios();
            }
        }

        /// <summary>
        /// Evento de clique no botão de adicionar livro.
        /// </summary>
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

        /// <summary>
        /// Método para atualizar o DataGridView de usuários.
        /// </summary>
        private void atualizaDGUsuarios()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ListaUsuarios.GetUsuarios();
            dgvUsuarios.DataSource = bs;
        }

        /// <summary>
        /// Método para atualizar o DataGridView de livros.
        /// </summary>
        private void atualizaDGLivros()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ListaLivros.Lista();
            dgvLivros.DataSource = bs;
        }

        /// <summary>
        /// Método para atualizar o DataGridView de empréstimos.
        /// </summary>
        private void atualizaDGEmprestimos()
        {
            BindingSource bsLivros = new BindingSource();
            bsLivros.DataSource = ListaLivros.Lista();
            dgvEmprestimos.DataSource = bsLivros;

            BindingSource bsUsuarios = new BindingSource();
            bsUsuarios.DataSource = ListaUsuarios.GetUsuarios();
            dgvEmprestimos.DataSource = bsUsuarios;
        }

        /// <summary>
        /// Evento de carga do formulário.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ListaUsuarios = new ListaDeUsuarios();
            ListaLivros = new ListaDeLivros();
        }

        /// <summary>
        /// Evento de clique no botão para salvar usuários em CSV.
        /// </summary>
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

        /// <summary>
        /// Evento de clique no botão para exportar livros em CSV.
        /// </summary>
        private void btnExpCSV_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo .CSV (.csv) | *.csv";
            string nomeArquivo;
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                nomeArquivo = saveFileDialog1.FileName;


            }
        }

        /// <summary>
        /// Evento de clique no botão para salvar usuários em JSON.
        /// </summary>
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

        /// <summary>
        /// Evento de clique no botão para carregar usuários de um arquivo CSV.
        /// </summary>
        private void btnCarregarUsuario_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivo .CSV (.csv) | *.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ListaUsuarios.CarregaLocal(openFileDialog1.FileName);
            }

            atualizaDGUsuarios();
        }

        /// <summary>
        /// Evento de clique no botão para associar usuário a livro.
        /// </summary>
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
