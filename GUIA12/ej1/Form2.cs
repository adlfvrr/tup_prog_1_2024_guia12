﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej1
{
    public partial class FormModal : Form
    {
        public FormModal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        { 
        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {
            int valor;
            valor = Convert.ToInt32(tbValor.Text);
        }
    }
}
