using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej4
{
    public partial class FormModal : Form
    {
        public FormModal()
        {
            InitializeComponent();
        }

        public void tbValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void tbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty( tbValor.Text) && e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                DialogResult = DialogResult.OK;
            }
            else if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
