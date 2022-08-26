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
    }
}
