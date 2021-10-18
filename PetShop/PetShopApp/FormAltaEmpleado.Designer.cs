
namespace PetShopApp
{
    partial class frmAltaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaEmpleado));
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblValidCuit = new System.Windows.Forms.Label();
            this.lblValidNombre = new System.Windows.Forms.Label();
            this.lblValidApellido = new System.Windows.Forms.Label();
            this.lblValidUser = new System.Windows.Forms.Label();
            this.lblValidPass = new System.Windows.Forms.Label();
            this.lblValidPerfil = new System.Windows.Forms.Label();
            this.lbkEmpleadoExistente = new System.Windows.Forms.LinkLabel();
            this.lbkEmpleadoInexistente = new System.Windows.Forms.LinkLabel();
            this.lblDarkMode = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(78, 77);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(182, 23);
            this.txtCuit.TabIndex = 0;
            this.txtCuit.Leave += new System.EventHandler(this.txtCuit_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(78, 193);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(78, 164);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(182, 23);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(78, 135);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(182, 23);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuit.Location = new System.Drawing.Point(43, 80);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(29, 15);
            this.lblCuit.TabIndex = 5;
            this.lblCuit.Text = "Cuit";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(25, 109);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 15);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(25, 138);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 15);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(25, 167);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(49, 15);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(15, 196);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 15);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "Empleado",
            "Admin"});
            this.cmbPerfil.Location = new System.Drawing.Point(78, 222);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(182, 23);
            this.cmbPerfil.TabIndex = 10;
            this.cmbPerfil.Leave += new System.EventHandler(this.cmbPerfil_Leave);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPerfil.Location = new System.Drawing.Point(38, 225);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(37, 15);
            this.lblPerfil.TabIndex = 11;
            this.lblPerfil.Text = "Perfil";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(9, 270);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 64);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(134, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 64);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(7, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Padding = new System.Windows.Forms.Padding(0, 0, 200, 0);
            this.lblMensaje.Size = new System.Drawing.Size(253, 15);
            this.lblMensaje.TabIndex = 14;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.Visible = false;
            // 
            // lblValidCuit
            // 
            this.lblValidCuit.AutoSize = true;
            this.lblValidCuit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidCuit.ForeColor = System.Drawing.Color.Red;
            this.lblValidCuit.Location = new System.Drawing.Point(266, 77);
            this.lblValidCuit.Name = "lblValidCuit";
            this.lblValidCuit.Size = new System.Drawing.Size(21, 28);
            this.lblValidCuit.TabIndex = 15;
            this.lblValidCuit.Text = "*";
            // 
            // lblValidNombre
            // 
            this.lblValidNombre.AutoSize = true;
            this.lblValidNombre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidNombre.ForeColor = System.Drawing.Color.Red;
            this.lblValidNombre.Location = new System.Drawing.Point(266, 106);
            this.lblValidNombre.Name = "lblValidNombre";
            this.lblValidNombre.Size = new System.Drawing.Size(21, 28);
            this.lblValidNombre.TabIndex = 16;
            this.lblValidNombre.Text = "*";
            // 
            // lblValidApellido
            // 
            this.lblValidApellido.AutoSize = true;
            this.lblValidApellido.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidApellido.ForeColor = System.Drawing.Color.Red;
            this.lblValidApellido.Location = new System.Drawing.Point(266, 134);
            this.lblValidApellido.Name = "lblValidApellido";
            this.lblValidApellido.Size = new System.Drawing.Size(21, 28);
            this.lblValidApellido.TabIndex = 17;
            this.lblValidApellido.Text = "*";
            // 
            // lblValidUser
            // 
            this.lblValidUser.AutoSize = true;
            this.lblValidUser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidUser.ForeColor = System.Drawing.Color.Red;
            this.lblValidUser.Location = new System.Drawing.Point(266, 164);
            this.lblValidUser.Name = "lblValidUser";
            this.lblValidUser.Size = new System.Drawing.Size(21, 28);
            this.lblValidUser.TabIndex = 18;
            this.lblValidUser.Text = "*";
            // 
            // lblValidPass
            // 
            this.lblValidPass.AutoSize = true;
            this.lblValidPass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidPass.ForeColor = System.Drawing.Color.Red;
            this.lblValidPass.Location = new System.Drawing.Point(266, 193);
            this.lblValidPass.Name = "lblValidPass";
            this.lblValidPass.Size = new System.Drawing.Size(21, 28);
            this.lblValidPass.TabIndex = 19;
            this.lblValidPass.Text = "*";
            // 
            // lblValidPerfil
            // 
            this.lblValidPerfil.AutoSize = true;
            this.lblValidPerfil.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidPerfil.ForeColor = System.Drawing.Color.Red;
            this.lblValidPerfil.Location = new System.Drawing.Point(266, 217);
            this.lblValidPerfil.Name = "lblValidPerfil";
            this.lblValidPerfil.Size = new System.Drawing.Size(21, 28);
            this.lblValidPerfil.TabIndex = 20;
            this.lblValidPerfil.Text = "*";
            // 
            // lbkEmpleadoExistente
            // 
            this.lbkEmpleadoExistente.AutoSize = true;
            this.lbkEmpleadoExistente.Location = new System.Drawing.Point(78, 375);
            this.lbkEmpleadoExistente.Name = "lbkEmpleadoExistente";
            this.lbkEmpleadoExistente.Size = new System.Drawing.Size(110, 15);
            this.lbkEmpleadoExistente.TabIndex = 21;
            this.lbkEmpleadoExistente.TabStop = true;
            this.lbkEmpleadoExistente.Text = "Empleado Existente";
            this.lbkEmpleadoExistente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkEmpleadoExistente_LinkClicked);
            // 
            // lbkEmpleadoInexistente
            // 
            this.lbkEmpleadoInexistente.AutoSize = true;
            this.lbkEmpleadoInexistente.Location = new System.Drawing.Point(78, 390);
            this.lbkEmpleadoInexistente.Name = "lbkEmpleadoInexistente";
            this.lbkEmpleadoInexistente.Size = new System.Drawing.Size(124, 15);
            this.lbkEmpleadoInexistente.TabIndex = 22;
            this.lbkEmpleadoInexistente.TabStop = true;
            this.lbkEmpleadoInexistente.Text = "Empleado Inexistemte";
            this.lbkEmpleadoInexistente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkEmpleadoInexistente_LinkClicked);
            // 
            // lblDarkMode
            // 
            this.lblDarkMode.AutoSize = true;
            this.lblDarkMode.Location = new System.Drawing.Point(172, 9);
            this.lblDarkMode.Name = "lblDarkMode";
            this.lblDarkMode.Size = new System.Drawing.Size(62, 15);
            this.lblDarkMode.TabIndex = 23;
            this.lblDarkMode.TabStop = true;
            this.lblDarkMode.Text = "DarkMode";
            this.lblDarkMode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDarkMode_LinkClicked);
            // 
            // frmAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(298, 444);
            this.Controls.Add(this.lblDarkMode);
            this.Controls.Add(this.lbkEmpleadoInexistente);
            this.Controls.Add(this.lbkEmpleadoExistente);
            this.Controls.Add(this.lblValidPerfil);
            this.Controls.Add(this.lblValidPass);
            this.Controls.Add(this.lblValidUser);
            this.Controls.Add(this.lblValidApellido);
            this.Controls.Add(this.lblValidNombre);
            this.Controls.Add(this.lblValidCuit);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCuit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Empleado";
            this.Load += new System.EventHandler(this.frmAltaEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblValidCuit;
        private System.Windows.Forms.Label lblValidNombre;
        private System.Windows.Forms.Label lblValidApellido;
        private System.Windows.Forms.Label lblValidUser;
        private System.Windows.Forms.Label lblValidPass;
        private System.Windows.Forms.Label lblValidPerfil;
        private System.Windows.Forms.LinkLabel lbkEmpleadoExistente;
        private System.Windows.Forms.LinkLabel lbkEmpleadoInexistente;
        private System.Windows.Forms.LinkLabel lblDarkMode;
    }
}