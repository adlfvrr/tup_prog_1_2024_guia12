using System.Configuration;

namespace ej4
{
    public partial class Form1 : Form
    {
        public FormModal formModal = new FormModal();
        public int[] listado = new int[10];
        public int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            contador = 0;
            while (contador < 10 && formModal.ShowDialog() == DialogResult.OK)
            {
                listado[contador] = Convert.ToInt32(formModal.tbValor.Text);
                contador++;
                formModal.tbValor.Clear();
                formModal.tbValor.Focus();
            }
            lbCantidad.Text = $"{contador}";
            lsbListado.Items.Clear();
            for (int i = 0; i < contador; i++)
            {
                lsbListado.Items.Add(listado[i]);
            }
        }

        private void lbCantidad_Click(object sender, EventArgs e)
        {

        }

        private void lsbListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
