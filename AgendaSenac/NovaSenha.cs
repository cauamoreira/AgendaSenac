using AgendaSenac;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dot.Net._6.WF.Calendario.Senac
{

    public partial class NovaSenha : Form
    {

        private Usuario usuario;
        public NovaSenha(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar?",
                    "Alerta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                AbrirTelaLogin();

            }

        }

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text == txtConfirmarSenha.Text)
            {
                usuario.Senha = txtConfirmarSenha.Text;

                using (var bd = new BancoDeDados())
                {
                    bd.Entry(usuario).State = EntityState.Modified;

                    bd.Historicos.Add(new Historico
                    {
                        Login = usuario.Login,
                        DataHora = DateTime.Now,
                        Alteracao = "Alteração de Senha",
                        Detalhes = $"Senha alterada para o usuário: {usuario.Login}"

                    });

                    bd.SaveChanges();

                }

                MessageBox.Show("Senha alterada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("As senhas não são compatíveis.", "Confirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirTelaLogin()
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void NovaSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }
    }
}

