namespace ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(tbValor.Text);
            FormModal formModal = new FormModal();
            formModal.ShowDialog();
            if (formModal.DialogResult == DialogResult.OK)
            {
                formModal.lbMostrarValor.Text = $"{valor}";
                formModal.ShowDialog();
            }
            else
            {
                formModal.lbMostrarValor.Text = "No aceptado";
                formModal.ShowDialog();
            }
        }
    }
}
