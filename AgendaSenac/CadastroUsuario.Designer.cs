namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class CadastroUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSenha = new TextBox();
            txtCpf = new TextBox();
            txtUsuario = new TextBox();
            txtId = new TextBox();
            chkAtivo = new CheckBox();
            chkAdministrador = new CheckBox();
            btnAdicionarUsuario = new Button();
            btnSair = new Button();
            btnAlterar = new Button();
            GridConsultarUsuario = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnExcluir = new Button();
            panel1 = new Panel();
            dtpDataNascimento = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)GridConsultarUsuario).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(80, 22);
            label1.Name = "label1";
            label1.Size = new Size(26, 18);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(109, 52);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 1;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(410, 52);
            label3.Name = "label3";
            label3.Size = new Size(37, 18);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(108, 101);
            label4.Name = "label4";
            label4.Size = new Size(147, 18);
            label4.TabIndex = 3;
            label4.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(410, 102);
            label5.Name = "label5";
            label5.Size = new Size(52, 18);
            label5.TabIndex = 4;
            label5.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.HighlightText;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSenha.Location = new Point(410, 121);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(199, 25);
            txtSenha.TabIndex = 3;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // txtCpf
            // 
            txtCpf.BackColor = SystemColors.HighlightText;
            txtCpf.BorderStyle = BorderStyle.FixedSingle;
            txtCpf.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtCpf.Location = new Point(410, 71);
            txtCpf.Margin = new Padding(3, 2, 3, 2);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(199, 25);
            txtCpf.TabIndex = 1;
            txtCpf.TextChanged += txtCpf_TextChanged;
            txtCpf.KeyDown += txtCpf_KeyDown;
            txtCpf.KeyPress += txtCpf_KeyPress;
            txtCpf.Leave += txtCpf_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.HighlightText;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(109, 71);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(202, 25);
            txtUsuario.TabIndex = 0;
            txtUsuario.KeyPress += TextOnly;
            // 
            // txtId
            // 
            txtId.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(113, 19);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(59, 25);
            txtId.TabIndex = 7;
            txtId.TextAlign = HorizontalAlignment.Center;
            txtId.Visible = false;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chkAtivo.Location = new Point(109, 151);
            chkAtivo.Margin = new Padding(3, 2, 3, 2);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(63, 22);
            chkAtivo.TabIndex = 5;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // chkAdministrador
            // 
            chkAdministrador.AutoSize = true;
            chkAdministrador.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chkAdministrador.Location = new Point(195, 151);
            chkAdministrador.Margin = new Padding(3, 2, 3, 2);
            chkAdministrador.Name = "chkAdministrador";
            chkAdministrador.Size = new Size(124, 22);
            chkAdministrador.TabIndex = 4;
            chkAdministrador.Text = "Administrador";
            chkAdministrador.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarUsuario
            // 
            btnAdicionarUsuario.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarUsuario.Location = new Point(50, 441);
            btnAdicionarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            btnAdicionarUsuario.Size = new Size(96, 30);
            btnAdicionarUsuario.TabIndex = 6;
            btnAdicionarUsuario.Text = "Adicionar";
            btnAdicionarUsuario.UseVisualStyleBackColor = true;
            btnAdicionarUsuario.Click += btnSalvarUsuario_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(542, 441);
            btnSair.Margin = new Padding(3, 2, 3, 2);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(96, 30);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.Location = new Point(203, 441);
            btnAlterar.Margin = new Padding(3, 2, 3, 2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(96, 30);
            btnAlterar.TabIndex = 10;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // GridConsultarUsuario
            // 
            GridConsultarUsuario.AllowUserToAddRows = false;
            GridConsultarUsuario.AllowUserToDeleteRows = false;
            GridConsultarUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridConsultarUsuario.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7, Column6 });
            GridConsultarUsuario.GridColor = SystemColors.ActiveCaption;
            GridConsultarUsuario.Location = new Point(1, 177);
            GridConsultarUsuario.Margin = new Padding(3, 2, 3, 2);
            GridConsultarUsuario.Name = "GridConsultarUsuario";
            GridConsultarUsuario.ReadOnly = true;
            GridConsultarUsuario.RowHeadersWidth = 51;
            GridConsultarUsuario.RowTemplate.Height = 29;
            GridConsultarUsuario.ShowCellToolTips = false;
            GridConsultarUsuario.Size = new Size(702, 225);
            GridConsultarUsuario.StandardTab = true;
            GridConsultarUsuario.TabIndex = 8;
            GridConsultarUsuario.CellClick += GridConsultarUsuario_CellClick;
            GridConsultarUsuario.CellFormatting += GridConsultarUsuario_CellFormatting;
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
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Usuário";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "CPF";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            Column4.DefaultCellStyle = dataGridViewCellStyle1;
            Column4.HeaderText = "Data de Nascimento";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Senha";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Ativo";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Administrador";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(366, 441);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 30);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dtpDataNascimento);
            panel1.Controls.Add(GridConsultarUsuario);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(chkAdministrador);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(chkAtivo);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnAdicionarUsuario);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-2, -2);
            panel1.MaximumSize = new Size(1920, 1080);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 541);
            panel1.TabIndex = 13;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Custom;
            dtpDataNascimento.Location = new Point(109, 121);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(202, 23);
            dtpDataNascimento.TabIndex = 15;
            dtpDataNascimento.Value = new DateTime(2024, 1, 13, 0, 0, 0, 0);
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(703, 537);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "CadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO DE USUÁRIO";
            FormClosing += CadastroUsuario_FormClosing;
            Load += FrmCadastroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)GridConsultarUsuario).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;

        private TextBox txtSenha;
        private TextBox txtCpf;
        private TextBox txtUsuario;
        private TextBox txtId;
        private CheckBox chkAtivo;
        private CheckBox chkAdministrador;
        private Button btnAdicionarUsuario;
        private Button btnSair;
        private Button btnAlterar;
        private DataGridView GridConsultarUsuario;
        private Button btnExcluir;
        private Panel panel1;
        private DateTimePicker dtpDataNascimento;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
    }
}