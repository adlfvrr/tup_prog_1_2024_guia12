namespace ej1
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
            lbMostrarValor = new Label();
            SuspendLayout();
            // 
            // btnSolicitar
            // 
            btnSolicitar.Font = new Font("Segoe UI", 11F);
            btnSolicitar.Location = new Point(246, 33);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(171, 45);
            btnSolicitar.TabIndex = 0;
            btnSolicitar.Text = "Solicitar Valor";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(74, 123);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 1;
            label1.Text = "Resultado";
            // 
            // lbMostrarValor
            // 
            lbMostrarValor.BackColor = SystemColors.ActiveCaption;
            lbMostrarValor.Font = new Font("Segoe UI", 14F);
            lbMostrarValor.Location = new Point(246, 123);
            lbMostrarValor.Name = "lbMostrarValor";
            lbMostrarValor.Size = new Size(171, 34);
            lbMostrarValor.TabIndex = 2;
            lbMostrarValor.Click += lbMostrarValor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 220);
            Controls.Add(lbMostrarValor);
            Controls.Add(label1);
            Controls.Add(btnSolicitar);
            Name = "Form1";
            Text = "Ejemplo.Models";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSolicitar;
        private Label label1;
        private Label lbMostrarValor;
    }
}
