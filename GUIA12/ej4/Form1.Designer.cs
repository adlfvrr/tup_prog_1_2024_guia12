namespace ej4
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
            lsbListado = new ListBox();
            lbCantidad = new Label();
            SuspendLayout();
            // 
            // btnSolicitar
            // 
            btnSolicitar.Font = new Font("Segoe UI", 14F);
            btnSolicitar.Location = new Point(178, 45);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(184, 48);
            btnSolicitar.TabIndex = 0;
            btnSolicitar.Text = "Solicitar Valor";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(86, 140);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 1;
            label1.Text = "Listado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(323, 140);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 2;
            label2.Text = "Cantidad";
            // 
            // lsbListado
            // 
            lsbListado.Font = new Font("Segoe UI", 14F);
            lsbListado.FormattingEnabled = true;
            lsbListado.ItemHeight = 25;
            lsbListado.Location = new Point(86, 168);
            lsbListado.Name = "lsbListado";
            lsbListado.Size = new Size(416, 229);
            lsbListado.TabIndex = 3;
            lsbListado.SelectedIndexChanged += lsbListado_SelectedIndexChanged;
            // 
            // lbCantidad
            // 
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Font = new Font("Segoe UI", 14F);
            lbCantidad.Location = new Point(417, 140);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(85, 23);
            lbCantidad.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 429);
            Controls.Add(lbCantidad);
            Controls.Add(lsbListado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSolicitar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSolicitar;
        private Label label1;
        private Label label2;
        private ListBox lsbListado;
        private Label lbCantidad;
    }
}
