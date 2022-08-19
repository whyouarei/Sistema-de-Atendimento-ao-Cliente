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
    public partial class frmPrincipal : Form
    {
        #region Rotinas para abrir e fechar forms.

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void FecharTodos()
        {
            try
            {
                foreach (Form childForm in Application.OpenForms){
                    if (childForm.Name != this.Name)
                    {
                        childForm.Close();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void AbrirForm(Form childForm)
        {
            childForm.StartPosition = FormStartPosition.CenterScreen;
            int x = (this.Width - childForm.Width) / 2;
            int y = (this.Height - childForm.Height) / 2;
            childForm.Location = new Point(x, y);
            childForm.Show();
        }

        #endregion
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            FecharTodos();
            Form childForm = new frmChamados();
            AbrirForm(childForm);
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            FecharTodos();
            Form childForm = new fmrContatos();
            AbrirForm(childForm);
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
