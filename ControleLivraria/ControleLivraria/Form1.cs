using Livraria;
using System.Collections.Generic;

namespace ControleLivraria
{
    public partial class Form1 : Form
    {
        ListaDUsuarios ListaUsuarios;
        ListaDLivros ListaLivros;

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNome.Text) || string.IsNullOrEmpty(txbLogin.Text) || string.IsNullOrEmpty(txbSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else
            {
                ListaUsuarios.AdicionaUsuarios(new Usuario(txbNome.Text, txbLogin.Text, txbSenha.Text));
                atualizaDGVUsuarios();
            }

            comboBoxUsuario.DataSource = ListaUsuarios.GetUsuarios();
            comboBoxUsuario.DisplayMember = "Nome";
            atualizaDGVEmprestimos();
        }

        private void btn_addLivro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxLivro.Text) || string.IsNullOrEmpty(txtBoxCod.Text) || string.IsNullOrEmpty(txtBoxValor.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
            else
            {
                int valor = int.Parse(txtBoxValor.Text);
                int paginas = int.Parse(txtBoxPaginas.Text);
                int codigo = int.Parse(txtBoxCod.Text);
                ListaLivros.CadastraLivro(new Livros(txtBoxLivro.Text, codigo, valor, paginas));
                atualizaDGVLivros();
            }
            comboBoxLivros.DataSource = ListaLivros.GetLivros();
            comboBoxLivros.DisplayMember = "Livro";
            atualizaDGVEmprestimos();
        }

        private void atualizaDGVUsuarios()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ListaUsuarios.GetUsuarios();
            dgvUsuarios.DataSource = bs;
        }

        private void atualizaDGVLivros()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ListaLivros.GetLivros();
            dgvLivros.DataSource = bs;
        }
        private void atualizaDGVEmprestimos()
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = ListaLivros.GetLivros();
            dgvEmprestimos.DataSource = bs;

            bs.DataSource = ListaUsuarios.GetUsuarios();
            dgvEmprestimos.DataSource = bs;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaUsuarios = new ListaDUsuarios();
            ListaLivros = new ListaDLivros();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo .CSV (.csv) | *.csv";
            string nomeArquivo;
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                nomeArquivo = saveFileDialog1.FileName;

                ListaUsuarios.SalvaLocalCSV(nomeArquivo);
            }

        }

        private void btnExportLivrosCSV_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo .CSV (.csv) | *.csv";
            string nomeArquivo;
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                nomeArquivo = saveFileDialog1.FileName;

                Livros.LivroFromCsv(nomeArquivo);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo .JSON (.json) | *.json";
            string nomeArquivo;
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                nomeArquivo = saveFileDialog1.FileName;

                ListaUsuarios.SalvaLocalJSON(nomeArquivo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Arquivo .CSV (.csv) | *.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ListaUsuarios.CarregaLocal(openFileDialog1.FileName);
            }

            atualizaDGVUsuarios();
        }

        private void btnUser_Livro_Click(object sender, EventArgs e)
        {
            if (comboBoxUsuario.SelectedItem == null || comboBoxLivros.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um usuário e um livro para associar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuarioSelecionado = (Usuario)comboBoxUsuario.SelectedItem;
            Livros livroSelecionado = (Livros)comboBoxLivros.SelectedItem;

            if (livroSelecionado.UsuarioAssociado != null)
            {
                MessageBox.Show($"O livro '{livroSelecionado.Livro}' já está associado ao usuário '{livroSelecionado.UsuarioAssociado.Nome}'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            livroSelecionado.UsuarioAssociado = usuarioSelecionado;
            usuarioSelecionado.LivroAssociado = livroSelecionado;

            atualizaDGVEmprestimos();

            MessageBox.Show($"Usuário '{usuarioSelecionado.Nome}' associado ao livro '{livroSelecionado.Livro}'.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}