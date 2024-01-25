namespace AgendaSenac
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
            GridCadastroCurso = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            lblId = new Label();
            txtId = new TextBox();
            txtCadastroCurso = new TextBox();
            label = new Label();
            panel1 = new Panel();
            btnExcluir = new Button();
            btnAlterar = new Button();
            btnSair = new Button();
            btnAdicionar = new Button();
            btnExcluirCurso = new Button();
            btnAlterarCurso = new Button();
            btnSairCurso = new Button();
            btnAdicionarCurso = new Button();
            ((System.ComponentModel.ISupportInitialize)GridCadastroCurso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // GridCadastroCurso
            // 
            GridCadastroCurso.AllowUserToAddRows = false;
            GridCadastroCurso.AllowUserToDeleteRows = false;
            GridCadastroCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridCadastroCurso.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1 });
            GridCadastroCurso.Location = new Point(1, 275);
            GridCadastroCurso.Margin = new Padding(3, 5, 3, 5);
            GridCadastroCurso.Name = "GridCadastroCurso";
            GridCadastroCurso.ReadOnly = true;
            GridCadastroCurso.RowHeadersWidth = 51;
            GridCadastroCurso.RowTemplate.Height = 25;
            GridCadastroCurso.Size = new Size(706, 246);
            GridCadastroCurso.TabIndex = 0;
            GridCadastroCurso.CellClick += GridCadastroCurso_CellClick;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "#";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 39;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Curso";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
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
            txtId.Size = new Size(26, 23);
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
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(btnExcluirCurso);
            panel1.Controls.Add(btnAlterarCurso);
            panel1.Controls.Add(btnSairCurso);
            panel1.Controls.Add(btnAdicionarCurso);
            panel1.Controls.Add(GridCadastroCurso);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtCadastroCurso);
            panel1.Controls.Add(label);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.Desktop;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.MaximumSize = new Size(2468, 1655);
            panel1.Name = "panel1";
            panel1.Size = new Size(712, 636);
            panel1.TabIndex = 1;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom;
            btnExcluir.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(381, 556);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 30);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Bottom;
            btnAlterar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.Location = new Point(207, 556);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(96, 30);
            btnAlterar.TabIndex = 9;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom;
            btnSair.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(561, 556);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(96, 30);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Bottom;
            btnAdicionar.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(37, 556);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(96, 30);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluirCurso
            // 
            btnExcluirCurso.Anchor = AnchorStyles.Bottom;
            btnExcluirCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluirCurso.Location = new Point(633, 1097);
            btnExcluirCurso.Name = "btnExcluirCurso";
            btnExcluirCurso.Size = new Size(96, 30);
            btnExcluirCurso.TabIndex = 4;
            btnExcluirCurso.Text = "Excluir";
            btnExcluirCurso.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCurso
            // 
            btnAlterarCurso.Anchor = AnchorStyles.Bottom;
            btnAlterarCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterarCurso.Location = new Point(459, 1097);
            btnAlterarCurso.Name = "btnAlterarCurso";
            btnAlterarCurso.Size = new Size(96, 30);
            btnAlterarCurso.TabIndex = 3;
            btnAlterarCurso.Text = "Alterar";
            btnAlterarCurso.UseVisualStyleBackColor = true;
            // 
            // btnSairCurso
            // 
            btnSairCurso.Anchor = AnchorStyles.Bottom;
            btnSairCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSairCurso.Location = new Point(813, 1097);
            btnSairCurso.Name = "btnSairCurso";
            btnSairCurso.Size = new Size(96, 30);
            btnSairCurso.TabIndex = 5;
            btnSairCurso.Text = "Sair";
            btnSairCurso.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarCurso
            // 
            btnAdicionarCurso.Anchor = AnchorStyles.Bottom;
            btnAdicionarCurso.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarCurso.Location = new Point(289, 1097);
            btnAdicionarCurso.Name = "btnAdicionarCurso";
            btnAdicionarCurso.Size = new Size(96, 30);
            btnAdicionarCurso.TabIndex = 2;
            btnAdicionarCurso.Text = "Adicionar";
            btnAdicionarCurso.UseVisualStyleBackColor = true;
            // 
            // CadCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 636);
            Controls.Add(panel1);
            Name = "CadCurso";
            Text = "CadCurso";
            FormClosing += CadCurso_FormClosing;
            Load += CadCurso_Load;
            ((System.ComponentModel.ISupportInitialize)GridCadastroCurso).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridCadastroCurso;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private PictureBox pictureBox1;
        private Label lblId;
        private TextBox txtId;
        private TextBox txtCadastroCurso;
        private Label label;
        private Panel panel1;
        private Button btnExcluirCurso;
        private Button btnAlterarCurso;
        private Button btnSairCurso;
        private Button btnAdicionarCurso;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btnSair;
        private Button btnAdicionar;
    }
}