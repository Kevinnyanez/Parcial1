namespace Parcial1
{
    partial class FormCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogin = new Label();
            txtboxNombre = new TextBox();
            txtboxClave = new TextBox();
            btnLogin = new Button();
            btnRegistro = new Button();
            lblInfoUser = new Label();
            lblContra = new Label();
            lblRecu = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Black", 16F);
            lblLogin.Location = new Point(339, 76);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(91, 37);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // txtboxNombre
            // 
            txtboxNombre.AccessibleDescription = "";
            txtboxNombre.AccessibleName = "";
            txtboxNombre.ForeColor = SystemColors.ScrollBar;
            txtboxNombre.Location = new Point(322, 167);
            txtboxNombre.Name = "txtboxNombre";
            txtboxNombre.Size = new Size(125, 27);
            txtboxNombre.TabIndex = 1;
            txtboxNombre.Text = "Nombre";
            // 
            // txtboxClave
            // 
            txtboxClave.AccessibleDescription = "";
            txtboxClave.AccessibleName = "";
            txtboxClave.ForeColor = SystemColors.ScrollBar;
            txtboxClave.Location = new Point(322, 260);
            txtboxClave.Name = "txtboxClave";
            txtboxClave.Size = new Size(125, 27);
            txtboxClave.TabIndex = 2;
            txtboxClave.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(184, 343);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Inicie sesion";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(447, 343);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(158, 29);
            btnRegistro.TabIndex = 4;
            btnRegistro.Text = "Crear cuenta";
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // lblInfoUser
            // 
            lblInfoUser.AutoSize = true;
            lblInfoUser.Font = new Font("Segoe UI Historic", 7F);
            lblInfoUser.Location = new Point(322, 142);
            lblInfoUser.Name = "lblInfoUser";
            lblInfoUser.Size = new Size(102, 15);
            lblInfoUser.TabIndex = 5;
            lblInfoUser.Text = "Ingrese su usuario";
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Font = new Font("Segoe UI Historic", 7F);
            lblContra.Location = new Point(322, 237);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(121, 15);
            lblContra.TabIndex = 6;
            lblContra.Text = "Ingrese su contraseña";
            lblContra.Click += label2_Click;
            // 
            // lblRecu
            // 
            lblRecu.AutoSize = true;
            lblRecu.Location = new Point(305, 304);
            lblRecu.Name = "lblRecu";
            lblRecu.Size = new Size(161, 20);
            lblRecu.TabIndex = 7;
            lblRecu.Text = "¿Olvido su contraseña?";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(349, 397);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(lblRecu);
            Controls.Add(lblContra);
            Controls.Add(lblInfoUser);
            Controls.Add(btnRegistro);
            Controls.Add(btnLogin);
            Controls.Add(txtboxClave);
            Controls.Add(txtboxNombre);
            Controls.Add(lblLogin);
            Name = "FormCliente";
            Text = "Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox txtboxNombre;
        private TextBox txtboxClave;
        private Button btnLogin;
        private Button btnRegistro;
        private Label lblInfoUser;
        private Label lblContra;
        private Label lblRecu;
        private Button btnSalir;
    }
}