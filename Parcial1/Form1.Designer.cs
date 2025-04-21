namespace Parcial1
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
            lblTitulo = new Label();
            lblParrafo = new Label();
            btnCliente = new Button();
            btnAdmin = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(238, 68);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(302, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestioná tus ventas y stock en un solo lugar\n\n";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblParrafo
            // 
            lblParrafo.AutoSize = true;
            lblParrafo.Font = new Font("Bahnschrift Light Condensed", 9F);
            lblParrafo.Location = new Point(127, 128);
            lblParrafo.Margin = new Padding(2, 0, 2, 0);
            lblParrafo.Name = "lblParrafo";
            lblParrafo.Size = new Size(523, 36);
            lblParrafo.TabIndex = 1;
            lblParrafo.Text = "Registrate o iniciá sesión según tu rol para empezar a controlar tu negocio de forma simple y eficiente.\n\n";
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(182, 257);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(94, 29);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(500, 257);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(94, 29);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;   
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(340, 350);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 405);
            Controls.Add(btnSalir);
            Controls.Add(btnAdmin);
            Controls.Add(btnCliente);
            Controls.Add(lblParrafo);
            Controls.Add(lblTitulo);
            Font = new Font("Bahnschrift SemiBold", 9F);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "INICIO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblParrafo;
        private Button btnCliente;
        private Button btnAdmin;
        private Button btnSalir;
    }
}
