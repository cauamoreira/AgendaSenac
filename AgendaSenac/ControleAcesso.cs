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
    public partial class ControleAcesso : Form
    {
        public ControleAcesso()
        {
            InitializeComponent();
            CarregarHistorico();
        }

        public void CarregarHistorico()
        {
            gridHistorico.Rows.Clear();

            using (var bd = new BancoDeDados())
            {

                var historico = bd.Historicos.ToList();

                foreach (var registro in historico)
                {
                    gridHistorico.Rows.Add(
                        registro.Id,
                        registro.Login,
                        registro.DataHora,
                        registro.Alteracao,
                        registro.Detalhes

                    );
                }
            }
        }

        private void AbrirFormAgenda()
        {
            Agenda agenda = new Agenda();
            agenda.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var fechar = MessageBox.Show("Deseja realmente sair?",
            "Alerta",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (fechar == DialogResult.Yes)
            {
                AbrirFormAgenda();
                this.Close();
            }
        }

        private void ControleAcesso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
        }
    }
}
