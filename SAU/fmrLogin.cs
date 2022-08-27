using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferenciaDados;
namespace SAU
{
    public partial class fmrLogin : Form
    {
        // Declaração de variáveis
        public bool LoginSucesso = false;

        public fmrLogin()
        {
            InitializeComponent();
        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {
            this.Size = new Size(515, 332);
            this.Location = new Point(360, 200);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            pnlMudarSenha.Location = new Point(548, 24);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Efetuar a verifiaçao dos campos Usuário e Senha
            // Verificar se o campo txtusuario está preenchido

            if (txtEmailUsuario.Text == String.Empty)
            {
                MessageBox.Show("Favor informar o usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailUsuario.Focus();
            }
            else if (mskSenha.Text == String.Empty)
            {
                MessageBox.Show("Favor digitar a senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskSenha.Focus();
            }
            else
            {
                // Instanciar as classes
                ValidarUsuario validarUsuario = new ValidarUsuario();
                UsuariosDTO dados = new UsuariosDTO();

                // Popular a classe
                dados.nomeusuario = txtEmailUsuario.Text;
                dados.senhausuario = mskSenha.Text;

                // Chamar o método
                validarUsuario.VerificarUsuario(dados);

                if (dados.mensagens != null)
                {
                    MessageBox.Show(dados.mensagens);
                }
                else
                {
                    switch (dados.logado)
                    {
                        case 0:
                            MessageBox.Show("Usuário ou senha incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            
                            // Limpar os campos e posicionar o cursor no nome do usuário
                            txtEmailUsuario.Clear();
                            mskSenha.Clear();

                            txtEmailUsuario.Focus();
                            LoginSucesso = false;
                            break;
                        
                        case 1:
                            LoginSucesso = true;
                            MessageBox.Show("Bem vindo ao Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            // Limpar os campos
                            txtEmailUsuario.Clear();
                            mskSenha.Clear();

                            if (LoginSucesso == true)
                            {
                                Close();
                            }
                            break;

                        case 2:
                            MessageBox.Show("Usuário já conectado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            // Limpar os campos e posicionar o cursor no nome do usuário
                            txtEmailUsuario.Clear();
                            mskSenha.Clear();

                            txtEmailUsuario.Focus();
                            LoginSucesso = false;
                            break;

                        case 3:
                            MessageBox.Show("Seu primeiro acesso, " + "será necessário alterar a senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            pnlMudarSenha.Location = new Point(-1, -1);
                            mskSenhaAtual.Focus();
                            break;

                        case 4:
                            MessageBox.Show("Verifique o ocorrido " + "junto ao Administrador do Sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                    }
                }
            }
        }
    }
}
