namespace Parcial1
{
    partial class FormAdmin
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
            lblRecu = new Label();
            lblContra = new Label();
            lblInfoUser = new Label();
            btnRegistro = new Button();
            btnLogin = new Button();
            txtboxClave = new TextBox();
            txtboxNombre = new TextBox();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // lblRecu
            // 
            lblRecu.AutoSize = true;
            lblRecu.Location = new Point(311, 305);
            lblRecu.Name = "lblRecu";
            lblRecu.Size = new Size(161, 20);
            lblRecu.TabIndex = 15;
            lblRecu.Text = "¿Olvido su contraseña?";
            // 
            // lblContra
            // 
            lblContra.AutoSize = true;
            lblContra.Font = new Font("Segoe UI Historic", 7F);
            lblContra.Location = new Point(328, 238);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(121, 15);
            lblContra.TabIndex = 14;
            lblContra.Text = "Ingrese su contraseña";
            // 
            // lblInfoUser
            // 
            lblInfoUser.AutoSize = true;
            lblInfoUser.Font = new Font("Segoe UI Historic", 7F);
            lblInfoUser.Location = new Point(328, 143);
            lblInfoUser.Name = "lblInfoUser";
            lblInfoUser.Size = new Size(102, 15);
            lblInfoUser.TabIndex = 13;
            lblInfoUser.Text = "Ingrese su usuario";
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(453, 344);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(158, 29);
            btnRegistro.TabIndex = 12;
            btnRegistro.Text = "Crear cuenta";
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(190, 344);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 29);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Inicie sesion";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtboxClave
            // 
            txtboxClave.AccessibleDescription = "";
            txtboxClave.AccessibleName = "";
            txtboxClave.ForeColor = SystemColors.ScrollBar;
            txtboxClave.Location = new Point(328, 261);
            txtboxClave.Name = "txtboxClave";
            txtboxClave.Size = new Size(125, 27);
            txtboxClave.TabIndex = 10;
            txtboxClave.Text = "Contraseña";
            // 
            // txtboxNombre
            // 
            txtboxNombre.AccessibleDescription = "";
            txtboxNombre.AccessibleName = "";
            txtboxNombre.ForeColor = SystemColors.ScrollBar;
            txtboxNombre.Location = new Point(328, 168);
            txtboxNombre.Name = "txtboxNombre";
            txtboxNombre.Size = new Size(125, 27);
            txtboxNombre.TabIndex = 9;
            txtboxNombre.Text = "Nombre";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Black", 16F);
            lblLogin.Location = new Point(345, 77);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(91, 37);
            lblLogin.TabIndex = 8;
            lblLogin.Text = "Login";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRecu);
            Controls.Add(lblContra);
            Controls.Add(lblInfoUser);
            Controls.Add(btnRegistro);
            Controls.Add(btnLogin);
            Controls.Add(txtboxClave);
            Controls.Add(txtboxNombre);
            Controls.Add(lblLogin);
            Name = "FormAdmin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecu;
        private Label lblContra;
        private Label lblInfoUser;
        private Button btnRegistro;
        private Button btnLogin;
        private TextBox txtboxClave;
        private TextBox txtboxNombre;
        private Label lblLogin;
    }
}