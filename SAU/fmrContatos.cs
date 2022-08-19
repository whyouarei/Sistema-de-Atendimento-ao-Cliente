using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
