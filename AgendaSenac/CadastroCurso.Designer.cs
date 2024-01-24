namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class CadastroCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCurso));
            lblId = new Label();
            txtId = new TextBox();
            txtCadastroCurso = new TextBox();
            label = new Label();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            GridViewCadastroCurso = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            btnAlterar = new Button();
            panel1 = new Panel();
            btnExcluirCurso = new Button();
            btnAlterarCurso = new Button();
            btnSairCurso = new Button();
            btnAdicionarCurso = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridViewCadastroCurso).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(645, 252);
            lblId.Name = "lblId";
            lblId.Size = new Size(26, 18);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            lblId.Visible = false;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Window;
            txtId.Location = new Point(671, 245);
            txtId.Margin = new Padding(3, 5, 3, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(26, 26);
            txtId.TabIndex = 0;
            txtId.Visible = false;
            // 
            // txtCadastroCurso
            // 
            txtCadastroCurso.BackColor = SystemColors.HighlightText;
            txtCadastroCurso.BorderStyle = BorderStyle.FixedSingle;
            txtCadastroCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCadastroCurso.Location = new Point(1, 248);
            txtCadastroCurso.Margin = new Padding(3, 5, 3, 5);
            txtCadastroCurso.Name = "txtCadastroCurso";
            txtCadastroCurso.Size = new Size(312, 25);
            txtCadastroCurso.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(2, 230);
            label.Name = "label";
            label.Size = new Size(117, 18);
            label.TabIndex = 0;
            label.Text = "Cadastrar curso:";
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(433, 764);
            btnExcluir.Margin = new Padding(3, 5, 3, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 40);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(42, 762);
            btnAdicionar.Margin = new Padding(3, 5, 3, 5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(110, 40);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(641, 762);
            btnSair.Margin = new Padding(3, 5, 3, 5);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(110, 40);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(190, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // GridViewCadastroCurso
            // 
            GridViewCadastroCurso.AllowUserToAddRows = false;
            GridViewCadastroCurso.AllowUserToDeleteRows = false;
            GridViewCadastroCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewCadastroCurso.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1 });
            GridViewCadastroCurso.Location = new Point(-1, 275);
            GridViewCadastroCurso.Margin = new Padding(3, 5, 3, 5);
            GridViewCadastroCurso.Name = "GridViewCadastroCurso";
            GridViewCadastroCurso.ReadOnly = true;
            GridViewCadastroCurso.RowHeadersWidth = 51;
            GridViewCadastroCurso.RowTemplate.Height = 25;
            GridViewCadastroCurso.Size = new Size(706, 246);
            GridViewCadastroCurso.TabIndex = 0;
            GridViewCadastroCurso.CellClick += GridViewCadastroCurso_CellClick;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "#";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 42;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Curso";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.Location = new Point(233, 764);
            btnAlterar.Margin = new Padding(3, 5, 3, 5);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(110, 40);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnExcluirCurso);
            panel1.Controls.Add(btnAlterarCurso);
            panel1.Controls.Add(btnSairCurso);
            panel1.Controls.Add(btnAdicionarCurso);
            panel1.Controls.Add(GridViewCadastroCurso);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(txtCadastroCurso);
            panel1.Controls.Add(label);
            panel1.Controls.Add(btnExcluir);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.Desktop;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.MaximumSize = new Size(2468, 1655);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 620);
            panel1.TabIndex = 0;
            // 
            // btnExcluirCurso
            // 
            btnExcluirCurso.Anchor = AnchorStyles.Bottom;
            btnExcluirCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluirCurso.Location = new Point(370, 549);
            btnExcluirCurso.Name = "btnExcluirCurso";
            btnExcluirCurso.Size = new Size(96, 30);
            btnExcluirCurso.TabIndex = 4;
            btnExcluirCurso.Text = "Excluir";
            btnExcluirCurso.UseVisualStyleBackColor = true;
            btnExcluirCurso.Click += btnExcluirCurso_Click;
            // 
            // btnAlterarCurso
            // 
            btnAlterarCurso.Anchor = AnchorStyles.Bottom;
            btnAlterarCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterarCurso.Location = new Point(206, 549);
            btnAlterarCurso.Name = "btnAlterarCurso";
            btnAlterarCurso.Size = new Size(96, 30);
            btnAlterarCurso.TabIndex = 3;
            btnAlterarCurso.Text = "Alterar";
            btnAlterarCurso.UseVisualStyleBackColor = true;
            btnAlterarCurso.Click += btnAlterarCurso_Click;
            // 
            // btnSairCurso
            // 
            btnSairCurso.Anchor = AnchorStyles.Bottom;
            btnSairCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSairCurso.Location = new Point(535, 549);
            btnSairCurso.Name = "btnSairCurso";
            btnSairCurso.Size = new Size(96, 30);
            btnSairCurso.TabIndex = 5;
            btnSairCurso.Text = "Sair";
            btnSairCurso.UseVisualStyleBackColor = true;
            btnSairCurso.Click += btnSairCurso_Click;
            // 
            // btnAdicionarCurso
            // 
            btnAdicionarCurso.Anchor = AnchorStyles.Bottom;
            btnAdicionarCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarCurso.Location = new Point(45, 549);
            btnAdicionarCurso.Name = "btnAdicionarCurso";
            btnAdicionarCurso.Size = new Size(96, 30);
            btnAdicionarCurso.TabIndex = 2;
            btnAdicionarCurso.Text = "Adicionar";
            btnAdicionarCurso.UseVisualStyleBackColor = true;
            btnAdicionarCurso.Click += btnAdicionarCurso_Click;
            // 
            // CadastroCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(708, 620);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "CadastroCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADICIONAR CURSO";
            FormClosing += CadastroCurso_FormClosing;
            Load += Cadastramento_de_Cursos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridViewCadastroCurso).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdicionar;
        private Button btnSair;
        private TextBox txtCadastroCurso;
        private Label label;
        private Button btnExcluir;
        private TextBox txtId;
        private Label lblId;
        private PictureBox pictureBox1;
        private DataGridView GridViewCadastroCurso;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private Button btnAlterar;
        private Panel panel1;
        private Button btnSairCurso;
        private Button btnAdicionarCurso;
        private Button btnExcluirCurso;
        private Button btnAlterarCurso;
    }
}