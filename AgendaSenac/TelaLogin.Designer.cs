namespace AgendaSenac
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            picLoading = new PictureBox();
            label3 = new Label();
            txtSenha = new TextBox();
            picSenha = new PictureBox();
            txtUsuario = new TextBox();
            btnEntrar = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(701, 535);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(picLoading);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(picSenha);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 537);
            panel1.TabIndex = 27;
            // 
            // picLoading
            // 
            picLoading.BackColor = Color.White;
            picLoading.Image = (Image)resources.GetObject("picLoading.Image");
            picLoading.Location = new Point(227, 400);
            picLoading.Name = "picLoading";
            picLoading.Size = new Size(225, 89);
            picLoading.SizeMode = PictureBoxSizeMode.Zoom;
            picLoading.TabIndex = 31;
            picLoading.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(273, 333);
            label3.Name = "label3";
            label3.Size = new Size(129, 18);
            label3.TabIndex = 36;
            label3.Text = "Esqueceu a senha?";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.HighlightText;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Location = new Point(230, 306);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(222, 23);
            txtSenha.TabIndex = 28;
            txtSenha.KeyDown += txtSenha_KeyDown;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // picSenha
            // 
            picSenha.BackColor = SystemColors.ButtonHighlight;
            picSenha.Cursor = Cursors.Hand;
            picSenha.Image = Properties.Resources.esconder;
            picSenha.Location = new Point(200, 306);
            picSenha.Name = "picSenha";
            picSenha.Size = new Size(30, 20);
            picSenha.SizeMode = PictureBoxSizeMode.Zoom;
            picSenha.TabIndex = 35;
            picSenha.TabStop = false;
            picSenha.Click += picSenha_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.HighlightText;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(230, 260);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(222, 23);
            txtUsuario.TabIndex = 27;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ButtonHighlight;
            btnEntrar.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = SystemColors.Desktop;
            btnEntrar.Location = new Point(287, 364);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(96, 30);
            btnEntrar.TabIndex = 32;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = Properties.Resources.do_utilizador;
            pictureBox3.Location = new Point(202, 259);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(227, 244);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 29;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(229, 290);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 30;
            label2.Text = "Senha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 537);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SENAC";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLoading).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox picLoading;
        private Label label3;
        private TextBox txtSenha;
        private PictureBox picSenha;
        private TextBox txtUsuario;
        private Button btnEntrar;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
    }
}
