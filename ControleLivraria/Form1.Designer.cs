namespace ControleLivraria
{
    partial class ControleDeBiblioteca
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleDeBiblioteca));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            dgvUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Senha = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnImport = new Button();
            btnExpJson = new Button();
            btnExport = new Button();
            btnAdicionar = new Button();
            txbSenha = new TextBox();
            label3 = new Label();
            txbLogin = new TextBox();
            label2 = new Label();
            txbNome = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox6 = new GroupBox();
            txtBoxValor = new TextBox();
            btnExportLivrosCSV = new Button();
            label9 = new Label();
            btnImportCSV = new Button();
            btnExportaLivrosJson = new Button();
            btn_AddLivro = new Button();
            txtBoxPaginas = new TextBox();
            label5 = new Label();
            txtBoxCod = new TextBox();
            label7 = new Label();
            txtBoxLivro = new TextBox();
            label8 = new Label();
            groupBox5 = new GroupBox();
            dgvLivros = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            LivroCol = new DataGridViewTextBoxColumn();
            NumPagCol = new DataGridViewTextBoxColumn();
            ValorCol = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            groupBox4 = new GroupBox();
            dgvEmprestimos = new DataGridView();
            Usuario = new DataGridViewTextBoxColumn();
            Livro = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            comboBoxLivros = new ComboBox();
            button4 = new Button();
            label4 = new Label();
            comboBoxUsuario = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            btnUser_Livro = new Button();
            label6 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            button7 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLivros).BeginInit();
            tabPage3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmprestimos).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 25);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(663, 429);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(655, 401);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Usuarios";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvUsuarios);
            groupBox2.Location = new Point(6, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(640, 295);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Login, Senha });
            dgvUsuarios.Location = new Point(12, 17);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(628, 272);
            dgvUsuarios.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Login
            // 
            Login.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Login.DataPropertyName = "Login";
            Login.HeaderText = "Login";
            Login.Name = "Login";
            Login.ReadOnly = true;
            // 
            // Senha
            // 
            Senha.DataPropertyName = "Senha";
            Senha.HeaderText = "Senha";
            Senha.Name = "Senha";
            Senha.ReadOnly = true;
            Senha.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnImport);
            groupBox1.Controls.Add(btnExpJson);
            groupBox1.Controls.Add(btnExport);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txbSenha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbLogin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txbNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnImport
            // 
            btnImport.AutoSize = true;
            btnImport.Image = Properties.Resources.import_csv_32px;
            btnImport.Location = new Point(397, 19);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(75, 57);
            btnImport.TabIndex = 9;
            btnImport.Text = "Imp. CSV";
            btnImport.TextImageRelation = TextImageRelation.ImageAboveText;
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnCarregarUsuario_Click;
            // 
            // btnExpJson
            // 
            btnExpJson.AutoSize = true;
            btnExpJson.Image = Properties.Resources.json_download_32px;
            btnExpJson.Location = new Point(559, 19);
            btnExpJson.Name = "btnExpJson";
            btnExpJson.Size = new Size(75, 57);
            btnExpJson.TabIndex = 8;
            btnExpJson.Text = "Exp. JSON";
            btnExpJson.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExpJson.UseVisualStyleBackColor = true;
            btnExpJson.Click += btnSalvarUsuarioJson_Click;
            // 
            // btnExport
            // 
            btnExport.AutoSize = true;
            btnExport.Image = Properties.Resources.export_csv_32px;
            btnExport.Location = new Point(478, 19);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 57);
            btnExport.TabIndex = 7;
            btnExport.Text = "Exp. CSV";
            btnExport.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnSalvarUsuarioCSVClick;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSize = true;
            btnAdicionar.Image = Properties.Resources.usuario2;
            btnAdicionar.Location = new Point(306, 19);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 57);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionarUsuario_Click;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(199, 48);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(96, 23);
            txbSenha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 51);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(49, 48);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(96, 23);
            txbLogin.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 51);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(49, 19);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(246, 23);
            txbNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 22);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox6);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(655, 401);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Livros";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtBoxValor);
            groupBox6.Controls.Add(btnExportLivrosCSV);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(btnImportCSV);
            groupBox6.Controls.Add(btnExportaLivrosJson);
            groupBox6.Controls.Add(btn_AddLivro);
            groupBox6.Controls.Add(txtBoxPaginas);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(txtBoxCod);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(txtBoxLivro);
            groupBox6.Controls.Add(label8);
            groupBox6.Location = new Point(9, 9);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(640, 102);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            // 
            // txtBoxValor
            // 
            txtBoxValor.Location = new Point(233, 48);
            txtBoxValor.Name = "txtBoxValor";
            txtBoxValor.PasswordChar = '*';
            txtBoxValor.Size = new Size(62, 23);
            txtBoxValor.TabIndex = 11;
            // 
            // btnExportLivrosCSV
            // 
            btnExportLivrosCSV.AutoSize = true;
            btnExportLivrosCSV.Image = Properties.Resources.export_csv_32px;
            btnExportLivrosCSV.Location = new Point(475, 19);
            btnExportLivrosCSV.Name = "btnExportLivrosCSV";
            btnExportLivrosCSV.Size = new Size(75, 57);
            btnExportLivrosCSV.TabIndex = 7;
            btnExportLivrosCSV.Text = "Exp. CSV";
            btnExportLivrosCSV.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExportLivrosCSV.UseVisualStyleBackColor = true;
            btnExportLivrosCSV.Click += btnExpCSV_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(194, 51);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 10;
            label9.Text = "Valor";
            // 
            // btnImportCSV
            // 
            btnImportCSV.AutoSize = true;
            btnImportCSV.Image = Properties.Resources.import_csv_32px;
            btnImportCSV.Location = new Point(394, 19);
            btnImportCSV.Name = "btnImportCSV";
            btnImportCSV.Size = new Size(75, 57);
            btnImportCSV.TabIndex = 9;
            btnImportCSV.Text = "Imp. CSV";
            btnImportCSV.TextImageRelation = TextImageRelation.ImageAboveText;
            btnImportCSV.UseVisualStyleBackColor = true;
            // 
            // btnExportaLivrosJson
            // 
            btnExportaLivrosJson.AutoSize = true;
            btnExportaLivrosJson.Image = Properties.Resources.json_download_32px;
            btnExportaLivrosJson.Location = new Point(556, 19);
            btnExportaLivrosJson.Name = "btnExportaLivrosJson";
            btnExportaLivrosJson.Size = new Size(75, 57);
            btnExportaLivrosJson.TabIndex = 8;
            btnExportaLivrosJson.Text = "Exp. JSON";
            btnExportaLivrosJson.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExportaLivrosJson.UseVisualStyleBackColor = true;
            // 
            // btn_AddLivro
            // 
            btn_AddLivro.AutoSize = true;
            btn_AddLivro.Image = Properties.Resources.add_book_48px;
            btn_AddLivro.Location = new Point(313, 11);
            btn_AddLivro.Name = "btn_AddLivro";
            btn_AddLivro.Size = new Size(75, 73);
            btn_AddLivro.TabIndex = 6;
            btn_AddLivro.Text = "Adicionar";
            btn_AddLivro.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_AddLivro.UseVisualStyleBackColor = true;
            btn_AddLivro.Click += btn_adicionarLivro_Click;
            // 
            // txtBoxPaginas
            // 
            txtBoxPaginas.Location = new Point(149, 48);
            txtBoxPaginas.Name = "txtBoxPaginas";
            txtBoxPaginas.PasswordChar = '*';
            txtBoxPaginas.Size = new Size(39, 23);
            txtBoxPaginas.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 51);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 4;
            label5.Text = "Pgs";
            // 
            // txtBoxCod
            // 
            txtBoxCod.Location = new Point(49, 48);
            txtBoxCod.Name = "txtBoxCod";
            txtBoxCod.Size = new Size(62, 23);
            txtBoxCod.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 51);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 2;
            label7.Text = "Cód";
            // 
            // txtBoxLivro
            // 
            txtBoxLivro.Location = new Point(49, 19);
            txtBoxLivro.Name = "txtBoxLivro";
            txtBoxLivro.Size = new Size(246, 23);
            txtBoxLivro.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 22);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 0;
            label8.Text = "Livro";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvLivros);
            groupBox5.Location = new Point(6, 100);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(640, 295);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            // 
            // dgvLivros
            // 
            dgvLivros.AllowUserToAddRows = false;
            dgvLivros.AllowUserToDeleteRows = false;
            dgvLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLivros.Columns.AddRange(new DataGridViewColumn[] { IdCol, LivroCol, NumPagCol, ValorCol });
            dgvLivros.Location = new Point(6, 17);
            dgvLivros.Name = "dgvLivros";
            dgvLivros.ReadOnly = true;
            dgvLivros.RowHeadersVisible = false;
            dgvLivros.RowTemplate.Height = 25;
            dgvLivros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLivros.Size = new Size(628, 272);
            dgvLivros.TabIndex = 0;
            // 
            // IdCol
            // 
            IdCol.DataPropertyName = "Paginas";
            IdCol.HeaderText = "ID";
            IdCol.MinimumWidth = 58;
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Width = 58;
            // 
            // LivroCol
            // 
            LivroCol.DataPropertyName = "Livro";
            LivroCol.HeaderText = "Livro";
            LivroCol.Name = "LivroCol";
            LivroCol.ReadOnly = true;
            LivroCol.Width = 350;
            // 
            // NumPagCol
            // 
            NumPagCol.DataPropertyName = "Valor";
            NumPagCol.HeaderText = "Num. Páginas";
            NumPagCol.Name = "NumPagCol";
            NumPagCol.ReadOnly = true;
            NumPagCol.Width = 150;
            // 
            // ValorCol
            // 
            ValorCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ValorCol.DataPropertyName = "Codigo";
            ValorCol.HeaderText = "Valor";
            ValorCol.MinimumWidth = 100;
            ValorCol.Name = "ValorCol";
            ValorCol.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(655, 401);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Empréstimos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvEmprestimos);
            groupBox4.Location = new Point(3, 97);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(640, 295);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // dgvEmprestimos
            // 
            dgvEmprestimos.AllowUserToAddRows = false;
            dgvEmprestimos.AllowUserToDeleteRows = false;
            dgvEmprestimos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprestimos.Columns.AddRange(new DataGridViewColumn[] { Usuario, Livro });
            dgvEmprestimos.Location = new Point(6, 17);
            dgvEmprestimos.Name = "dgvEmprestimos";
            dgvEmprestimos.ReadOnly = true;
            dgvEmprestimos.RowHeadersVisible = false;
            dgvEmprestimos.RowTemplate.Height = 25;
            dgvEmprestimos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmprestimos.Size = new Size(628, 272);
            dgvEmprestimos.TabIndex = 0;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 350;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Width = 350;
            // 
            // Livro
            // 
            Livro.HeaderText = "Livro";
            Livro.MinimumWidth = 300;
            Livro.Name = "Livro";
            Livro.ReadOnly = true;
            Livro.Width = 300;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxLivros);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(comboBoxUsuario);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(btnUser_Livro);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(3, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(640, 85);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // comboBoxLivros
            // 
            comboBoxLivros.FormattingEnabled = true;
            comboBoxLivros.Location = new Point(63, 48);
            comboBoxLivros.Name = "comboBoxLivros";
            comboBoxLivros.Size = new Size(232, 23);
            comboBoxLivros.TabIndex = 12;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Image = Properties.Resources.import_csv_32px;
            button4.Location = new Point(468, 19);
            button4.Name = "button4";
            button4.Size = new Size(75, 57);
            button4.TabIndex = 9;
            button4.Text = "Imp. CSV";
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 51);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "Livros";
            // 
            // comboBoxUsuario
            // 
            comboBoxUsuario.FormattingEnabled = true;
            comboBoxUsuario.Location = new Point(63, 19);
            comboBoxUsuario.Name = "comboBoxUsuario";
            comboBoxUsuario.Size = new Size(232, 23);
            comboBoxUsuario.TabIndex = 10;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Image = Properties.Resources.json_download_32px;
            button5.Location = new Point(549, 19);
            button5.Name = "button5";
            button5.Size = new Size(75, 57);
            button5.TabIndex = 8;
            button5.Text = "Exp. JSON";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Image = Properties.Resources.export_csv_32px;
            button6.Location = new Point(387, 19);
            button6.Name = "button6";
            button6.Size = new Size(75, 57);
            button6.TabIndex = 7;
            button6.Text = "Exp. CSV";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = true;
            // 
            // btnUser_Livro
            // 
            btnUser_Livro.AutoSize = true;
            btnUser_Livro.Image = Properties.Resources.add_book_48px;
            btnUser_Livro.Location = new Point(306, 19);
            btnUser_Livro.Name = "btnUser_Livro";
            btnUser_Livro.Size = new Size(75, 73);
            btnUser_Livro.TabIndex = 6;
            btnUser_Livro.Text = "Adicionar";
            btnUser_Livro.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUser_Livro.UseVisualStyleBackColor = true;
            btnUser_Livro.Click += btnAssociarLivro_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 22);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 0;
            label6.Text = "Usuarios";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button7
            // 
            button7.Image = Properties.Resources.cancel_32px;
            button7.Location = new Point(636, 5);
            button7.Name = "button7";
            button7.Size = new Size(24, 23);
            button7.TabIndex = 3;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // ControleDeBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 457);
            Controls.Add(button7);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ControleDeBiblioteca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Biblioteca";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLivros).EndInit();
            tabPage3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmprestimos).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox2;
        private TextBox txbSenha;
        private Label label3;
        private TextBox txbLogin;
        private Label label2;
        private TextBox txbNome;
        private Label label1;
        private Button btnAdicionar;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Senha;
        private Button btnImport;
        private Button btnExpJson;
        private Button btnExport;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox3;
        private ComboBox comboBoxUsuario;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnUser_Livro;
        private Label label6;
        private GroupBox groupBox6;
        private TextBox txtBoxValor;
        private Label label9;
        private Button btnImportCSV;
        private Button btnExportaLivrosJson;
        private Button btnExportLivrosCSV;
        private Button btn_AddLivro;
        private TextBox txtBoxPaginas;
        private Label label5;
        private TextBox txtBoxCod;
        private Label label7;
        private TextBox txtBoxLivro;
        private Label label8;
        private GroupBox groupBox5;
        private DataGridView dgvLivros;
        private GroupBox groupBox4;
        private DataGridView dgvEmprestimos;
        private ComboBox comboBoxLivros;
        private Label label4;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn LivroCol;
        private DataGridViewTextBoxColumn NumPagCol;
        private DataGridViewTextBoxColumn ValorCol;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Livro;
        private Button button7;
    }
}