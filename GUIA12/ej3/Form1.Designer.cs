namespace ej3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSolicitar = new Button();
            label1 = new Label();
            label2 = new Label();
            lbCantidad = new Label();
            lsbListado = new ListBox();
            SuspendLayout();
            // 
            // btnSolicitar
            // 
            btnSolicitar.Font = new Font("Segoe UI", 14F);
            btnSolicitar.Location = new Point(237, 60);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(179, 45);
            btnSolicitar.TabIndex = 0;
            btnSolicitar.Text = "Solicitar Valor";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(86, 154);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 1;
            label1.Text = "Listado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(270, 154);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 2;
            label2.Text = "Cantidad:";
            // 
            // lbCantidad
            // 
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Font = new Font("Segoe UI", 14F);
            lbCantidad.Location = new Point(368, 154);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(86, 25);
            lbCantidad.TabIndex = 3;
            lbCantidad.Click += lbCantidad_Click;
            // 
            // lsbListado
            // 
            lsbListado.Font = new Font("Segoe UI", 14F);
            lsbListado.FormattingEnabled = true;
            lsbListado.ItemHeight = 25;
            lsbListado.Location = new Point(86, 194);
            lsbListado.Name = "lsbListado";
            lsbListado.Size = new Size(368, 229);
            lsbListado.TabIndex = 4;
            lsbListado.SelectedIndexChanged += lsbListado_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 463);
            Controls.Add(lsbListado);
            Controls.Add(lbCantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSolicitar);
            Name = "Form1";
            Text = "Ejemplo Modal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSolicitar;
        private Label label1;
        private Label label2;
        private Label lbCantidad;
        private ListBox lsbListado;
    }
}
