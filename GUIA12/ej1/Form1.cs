namespace ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnSolicitar_Click(object sender, EventArgs e)
        {
            //int valor = Convert.ToInt32(textBox1.Text);
            //lbMostrarValor.Text = $"{valor}"; 
            FormModal fModal = new FormModal();
            fModal.ShowDialog();
            if (fModal.DialogResult == DialogResult.OK)
            {
                lbMostrarValor.Text = $"{fModal.tbValor.Text}";
            }
            else
            {
                lbMostrarValor.Text = "No aceptado";
            }
        }

        private void lbMostrarValor_Click(object sender, EventArgs e)
        {
        }
    }
}
