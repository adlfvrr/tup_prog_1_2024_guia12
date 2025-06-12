namespace ej3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            FormModal formModal = new FormModal();


            //int n = 0;
            //while (n<10 && formModal.ShowDialog()==DialogResult.OK)
            //{
            //    lsbListado.Items.Add(formModal.tbValor.Text);

            //    //reinicializarlo los controles del modal
            //    formModal.tbValor.Clear();
            //    n++;
            //}

            //lbCantidad.Text = $"{n:000}";

            //int n = 0;
            //formModal.ShowDialog();
            //while (n < 10 && formModal.DialogResult == DialogResult.OK)
            //{
            //    lsbListado.Items.Add(formModal.tbValor.Text);

            //    //reinicializarlo los controles del modal
            //    formModal.tbValor.Clear();

            //    //mostrar la ventana
            //    formModal.ShowDialog();
            //    n++;
            //}

            //lbCantidad.Text = $"{n:000}";


            formModal.ShowDialog();
            int cantidad = 0;
            for (int n = 0; n < 10 && formModal.DialogResult == DialogResult.OK; n++)
            {
                lsbListado.Items.Add(formModal.tbValor.Text);

                //reinicializarlo los controles del modal
                formModal.tbValor.Clear();

                //mostrar la ventana
                formModal.ShowDialog();
                cantidad++;
            }

            lbCantidad.Text = $"{cantidad:000}";

        }

        private void lbCantidad_Click(object sender, EventArgs e)
        {
        }

        private void lsbListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
