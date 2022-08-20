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
    public partial class frmAcesso : Form
    {
        public frmAcesso()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            string msg = "Teste de Conexão com Banco de Dados";

            // Instanciar a classe
            TestarDTO testarConexao = new TestarDTO();

            // Chamar o método
            testarConexao.Verificar();

            // Determinar o tamanho máximo na label
            lblTeste.MaximumSize = new Size(700, 0);

            // Qual o retorno?

            if (testarConexao.conectar == null)
            {
                lblTeste.Text = msg;
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "Falhou!";
                MessageBox.Show(testarConexao.mensagem, "Aviso");
            }
            else
            {
                lblTeste.Text = msg;
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = "OK";
            }
        }

        private void lblTeste_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
