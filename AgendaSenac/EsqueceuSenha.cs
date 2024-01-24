using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSenac
{
    public partial class EsqueceuSenha : Form
    {
        public EsqueceuSenha()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            string CpfDigitado = txtCpfUsuario.Text;
            DateTime dataNascimento = dtpDataNascimento.Value;

            using (var bd = new BancoDeDados())
            {
                var usuario = bd.Usuarios.FirstOrDefault(u => u.Cpf == CpfDigitado &&
                u.DataNascimento == dataNascimento);

                if (usuario != null)
                {
                    this.Close();
                   // AbrirNovaSenha(usuario);


                }
                else
                {
                    MessageBox.Show("CPF ou data de nascimento inválidos.", "Falha ao alterar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //private void AbrirNovaSenha(Usuario usuario)
        //{
        //    NovaSenha novaSenha = new NovaSenha(usuario);
        //    novaSenha.Show();
        //}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar?",
                    "Alerta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                TelaLogin();
                this.Close();
            }
        }

        private void txtCpfUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {

                if (txtCpfUsuario.SelectionStart > 0)
                {
                    int cursorPosition = txtCpfUsuario.SelectionStart;
                    string Texto = txtCpfUsuario.Text.Remove(cursorPosition - 1, 1);
                    txtCpfUsuario.Text = Texto;
                    txtCpfUsuario.SelectionStart = cursorPosition - 1;
                }

                e.Handled = true;
            }
        }

        private void TelaLogin()
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void txtCpfUsuario_TextChanged(object sender, EventArgs e)
        {
            string cpfDigito = new string(txtCpfUsuario.Text.Where(char.IsDigit).ToArray());


            if (cpfDigito.Length > 11)
            {
                cpfDigito = cpfDigito.Substring(0, 11);
            }


            if (cpfDigito.Length > 2)
            {
                cpfDigito = cpfDigito.Insert(3, ".");
            }
            if (cpfDigito.Length > 6)
            {
                cpfDigito = cpfDigito.Insert(7, ".");
            }
            if (cpfDigito.Length > 10)
            {
                cpfDigito = cpfDigito.Insert(11, "-");
            }


            txtCpfUsuario.Text = cpfDigito;


            txtCpfUsuario.SelectionStart = txtCpfUsuario.Text.Length;
        }
    }
}
