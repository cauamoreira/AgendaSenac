namespace AgendaSenac
{
    partial class NovaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaSenha));
            panel1 = new Panel();
            txtConfirmarSenha = new TextBox();
            btnCancelar = new Button();
            btnMudarSenha = new Button();
            txtNovaSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtConfirmarSenha);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnMudarSenha);
            panel1.Controls.Add(txtNovaSenha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 524);
            panel1.TabIndex = 1;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Anchor = AnchorStyles.None;
            txtConfirmarSenha.BackColor = SystemColors.HighlightText;
            txtConfirmarSenha.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarSenha.Location = new Point(158, 388);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '•';
            txtConfirmarSenha.Size = new Size(280, 23);
            txtConfirmarSenha.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonHighlight;
            btnCancelar.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.Desktop;
            btnCancelar.Location = new Point(183, 431);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 30);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnMudarSenha
            // 
            btnMudarSenha.BackColor = SystemColors.ButtonHighlight;
            btnMudarSenha.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMudarSenha.ForeColor = SystemColors.Desktop;
            btnMudarSenha.Location = new Point(325, 431);
            btnMudarSenha.Name = "btnMudarSenha";
            btnMudarSenha.Size = new Size(96, 30);
            btnMudarSenha.TabIndex = 4;
            btnMudarSenha.Text = "Redefinir";
            btnMudarSenha.UseVisualStyleBackColor = false;
            btnMudarSenha.Click += btnMudarSenha_Click;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Anchor = AnchorStyles.None;
            txtNovaSenha.BackColor = SystemColors.HighlightText;
            txtNovaSenha.BorderStyle = BorderStyle.FixedSingle;
            txtNovaSenha.Location = new Point(158, 325);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PasswordChar = '•';
            txtNovaSenha.Size = new Size(280, 23);
            txtNovaSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(158, 307);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 0;
            label1.Text = "Nova senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(158, 371);
            label2.Name = "label2";
            label2.Size = new Size(148, 17);
            label2.TabIndex = 0;
            label2.Text = "Confirmar nova senha:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // NovSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 524);
            Controls.Add(panel1);
            Name = "NovSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NovSenha";
            FormClosing += NovSenha_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtConfirmarSenha;
        private Button btnCancelar;
        private Button btnMudarSenha;
        private TextBox txtNovaSenha;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}