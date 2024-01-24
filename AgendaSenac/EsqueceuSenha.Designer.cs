namespace AgendaSenac
{
    partial class EsqueceuSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueceuSenha));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            dtpDataNascimento = new DateTimePicker();
            btnCancelar = new Button();
            pictureBox3 = new PictureBox();
            btnProximo = new Button();
            txtCpfUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(dtpDataNascimento);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnProximo);
            panel1.Controls.Add(txtCpfUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 479);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(119, 319);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Anchor = AnchorStyles.None;
            dtpDataNascimento.CalendarMonthBackground = SystemColors.HighlightText;
            dtpDataNascimento.CustomFormat = "dd-MM-yyyy";
            dtpDataNascimento.Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataNascimento.Format = DateTimePickerFormat.Custom;
            dtpDataNascimento.Location = new Point(145, 314);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(278, 24);
            dtpDataNascimento.TabIndex = 2;
            dtpDataNascimento.Value = new DateTime(2024, 1, 13, 0, 0, 0, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonHighlight;
            btnCancelar.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.Desktop;
            btnCancelar.Location = new Point(145, 366);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 30);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(119, 257);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // btnProximo
            // 
            btnProximo.BackColor = SystemColors.HighlightText;
            btnProximo.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnProximo.ForeColor = SystemColors.Desktop;
            btnProximo.Location = new Point(327, 366);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(96, 30);
            btnProximo.TabIndex = 4;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = false;
            btnProximo.Click += btnProximo_Click;
            // 
            // txtCpfUsuario
            // 
            txtCpfUsuario.Anchor = AnchorStyles.None;
            txtCpfUsuario.BackColor = SystemColors.HighlightText;
            txtCpfUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtCpfUsuario.Location = new Point(145, 257);
            txtCpfUsuario.Name = "txtCpfUsuario";
            txtCpfUsuario.Size = new Size(278, 23);
            txtCpfUsuario.TabIndex = 1;
            txtCpfUsuario.TextChanged += txtCpfUsuario_TextChanged;
            txtCpfUsuario.KeyDown += txtCpfUsuario_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(145, 237);
            label1.Name = "label1";
            label1.Size = new Size(35, 17);
            label1.TabIndex = 0;
            label1.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Microsoft PhagsPa", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(145, 294);
            label2.Name = "label2";
            label2.Size = new Size(137, 17);
            label2.TabIndex = 0;
            label2.Text = "Data de Nascimento:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // EsqueceuSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 479);
            Controls.Add(panel1);
            Name = "EsqueceuSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EsqueceuSenha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private DateTimePicker dtpDataNascimento;
        private Button btnCancelar;
        private PictureBox pictureBox3;
        private Button btnProximo;
        private TextBox txtCpfUsuario;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}