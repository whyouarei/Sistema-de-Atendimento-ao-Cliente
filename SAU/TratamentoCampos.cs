using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAU
{
    public class TratamentoCampos
    {
        public void Limpar (Form form)
        {
           foreach (Control item in form.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = string.Empty;
                }

                if (item is MaskedTextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        public void Bloquear(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                }

                if (item is MaskedTextBox)
                {
                    item.Enabled = false;
                }
            }
        }

        public void Desbloquear(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = true;
                }

                if (item is MaskedTextBox)
                {
                    item.Enabled = true;
                }
            }
        }

    }
}
