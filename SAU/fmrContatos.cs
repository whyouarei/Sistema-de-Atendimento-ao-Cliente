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
        TratamentoCampos tratamentoCampos = new TratamentoCampos();
        bool ncadastro = false;

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
            tratamentoCampos.Limpar(this);
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
            // Instanciar as classes DTO 
            ConsultarContatos consultarContatos = new ConsultarContatos();
            ContatosDTO dados = new ContatosDTO();

            // Chamar método para Consulta
            consultarContatos.MostrarContatos(dados);

            // Limpar fonte de dados e a lista
            lstContatos.DataSource = null;
            lstContatos.Items.Clear();

            // Popular o ListBox
            // Apenas o nome será visível, o código não
            lstContatos.ValueMember = "codContato";
            lstContatos.DisplayMember = "nomedoContato";
            lstContatos.DataSource = consultarContatos.ContatosDataTable;

            // Desabilitar os campos
            tratamentoCampos.Bloquear(this);
            // Tornar visível o grpContatos
            grpContatos.Visible = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Tornar invisível o grpContatos

            grpContatos.Visible = false;

            // Desabilitar os demais campos

            tratamentoCampos.Desbloquear(this);



        }

        private void mskCep_MouseClick(object sender, MouseEventArgs e)
        {
            mskCep.Select(0, 0);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (ncadastro == true)
            {
                tratamentoCampos.Desbloquear(this);
                tratamentoCampos.Limpar(this);
                txtCodigo.Enabled = false;
                btnSalvar.Text = "Salvar";
                ncadastro = false;
            }
            else
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


                if (txtUF.Text != string.Empty && txtTelefone.Text == string.Empty)
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
                        tratamentoCampos.Bloquear(this);
                        btnSalvar.Text = "Novo";
                        ncadastro = true;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível realizar o cadastro - " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }

        private void txtNumeroEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void lstContatos_Click(object sender, EventArgs e)
        {

            // Extrair o código do contato selecionado
            DataRowView drv = (DataRowView)lstContatos.Items[lstContatos.SelectedIndex];

            // Instanciar as classes DTO
            ConsultarContatos consultarContatos = new ConsultarContatos();
            ContatosDTO dados = new ContatosDTO();

            // Chamar método para consulta
            consultarContatos.MostrarContatos(dados);

            // Percorrer o DataTable para localizar os dados do contato selecionado
            for (int i = 0; i < consultarContatos.ContatosDataTable.Rows.Count; i++)
            {
                if(drv["codContato"].ToString() == consultarContatos.ContatosDataTable.Rows[i]["codContato"].ToString())
                {
                    txtCodigo.Text = consultarContatos.ContatosDataTable.Rows[i]["codContato"].ToString();
                    txtNome.Text = consultarContatos.ContatosDataTable.Rows[i]["nomedoContato"].ToString();
                    txtEndereco.Text = consultarContatos.ContatosDataTable.Rows[i]["enderecoContato"].ToString();
                    txtBairro.Text = consultarContatos.ContatosDataTable.Rows[i]["bairro"].ToString();
                    txtCidade.Text = consultarContatos.ContatosDataTable.Rows[i]["cidade"].ToString();
                    txtUF.Text = consultarContatos.ContatosDataTable.Rows[i]["uf"].ToString();
                    mskCep.Text = consultarContatos.ContatosDataTable.Rows[i]["cep"].ToString();
                    txtEmail.Text = consultarContatos.ContatosDataTable.Rows[i]["telefoneContato"].ToString();
                    txtTelefone.Text = consultarContatos.ContatosDataTable.Rows[i]["emailContato"].ToString();

                    btnFechar_Click(null, null);
                }
            }
        }
    }
}
