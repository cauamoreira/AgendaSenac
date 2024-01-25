namespace AgendaSenac
{
    partial class Agenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            cadastrarCursoToolStripMenuItem = new ToolStripMenuItem();
            controleToolStripMenuItem = new ToolStripMenuItem();
            acessoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnDeixar = new Button();
            btnExport = new Button();
            btnEntrar = new Button();
            btnLimpar = new Button();
            btnMudar = new Button();
            btnApagar = new Button();
            clbDias = new CheckedListBox();
            label2 = new Label();
            txtPesquisar = new TextBox();
            gridCurso = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ColunaCurso = new DataGridViewTextBoxColumn();
            ColunaCursoInicio = new DataGridViewTextBoxColumn();
            ColunaCursoFim = new DataGridViewTextBoxColumn();
            ColunaCursoDias = new DataGridViewTextBoxColumn();
            ColunaCursoHorario = new DataGridViewTextBoxColumn();
            ColunaCursoMeta = new DataGridViewTextBoxColumn();
            ColunaCursoRealizado = new DataGridViewTextBoxColumn();
            ColunaCursoValor = new DataGridViewTextBoxColumn();
            ColunaCursoTurma = new DataGridViewTextBoxColumn();
            ColunaCursoSala = new DataGridViewTextBoxColumn();
            btnSair = new Button();
            cmbHorario = new ComboBox();
            btnExportar = new Button();
            mtbValor = new MaskedTextBox();
            btnAdicionar = new Button();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            limparToolStripMenuItem = new ToolStripMenuItem();
            deletarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarUsuárioToolStripMenuItem1 = new ToolStripMenuItem();
            btnLimparCampos = new Button();
            lbl = new Label();
            txtId = new TextBox();
            btnAlterar = new Button();
            label5 = new Label();
            btnExcluir = new Button();
            dtpFim = new DateTimePicker();
            label3 = new Label();
            dtpInicio = new DateTimePicker();
            label6 = new Label();
            cmbCurso = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            txtMeta = new TextBox();
            label4 = new Label();
            txtSala = new TextBox();
            label9 = new Label();
            txtTurma = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtRealizado = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCurso).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cadastrarCursoToolStripMenuItem
            // 
            cadastrarCursoToolStripMenuItem.Image = (Image)resources.GetObject("cadastrarCursoToolStripMenuItem.Image");
            cadastrarCursoToolStripMenuItem.Name = "cadastrarCursoToolStripMenuItem";
            cadastrarCursoToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            cadastrarCursoToolStripMenuItem.Size = new Size(204, 22);
            cadastrarCursoToolStripMenuItem.Text = "Cadastrar curso";
            cadastrarCursoToolStripMenuItem.Click += cadastrarCursoToolStripMenuItem_Click;
            // 
            // controleToolStripMenuItem
            // 
            controleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acessoToolStripMenuItem });
            controleToolStripMenuItem.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point);
            controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            controleToolStripMenuItem.Size = new Size(64, 20);
            controleToolStripMenuItem.Text = "Controle";
            // 
            // acessoToolStripMenuItem
            // 
            acessoToolStripMenuItem.Image = (Image)resources.GetObject("acessoToolStripMenuItem.Image");
            acessoToolStripMenuItem.Name = "acessoToolStripMenuItem";
            acessoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            acessoToolStripMenuItem.Size = new Size(156, 22);
            acessoToolStripMenuItem.Text = "Acesso";
            acessoToolStripMenuItem.Click += acessoToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnDeixar);
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(btnMudar);
            panel1.Controls.Add(btnApagar);
            panel1.Controls.Add(clbDias);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPesquisar);
            panel1.Controls.Add(gridCurso);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(cmbHorario);
            panel1.Controls.Add(btnExportar);
            panel1.Controls.Add(mtbValor);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(btnLimparCampos);
            panel1.Controls.Add(lbl);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(dtpFim);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpInicio);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbCurso);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMeta);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSala);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtTurma);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtRealizado);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(1680, 1050);
            panel1.MinimumSize = new Size(900, 600);
            panel1.Name = "panel1";
            panel1.Size = new Size(1217, 663);
            panel1.TabIndex = 1;
            // 
            // btnDeixar
            // 
            btnDeixar.Anchor = AnchorStyles.Bottom;
            btnDeixar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeixar.Location = new Point(992, 607);
            btnDeixar.Name = "btnDeixar";
            btnDeixar.Size = new Size(96, 30);
            btnDeixar.TabIndex = 43;
            btnDeixar.Text = "Sair";
            btnDeixar.UseVisualStyleBackColor = true;
            btnDeixar.Click += btnDeixar_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom;
            btnExport.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.Location = new Point(822, 607);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(96, 30);
            btnExport.TabIndex = 42;
            btnExport.Text = "Exportar";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Bottom;
            btnEntrar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.Location = new Point(158, 607);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(96, 30);
            btnEntrar.TabIndex = 38;
            btnEntrar.Text = "Adicionar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnAdicionar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Bottom;
            btnLimpar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(324, 607);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(96, 30);
            btnLimpar.TabIndex = 39;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnMudar
            // 
            btnMudar.Anchor = AnchorStyles.Bottom;
            btnMudar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMudar.Location = new Point(654, 607);
            btnMudar.Name = "btnMudar";
            btnMudar.Size = new Size(96, 30);
            btnMudar.TabIndex = 41;
            btnMudar.Text = "Alterar";
            btnMudar.UseVisualStyleBackColor = true;
            btnMudar.Click += btnMudar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Anchor = AnchorStyles.Bottom;
            btnApagar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnApagar.Location = new Point(485, 607);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(96, 30);
            btnApagar.TabIndex = 40;
            btnApagar.Text = "Excluir";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // clbDias
            // 
            clbDias.FormattingEnabled = true;
            clbDias.Location = new Point(729, 111);
            clbDias.Margin = new Padding(3, 2, 3, 2);
            clbDias.Name = "clbDias";
            clbDias.Size = new Size(215, 22);
            clbDias.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(962, 33);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 37;
            label2.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = SystemColors.HighlightText;
            txtPesquisar.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesquisar.Location = new Point(962, 51);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(215, 25);
            txtPesquisar.TabIndex = 36;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // gridCurso
            // 
            gridCurso.AllowUserToAddRows = false;
            gridCurso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gridCurso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridCurso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridCurso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCurso.BackgroundColor = Color.LightGray;
            gridCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCurso.Columns.AddRange(new DataGridViewColumn[] { Column1, ColunaCurso, ColunaCursoInicio, ColunaCursoFim, ColunaCursoDias, ColunaCursoHorario, ColunaCursoMeta, ColunaCursoRealizado, ColunaCursoValor, ColunaCursoTurma, ColunaCursoSala });
            gridCurso.Location = new Point(0, 192);
            gridCurso.MaximumSize = new Size(1920, 900);
            gridCurso.Name = "gridCurso";
            gridCurso.ReadOnly = true;
            gridCurso.RowHeadersWidth = 51;
            gridCurso.RowTemplate.Height = 25;
            gridCurso.Size = new Size(1214, 383);
            gridCurso.TabIndex = 17;
            gridCurso.CellClick += gridCurso_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "#";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 39;
            // 
            // ColunaCurso
            // 
            ColunaCurso.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColunaCurso.HeaderText = "Curso";
            ColunaCurso.MinimumWidth = 6;
            ColunaCurso.Name = "ColunaCurso";
            ColunaCurso.ReadOnly = true;
            ColunaCurso.Width = 63;
            // 
            // ColunaCursoInicio
            // 
            ColunaCursoInicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            ColunaCursoInicio.DefaultCellStyle = dataGridViewCellStyle2;
            ColunaCursoInicio.HeaderText = "Início";
            ColunaCursoInicio.MinimumWidth = 6;
            ColunaCursoInicio.Name = "ColunaCursoInicio";
            ColunaCursoInicio.ReadOnly = true;
            // 
            // ColunaCursoFim
            // 
            ColunaCursoFim.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            ColunaCursoFim.DefaultCellStyle = dataGridViewCellStyle3;
            ColunaCursoFim.HeaderText = "Fim";
            ColunaCursoFim.MinimumWidth = 6;
            ColunaCursoFim.Name = "ColunaCursoFim";
            ColunaCursoFim.ReadOnly = true;
            // 
            // ColunaCursoDias
            // 
            ColunaCursoDias.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoDias.HeaderText = "Dias";
            ColunaCursoDias.MinimumWidth = 6;
            ColunaCursoDias.Name = "ColunaCursoDias";
            ColunaCursoDias.ReadOnly = true;
            // 
            // ColunaCursoHorario
            // 
            ColunaCursoHorario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoHorario.HeaderText = "Horário";
            ColunaCursoHorario.MinimumWidth = 6;
            ColunaCursoHorario.Name = "ColunaCursoHorario";
            ColunaCursoHorario.ReadOnly = true;
            // 
            // ColunaCursoMeta
            // 
            ColunaCursoMeta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoMeta.HeaderText = "Meta de Alunos";
            ColunaCursoMeta.MinimumWidth = 6;
            ColunaCursoMeta.Name = "ColunaCursoMeta";
            ColunaCursoMeta.ReadOnly = true;
            // 
            // ColunaCursoRealizado
            // 
            ColunaCursoRealizado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoRealizado.HeaderText = "Matriculados";
            ColunaCursoRealizado.MinimumWidth = 6;
            ColunaCursoRealizado.Name = "ColunaCursoRealizado";
            ColunaCursoRealizado.ReadOnly = true;
            // 
            // ColunaCursoValor
            // 
            ColunaCursoValor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoValor.HeaderText = "Valor";
            ColunaCursoValor.MinimumWidth = 6;
            ColunaCursoValor.Name = "ColunaCursoValor";
            ColunaCursoValor.ReadOnly = true;
            // 
            // ColunaCursoTurma
            // 
            ColunaCursoTurma.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoTurma.HeaderText = "Turma";
            ColunaCursoTurma.MinimumWidth = 6;
            ColunaCursoTurma.Name = "ColunaCursoTurma";
            ColunaCursoTurma.ReadOnly = true;
            // 
            // ColunaCursoSala
            // 
            ColunaCursoSala.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCursoSala.HeaderText = "Sala";
            ColunaCursoSala.MinimumWidth = 6;
            ColunaCursoSala.Name = "ColunaCursoSala";
            ColunaCursoSala.ReadOnly = true;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom;
            btnSair.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(1478, 1198);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(96, 30);
            btnSair.TabIndex = 16;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // cmbHorario
            // 
            cmbHorario.BackColor = SystemColors.HighlightText;
            cmbHorario.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbHorario.FormattingEnabled = true;
            cmbHorario.Items.AddRange(new object[] { "7:30 às 12:00", "8:00 às 12:00", "9:15 às 12:15", "13:30 às 17:30", "14:00 às 17:00", "14:00 às 17:30", "18:00 às 22:30", "19:00 às 22:30" });
            cmbHorario.Location = new Point(962, 110);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(215, 26);
            cmbHorario.TabIndex = 5;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Bottom;
            btnExportar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportar.Location = new Point(1308, 1198);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(96, 30);
            btnExportar.TabIndex = 15;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // mtbValor
            // 
            mtbValor.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mtbValor.Location = new Point(497, 161);
            mtbValor.Mask = "$00,000,00";
            mtbValor.Name = "mtbValor";
            mtbValor.Size = new Size(215, 25);
            mtbValor.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Bottom;
            btnAdicionar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(644, 1198);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(96, 30);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, cadastrarToolStripMenuItem, controleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(245, 24);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, exportarToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(59, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Image = (Image)resources.GetObject("adicionarToolStripMenuItem.Image");
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            adicionarToolStripMenuItem.Size = new Size(164, 22);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.Image = (Image)resources.GetObject("exportarToolStripMenuItem.Image");
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exportarToolStripMenuItem.Size = new Size(164, 22);
            exportarToolStripMenuItem.Text = "Exportar";
            exportarToolStripMenuItem.Click += exportarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = (Image)resources.GetObject("sairToolStripMenuItem.Image");
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            sairToolStripMenuItem.Size = new Size(164, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { limparToolStripMenuItem, deletarToolStripMenuItem });
            editarToolStripMenuItem.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point);
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // limparToolStripMenuItem
            // 
            limparToolStripMenuItem.Image = (Image)resources.GetObject("limparToolStripMenuItem.Image");
            limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            limparToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            limparToolStripMenuItem.Size = new Size(184, 22);
            limparToolStripMenuItem.Text = "Limpar";
            limparToolStripMenuItem.Click += limparToolStripMenuItem_Click;
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.Image = (Image)resources.GetObject("deletarToolStripMenuItem.Image");
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.Delete;
            deletarToolStripMenuItem.Size = new Size(184, 22);
            deletarToolStripMenuItem.Text = "Excluir";
            deletarToolStripMenuItem.Click += deletarToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarCursoToolStripMenuItem, cadastrarUsuárioToolStripMenuItem1 });
            cadastrarToolStripMenuItem.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(65, 20);
            cadastrarToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastrarUsuárioToolStripMenuItem1
            // 
            cadastrarUsuárioToolStripMenuItem1.Image = (Image)resources.GetObject("cadastrarUsuárioToolStripMenuItem1.Image");
            cadastrarUsuárioToolStripMenuItem1.Name = "cadastrarUsuárioToolStripMenuItem1";
            cadastrarUsuárioToolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.E;
            cadastrarUsuárioToolStripMenuItem1.Size = new Size(204, 22);
            cadastrarUsuárioToolStripMenuItem1.Text = "Cadastrar usuário";
            cadastrarUsuárioToolStripMenuItem1.Click += cadastrarUsuárioToolStripMenuItem1_Click;
            // 
            // btnLimparCampos
            // 
            btnLimparCampos.Anchor = AnchorStyles.Bottom;
            btnLimparCampos.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimparCampos.Location = new Point(810, 1198);
            btnLimparCampos.Name = "btnLimparCampos";
            btnLimparCampos.Size = new Size(96, 30);
            btnLimparCampos.TabIndex = 12;
            btnLimparCampos.Text = "Limpar";
            btnLimparCampos.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(25, 51);
            lbl.Name = "lbl";
            lbl.Size = new Size(26, 18);
            lbl.TabIndex = 35;
            lbl.Text = "ID:";
            lbl.Visible = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(54, 48);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(150, 23);
            txtId.TabIndex = 34;
            txtId.Visible = false;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Bottom;
            btnAlterar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.Location = new Point(1140, 1198);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(96, 30);
            btnAlterar.TabIndex = 14;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(729, 94);
            label5.Name = "label5";
            label5.Size = new Size(40, 18);
            label5.TabIndex = 4;
            label5.Text = "Dias:";
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom;
            btnExcluir.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(971, 1198);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 30);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dtpFim
            // 
            dtpFim.CalendarMonthBackground = SystemColors.HighlightText;
            dtpFim.CustomFormat = "dd-MM-yyyy";
            dtpFim.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.Location = new Point(497, 111);
            dtpFim.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dtpFim.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(215, 25);
            dtpFim.TabIndex = 3;
            dtpFim.Value = new DateTime(2024, 1, 8, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(264, 93);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 0;
            label3.Text = "Início:";
            // 
            // dtpInicio
            // 
            dtpInicio.CalendarMonthBackground = SystemColors.HighlightText;
            dtpInicio.CustomFormat = "dd-MM-yyyy";
            dtpInicio.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(265, 111);
            dtpInicio.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dtpInicio.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(215, 25);
            dtpInicio.TabIndex = 2;
            dtpInicio.Value = new DateTime(2024, 1, 8, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 143);
            label6.Name = "label6";
            label6.Size = new Size(116, 18);
            label6.TabIndex = 5;
            label6.Text = "Meta de Alunos:";
            // 
            // cmbCurso
            // 
            cmbCurso.BackColor = SystemColors.HighlightText;
            cmbCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Items.AddRange(new object[] { "Tecnologia da Informação" });
            cmbCurso.Location = new Point(26, 110);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(215, 26);
            cmbCurso.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(262, 143);
            label7.Name = "label7";
            label7.Size = new Size(99, 18);
            label7.TabIndex = 6;
            label7.Text = "Matriculados:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 91);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 0;
            label1.Text = "Curso:";
            // 
            // txtMeta
            // 
            txtMeta.BackColor = SystemColors.HighlightText;
            txtMeta.BorderStyle = BorderStyle.FixedSingle;
            txtMeta.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMeta.Location = new Point(26, 161);
            txtMeta.Name = "txtMeta";
            txtMeta.Size = new Size(215, 25);
            txtMeta.TabIndex = 6;
            txtMeta.KeyPress += NumbersOnly;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(495, 94);
            label4.Name = "label4";
            label4.Size = new Size(36, 18);
            label4.TabIndex = 21;
            label4.Text = "Fim:";
            // 
            // txtSala
            // 
            txtSala.BackColor = SystemColors.HighlightText;
            txtSala.BorderStyle = BorderStyle.FixedSingle;
            txtSala.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSala.Location = new Point(962, 161);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(215, 25);
            txtSala.TabIndex = 10;
            txtSala.KeyPress += NumbersOnly;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(494, 144);
            label9.Name = "label9";
            label9.Size = new Size(48, 18);
            label9.TabIndex = 8;
            label9.Text = "Valor:";
            // 
            // txtTurma
            // 
            txtTurma.BackColor = SystemColors.HighlightText;
            txtTurma.BorderStyle = BorderStyle.FixedSingle;
            txtTurma.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTurma.Location = new Point(729, 161);
            txtTurma.Name = "txtTurma";
            txtTurma.Size = new Size(215, 25);
            txtTurma.TabIndex = 9;
            txtTurma.KeyPress += NumbersOnly;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(960, 93);
            label10.Name = "label10";
            label10.Size = new Size(65, 18);
            label10.TabIndex = 9;
            label10.Text = "Horário:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(725, 144);
            label11.Name = "label11";
            label11.Size = new Size(55, 18);
            label11.TabIndex = 10;
            label11.Text = "Turma:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(959, 144);
            label12.Name = "label12";
            label12.Size = new Size(40, 18);
            label12.TabIndex = 11;
            label12.Text = "Sala:";
            // 
            // txtRealizado
            // 
            txtRealizado.BackColor = SystemColors.HighlightText;
            txtRealizado.BorderStyle = BorderStyle.FixedSingle;
            txtRealizado.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRealizado.Location = new Point(265, 161);
            txtRealizado.Name = "txtRealizado";
            txtRealizado.Size = new Size(215, 25);
            txtRealizado.TabIndex = 7;
            txtRealizado.KeyPress += NumbersOnly;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1217, 663);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 594);
            Name = "Agenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGENDA DE CURSOS";
            FormClosing += Agenda_FormClosing;
            Load += Agenda_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCurso).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem cadastrarCursoToolStripMenuItem;
        private ToolStripMenuItem controleToolStripMenuItem;
        private ToolStripMenuItem acessoToolStripMenuItem;
        private Panel panel1;
        private CheckedListBox clbDias;
        private Label label2;
        private TextBox txtPesquisar;
        private DataGridView gridCurso;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColunaCurso;
        private DataGridViewTextBoxColumn ColunaCursoInicio;
        private DataGridViewTextBoxColumn ColunaCursoFim;
        private DataGridViewTextBoxColumn ColunaCursoDias;
        private DataGridViewTextBoxColumn ColunaCursoHorario;
        private DataGridViewTextBoxColumn ColunaCursoMeta;
        private DataGridViewTextBoxColumn ColunaCursoRealizado;
        private DataGridViewTextBoxColumn ColunaCursoValor;
        private DataGridViewTextBoxColumn ColunaCursoTurma;
        private DataGridViewTextBoxColumn ColunaCursoSala;
        private Button btnSair;
        private ComboBox cmbHorario;
        private Button btnExportar;
        private MaskedTextBox mtbValor;
        private Button btnAdicionar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem limparToolStripMenuItem;
        private ToolStripMenuItem deletarToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem cadastrarUsuárioToolStripMenuItem1;
        private Button btnLimparCampos;
        private Label lbl;
        private TextBox txtId;
        private Button btnAlterar;
        private Label label5;
        private Button btnExcluir;
        private DateTimePicker dtpFim;
        private Label label3;
        private DateTimePicker dtpInicio;
        private Label label6;
        private ComboBox cmbCurso;
        private Label label7;
        private Label label1;
        private TextBox txtMeta;
        private Label label4;
        private TextBox txtSala;
        private Label label9;
        private TextBox txtTurma;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtRealizado;
        private Button btnDeixar;
        private Button btnExport;
        private Button btnEntrar;
        private Button btnLimpar;
        private Button btnMudar;
        private Button btnApagar;
    }
}