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
    public partial class frmIdade : Form
    {
        public frmIdade()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Declaração de Variáveis
            string nomeUsuario;
            int idadeUsuario;

            // Verificar se os campos foram preenchidos
            if ((txtNome.Text != string.Empty) && (txtIdade.Text != string.Empty))
            {

                // Atribuição de Valores
                nomeUsuario = txtNome.Text;
                idadeUsuario = Convert.ToInt32(txtIdade.Text);

                // Apresentação do valor das variáveis
                MessageBox.Show("Nome: " + nomeUsuario.ToString() + " e idade " + idadeUsuario.ToString());
            }

            else
            {
                if ((txtNome.Text != string.Empty) && (txtIdade.Text == string.Empty))
                {
                    MessageBox.Show("Favor preencher o campo Idade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdade.Focus();
                }
                else if ((txtNome.Text == string.Empty) && (txtIdade.Text != string.Empty))
                {
                    MessageBox.Show("Favor preencher o campo Nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Favor preencher os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();

            txtNome.Focus();
        }

        private void frmIdade_Load(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }
    }
}
