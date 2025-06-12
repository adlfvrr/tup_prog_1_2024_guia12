namespace ej2
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
            btnMostrar = new Button();
            label1 = new Label();
            tbValor = new TextBox();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI", 14F);
            btnMostrar.Location = new Point(279, 55);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(140, 41);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar Valor";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(59, 63);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 1;
            label1.Text = "Valor";
            // 
            // tbValor
            // 
            tbValor.Font = new Font("Segoe UI", 14F);
            tbValor.Location = new Point(121, 55);
            tbValor.Multiline = true;
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(125, 41);
            tbValor.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 180);
            Controls.Add(tbValor);
            Controls.Add(label1);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Ejemplo Modal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Label label1;
        private TextBox tbValor;
    }
}
