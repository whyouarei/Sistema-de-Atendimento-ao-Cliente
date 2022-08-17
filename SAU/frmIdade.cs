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

            // Atribuição de Valores
            nomeUsuario = txtNome.Text;
            idadeUsuario = Convert.ToInt32(txtIdade.Text);

            // Apresentação do valor das variáveis
            MessageBox.Show("Nome: " + nomeUsuario.ToString() + " e idade " + idadeUsuario.ToString());
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
    }
}
