
namespace PetShopApp
{
    partial class FormAltaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaCliente));
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblValidCuit = new System.Windows.Forms.Label();
            this.lblValidNombre = new System.Windows.Forms.Label();
            this.lblValidApellido = new System.Windows.Forms.Label();
            this.lbkClienteNuevo = new System.Windows.Forms.LinkLabel();
            this.lbkClienteExistente = new System.Windows.Forms.LinkLabel();
            this.pnlAutoCargaDatos = new System.Windows.Forms.Panel();
            this.pnlAutoCargaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(81, 62);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 23);
            this.txtCuit.TabIndex = 0;
            this.txtCuit.Leave += new System.EventHandler(this.txtCuit_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(81, 120);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuitCliente.Location = new System.Drawing.Point(47, 65);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(29, 15);
            this.lblCuitCliente.TabIndex = 3;
            this.lblCuitCliente.Text = "Cuit";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCliente.Location = new System.Drawing.Point(23, 94);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(53, 15);
            this.lblNombreCliente.TabIndex = 4;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellidoCliente.Location = new System.Drawing.Point(23, 123);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(52, 15);
            this.lblApellidoCliente.TabIndex = 5;
            this.lblApellidoCliente.Text = "Apellido";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 163);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 49);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(107, 163);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 49);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(12, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(53, 15);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.Visible = false;
            // 
            // lblValidCuit
            // 
            this.lblValidCuit.AutoSize = true;
            this.lblValidCuit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidCuit.ForeColor = System.Drawing.Color.Red;
            this.lblValidCuit.Location = new System.Drawing.Point(187, 62);
            this.lblValidCuit.Name = "lblValidCuit";
            this.lblValidCuit.Size = new System.Drawing.Size(21, 28);
            this.lblValidCuit.TabIndex = 9;
            this.lblValidCuit.Text = "*";
            // 
            // lblValidNombre
            // 
            this.lblValidNombre.AutoSize = true;
            this.lblValidNombre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidNombre.ForeColor = System.Drawing.Color.Red;
            this.lblValidNombre.Location = new System.Drawing.Point(187, 90);
            this.lblValidNombre.Name = "lblValidNombre";
            this.lblValidNombre.Size = new System.Drawing.Size(21, 28);
            this.lblValidNombre.TabIndex = 10;
            this.lblValidNombre.Text = "*";
            // 
            // lblValidApellido
            // 
            this.lblValidApellido.AutoSize = true;
            this.lblValidApellido.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidApellido.ForeColor = System.Drawing.Color.Red;
            this.lblValidApellido.Location = new System.Drawing.Point(187, 120);
            this.lblValidApellido.Name = "lblValidApellido";
            this.lblValidApellido.Size = new System.Drawing.Size(21, 28);
            this.lblValidApellido.TabIndex = 11;
            this.lblValidApellido.Text = "*";
            // 
            // lbkClienteNuevo
            // 
            this.lbkClienteNuevo.AutoSize = true;
            this.lbkClienteNuevo.Location = new System.Drawing.Point(3, 2);
            this.lbkClienteNuevo.Name = "lbkClienteNuevo";
            this.lbkClienteNuevo.Size = new System.Drawing.Size(82, 15);
            this.lbkClienteNuevo.TabIndex = 12;
            this.lbkClienteNuevo.TabStop = true;
            this.lbkClienteNuevo.Text = "Cliente Nuevo";
            this.lbkClienteNuevo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkClienteNuevo_LinkClicked);
            // 
            // lbkClienteExistente
            // 
            this.lbkClienteExistente.AutoSize = true;
            this.lbkClienteExistente.Location = new System.Drawing.Point(3, 17);
            this.lbkClienteExistente.Name = "lbkClienteExistente";
            this.lbkClienteExistente.Size = new System.Drawing.Size(94, 15);
            this.lbkClienteExistente.TabIndex = 13;
            this.lbkClienteExistente.TabStop = true;
            this.lbkClienteExistente.Text = "Cliente Existente";
            this.lbkClienteExistente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkClienteExistente_LinkClicked);
            // 
            // pnlAutoCargaDatos
            // 
            this.pnlAutoCargaDatos.Controls.Add(this.lbkClienteNuevo);
            this.pnlAutoCargaDatos.Controls.Add(this.lbkClienteExistente);
            this.pnlAutoCargaDatos.Location = new System.Drawing.Point(35, 218);
            this.pnlAutoCargaDatos.Name = "pnlAutoCargaDatos";
            this.pnlAutoCargaDatos.Size = new System.Drawing.Size(161, 37);
            this.pnlAutoCargaDatos.TabIndex = 14;
            // 
            // FormAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 266);
            this.Controls.Add(this.pnlAutoCargaDatos);
            this.Controls.Add(this.lblValidApellido);
            this.Controls.Add(this.lblValidNombre);
            this.Controls.Add(this.lblValidCuit);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblCuitCliente);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCuit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAltaCliente";
            this.pnlAutoCargaDatos.ResumeLayout(false);
            this.pnlAutoCargaDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCuitCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblValidCuit;
        private System.Windows.Forms.Label lblValidNombre;
        private System.Windows.Forms.Label lblValidApellido;
        private System.Windows.Forms.LinkLabel lbkClienteNuevo;
        private System.Windows.Forms.LinkLabel lbkClienteExistente;
        private System.Windows.Forms.Panel pnlAutoCargaDatos;
    }
}