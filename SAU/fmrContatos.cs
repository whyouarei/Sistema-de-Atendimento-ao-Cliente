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
    public partial class fmrContatos : Form
    {
        public fmrContatos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Rotina para limpar os controles
            txtCodigo.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtNumeroEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            mskCep.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();

            // Posicionar o cursor
            txtNome.Focus();
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Rotina para sair do form.

            // Enviar mesnsagem
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }


        }

        private void grpContatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Tornar visível o grpContatos

            grpContatos.Visible = true;

            // Desabilitar os demais campos

            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumeroEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
            mskCep.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
            btnListar.Enabled = false;
            btnSair.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Tornar invisível o grpContatos

            grpContatos.Visible = false;

            // Desabilitar os demais campos

            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumeroEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
            mskCep.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            btnListar.Enabled = true;
            btnSair.Enabled = true;



        }

        private void mskCep_MouseClick(object sender, MouseEventArgs e)
        {
            mskCep.Select(0, 0);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        

            // Definir Variável para receber o nome do TextBox

            TextBox textBox = new TextBox();

            // Variável de controle para indicar o TextBox que receberá o focus/msg.

            bool finalizar = false;

            // Criar uma consulta LINQ

            var controle = from crtl in this.Controls.OfType<TextBox>()
                           where crtl.Name != "txtCodigo"
                           orderby crtl.TabIndex
                           select crtl;

            // Percoorer a consulta e verificar quais os campos não foram preenchidos

            foreach (var crtlTxt in controle)
            {
                if (crtlTxt.Text == String.Empty)
                {
                    finalizar = true;
                    textBox.Name = crtlTxt.Name;
                    crtlTxt.Focus();
                    break;
                }
            }
                     

            if (txtEmail.Text != string.Empty)
            {
                // Remover a máscara - formatação
                mskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (mskCep.Text == string.Empty)
                {
                    MessageBox.Show("Favor informar o CEP ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskCep.Focus();
                    finalizar = true;
                }
                else
                {
                    // Retornar a Máscara
                    mskCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                }
            }

            // Apresentar mensagem para preencher o campo 

            if (finalizar == true && mskCep.Text != string.Empty)
            {
                MessageBox.Show("Favor preencher o campo " + textBox.Name.Substring(3, textBox.Name.Length - 3), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (finalizar == false)
            {
                SalvarContatos salvarContatos = new SalvarContatos();
                ContatosDTO dados = new ContatosDTO();

                // Popular a classe

                dados.nome = txtNome.Text;
                dados.endereco = txtEndereco.Text;
                dados.numero = Convert.ToInt32(txtNumeroEndereco.Text);
                dados.bairro = txtBairro.Text;
                dados.cidade = txtCidade.Text;
                dados.uf = txtUF.Text;
                dados.cep = mskCep.Text;
                dados.telefone = txtTelefone.Text;
                dados.email = txtEmail.Text;

                // Chamar o método
                salvarContatos.ContatosIncluir(dados);

                // Validar o resultado
                if (dados.codigo != 0)
                {
                    // Popular o campo código
                    txtCodigo.Text = dados.codigo.ToString();
                    MessageBox.Show("Cadastro realizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o cadastro - " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtNome.Enabled = false;
                txtEndereco.Enabled = false;
                txtNumeroEndereco.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtUF.Enabled = false;
                mskCep.Enabled = false;
                txtTelefone.Enabled = false;
                txtEmail.Enabled = false;
                btnSalvar.Enabled = false;

            }

        }

        private void txtNumeroEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }
    }
}
