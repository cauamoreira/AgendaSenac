using AgendaSenac;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dot.Net._6.WF.Calendario.Senac
{
    public partial class CadastroUsuario : Form
    {
        private bool _podeVerSenha = false;
        public CadastroUsuario()
        {
            InitializeComponent();

            txtCpf.TextChanged += txtCpf_TextChanged;
            GridConsultarUsuario.CellClick += GridConsultarUsuario_CellClick;
            GridConsultarUsuario.CellClick += GridConsultarUsuario_CellClick;
            txtCpf.KeyDown += txtCpf_KeyDown;
            this.Load += FrmCadastroUsuario_Load;

        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            string nomeUsuarioNovo = txtUsuario.Text;
            string senhaNovo = txtSenha.Text;
            string CpfNovo = txtCpf.Text;

            if (senhaNovo.Length < 6 || !senhaNovo.Any(char.IsDigit) || !senhaNovo.Any(char.IsLetter))
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres, incluindo pelo menos um número e uma letra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var bd = new BancoDeDados())
            {
                if (!bd.Usuarios.Any())
                {

                    bd.Usuarios.Add(new Usuario
                    {
                        Login = "admin",
                        Senha = "senha1",
                        Cpf = "00000000000",
                        DataNascimento = DateTime.Now,
                        Ativo = true,
                        Administrador = true
                    });

                    bd.SaveChanges();
                }

                var usuarioExistente = bd.Usuarios.FirstOrDefault(u => u.Login == nomeUsuarioNovo);

                if (usuarioExistente != null)
                {
                    MessageBox.Show("Nome de usuário já existe. Escolha outro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var cpfExistente = bd.Usuarios.Any(c => c.Cpf == CpfNovo);

                if (cpfExistente)
                {
                    MessageBox.Show("CPF já está em uso. Escolha outro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                var novoUsuario = new Usuario()
                {
                    Login = nomeUsuarioNovo,
                    Cpf = txtCpf.Text,
                    DataNascimento = dtpDataNascimento.Value.Date,
                    Senha = senhaNovo,
                    Ativo = chkAtivo.Checked,
                    Administrador = chkAdministrador.Checked
                };

                AdicionarHistoricoNovoUsuario(bd, novoUsuario);

                bd.Usuarios.Add(novoUsuario);

                bd.SaveChanges();

                MessageBox.Show("Usuário criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Listar();
                LimparCampos();

            }
        }

        private void AdicionarHistoricoNovoUsuario(BancoDeDados bd, Usuario usuario)
        {
            string login = Autenticacao.UsuarioAtual?.Login ?? "";

            bd.Historicos.Add(new Historico
            {
                Login = login,
                DataHora = DateTime.Now,
                Alteracao = "Criação de Usuário",
                Detalhes = $"Criado usuário: {usuario.Login}, CPF: {usuario.Cpf}, Data de Nascimento: {usuario.DataNascimento}, Ativo: {usuario.Ativo}, Administrador: {usuario.Administrador}"

            });
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnSalvarUsuario_Click(this, new EventArgs());
            }
        }

        private void LimparCampos()
        {
            txtUsuario.Clear();
            txtCpf.Clear();
            txtSenha.Clear();
            chkAdministrador.Checked = false;
            chkAtivo.Checked = false;
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            Listar();

        }

        private void Listar()
        {
            GridConsultarUsuario.Rows.Clear();

            using (var bd = new BancoDeDados())
            {
                var usuarios = bd.Usuarios.ToList();

                foreach (var usuario in usuarios)
                {
                    GridConsultarUsuario.Rows.Add(
                        usuario.Id,
                        usuario.Login,
                        usuario.Cpf,
                        usuario.DataNascimento,
                        usuario.Senha,
                        usuario.Ativo,
                        usuario.Administrador);

                }

            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            {
                using (var bd = new BancoDeDados())
                {
                    var usuario = bd.Usuarios.FirstOrDefault(w => w.Id == Convert.ToInt32(txtId.Text));

                    if (usuario != null)
                    {

                        if (Autenticacao.UsuarioAtual?.Login == usuario.Login)
                        {
                            usuario.Login = txtUsuario.Text;
                            usuario.Cpf = txtCpf.Text;
                            usuario.Senha = txtSenha.Text;
                            usuario.DataNascimento = dtpDataNascimento.Value.Date;
                            usuario.Ativo = chkAtivo.Checked;
                            usuario.Administrador = chkAdministrador.Checked;

                            bd.Historicos.Add(new Historico
                            {
                                Login = Autenticacao.UsuarioAtual?.Login,
                                DataHora = DateTime.Now,
                                Alteracao = "Alteração de Usuário",
                                Detalhes = $"Alterado o usuário: {txtId.Text}"
                            });

                            DialogResult resultado = MessageBox.Show("Deseja realmente alterar?", "Cadastro de Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (resultado == DialogResult.Yes)
                            {
                                bd.SaveChanges();
                                MessageBox.Show("Usuário alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Listar();
                                LimparCampos();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Você só pode editar seus próprios dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado. Verifique o usuário informado.");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Deve selecionar o usuário que deseja excluir.");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    using (var bd = new BancoDeDados())
                    {
                        try
                        {
                            var usuario = bd.Usuarios.FirstOrDefault(w => w.Id == Convert.ToInt32(txtId.Text));

                            if (usuario != null)
                            {
                                bd.Historicos.Add(new Historico
                                {
                                    Login = Autenticacao.UsuarioAtual?.Login,
                                    DataHora = DateTime.Now,
                                    Alteracao = "Exclusão de Usuário",
                                    Detalhes = $"Excluído o usuário: {txtId.Text}"
                                });

                                bd.Usuarios.Remove(usuario);
                                bd.SaveChanges();
                                MessageBox.Show("Usuário excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Listar();
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Usuário não encontrado. Verifique o usuário informado.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void AbrirAgendaCursos()
        {
            Agenda agenda = new Agenda();
            agenda.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult iSair;
            iSair = MessageBox.Show("Tem certeza que deseja sair?",

                "Cadastro de Usuário",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (iSair == DialogResult.Yes)
            {
                AbrirAgendaCursos();
                this.Close();

            }
        }

        private void GridConsultarUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            int cpfColumnIndex = 2;
            int senhaColumnIndex = 4;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && Autenticacao.UsuarioAtual != null)
            {

                if (GridConsultarUsuario.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    string usuarioLogadoLogin = Autenticacao.UsuarioAtual.Login;
                    string loginNaLinha = GridConsultarUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();

                    if (!loginNaLinha.Equals(usuarioLogadoLogin, StringComparison.OrdinalIgnoreCase))
                    {

                        if (e.ColumnIndex == cpfColumnIndex && GridConsultarUsuario.Rows[e.RowIndex].Cells[cpfColumnIndex].Value != null)
                        {
                            e.Value = "******";
                        }

                        if (e.ColumnIndex == senhaColumnIndex && GridConsultarUsuario.Rows[e.RowIndex].Cells[senhaColumnIndex].Value != null)
                        {
                            e.Value = "******";
                        }
                    }


                }
            }

            List<int> colunaBoolIndex = new List<int> { 5, 6 };

            if (e.RowIndex >= 0 && colunaBoolIndex.Contains(e.ColumnIndex))

            {
                if (e.Value != null && e.Value is bool)
                {
                    bool valorBool = (bool)e.Value;
                    e.Value = valorBool ? "Sim" : "Não";
                    e.FormattingApplied = true;
                }
            }
        }


        private void GridConsultarUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = GridConsultarUsuario.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = GridConsultarUsuario.CurrentRow.Cells[1].Value.ToString();
            txtCpf.Text = GridConsultarUsuario.CurrentRow.Cells[2].Value.ToString();
            dtpDataNascimento.Text = GridConsultarUsuario.CurrentRow.Cells[3].Value.ToString();
            txtSenha.Text = GridConsultarUsuario.CurrentRow.Cells[4].Value.ToString();
            chkAtivo.Checked = (bool)GridConsultarUsuario.CurrentRow.Cells[5].Value;
            chkAdministrador.Checked = (bool)GridConsultarUsuario.CurrentRow.Cells[6].Value;


            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                string usuarioLogadoLogin = Autenticacao.UsuarioAtual?.Login;


                string loginNaCela = GridConsultarUsuario.Rows[e.RowIndex].Cells["Column2"].Value.ToString();


                if (usuarioLogadoLogin.Equals(loginNaCela, StringComparison.OrdinalIgnoreCase))
                {

                    txtCpf.Text = GridConsultarUsuario.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                }
                else
                {

                    txtCpf.Text = new string('*', txtCpf.MaxLength);
                }
            }
        }

        private void TextOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !
                  char.IsLetter(e.KeyChar) && !
                  char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Aceito somente letras.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }

            else
            {

                if (e.KeyChar >= '0' && e.KeyChar <= '9')
                {

                    e.Handled = false;

                }

                else
                {

                    MessageBox.Show("Digite apenas números", "Erro: Apenas números", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    e.Handled = true;
                }
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

            string cpfDigito = new string(txtCpf.Text.Where(char.IsDigit).ToArray());


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


            txtCpf.Text = cpfDigito;


            txtCpf.SelectionStart = txtCpf.Text.Length;
        }


        private void txtCpf_Leave(object sender, EventArgs e)
        {
            string cpfDigito = new string(txtCpf.Text.Where(char.IsDigit).ToArray());


            if (cpfDigito.Length != 11)
            {
                MessageBox.Show("CPF inválido. Preencha corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                txtCpf.Clear();
                txtCpf.Focus();
            }
        }

        private void txtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {

                if (txtCpf.SelectionStart > 0)
                {
                    int cursorPosition = txtCpf.SelectionStart;
                    string Texto = txtCpf.Text.Remove(cursorPosition - 1, 1);
                    txtCpf.Text = Texto;
                    txtCpf.SelectionStart = cursorPosition - 1;
                }

                e.Handled = true;
            }

        }

        private void CadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult fechar = MessageBox.Show("Deseja realmente fechar?",
                                                    "Cadastro de Usuário",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (fechar == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {

                    
                }
            }
        }
    }
}

























