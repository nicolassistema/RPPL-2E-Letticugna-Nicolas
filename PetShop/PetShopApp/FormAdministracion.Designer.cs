
namespace PetShopApp
{
    partial class frmAdministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministracion));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVender = new System.Windows.Forms.Button();
            this.pnlLogoDos = new System.Windows.Forms.Panel();
            this.lblAdministracion = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lbkBlackTheme = new System.Windows.Forms.LinkLabel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogoDos.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBienvenido.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBienvenido.Location = new System.Drawing.Point(0, 85);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(112, 15);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Nombre del usuario";
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Location = new System.Drawing.Point(846, 19);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(76, 15);
            this.lblCerrarSesion.TabIndex = 1;
            this.lblCerrarSesion.TabStop = true;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            this.lblCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCerrarSesion_LinkClicked);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.Image = global::PetShopApp.Properties.Resources.value__1_;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 280);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(140, 60);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmpleados.Image = global::PetShopApp.Properties.Resources.value;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 160);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(140, 60);
            this.btnEmpleados.TabIndex = 6;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFacturacion.Image = global::PetShopApp.Properties.Resources.bar_chart;
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 340);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnFacturacion.Size = new System.Drawing.Size(140, 60);
            this.btnFacturacion.TabIndex = 8;
            this.btnFacturacion.Text = "     Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInventario.Image = global::PetShopApp.Properties.Resources.shopping_list;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 220);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(140, 60);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.btnFacturacion);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.btnInventario);
            this.pnlMenu.Controls.Add(this.btnEmpleados);
            this.pnlMenu.Controls.Add(this.btnVender);
            this.pnlMenu.Controls.Add(this.pnlLogoDos);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(140, 472);
            this.pnlMenu.TabIndex = 7;
            // 
            // btnVender
            // 
            this.btnVender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVender.Image = global::PetShopApp.Properties.Resources.shopping_cart__1_;
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVender.Location = new System.Drawing.Point(0, 100);
            this.btnVender.Name = "btnVender";
            this.btnVender.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnVender.Size = new System.Drawing.Size(140, 60);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "Venta";
            this.btnVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // pnlLogoDos
            // 
            this.pnlLogoDos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogoDos.BackgroundImage = global::PetShopApp.Properties.Resources.settings;
            this.pnlLogoDos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLogoDos.Controls.Add(this.lblAdministracion);
            this.pnlLogoDos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoDos.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoDos.Name = "pnlLogoDos";
            this.pnlLogoDos.Size = new System.Drawing.Size(140, 100);
            this.pnlLogoDos.TabIndex = 1;
            // 
            // lblAdministracion
            // 
            this.lblAdministracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdministracion.AutoSize = true;
            this.lblAdministracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAdministracion.Location = new System.Drawing.Point(25, 82);
            this.lblAdministracion.Name = "lblAdministracion";
            this.lblAdministracion.Size = new System.Drawing.Size(88, 15);
            this.lblAdministracion.TabIndex = 8;
            this.lblAdministracion.Text = "Administracion";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.pnlLogo.BackgroundImage = global::PetShopApp.Properties.Resources.image;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLogo.Controls.Add(this.lblBienvenido);
            this.pnlLogo.Location = new System.Drawing.Point(140, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(140, 100);
            this.pnlLogo.TabIndex = 9;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(215, 200);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(158, 54);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "tiempo";
            // 
            // lbkBlackTheme
            // 
            this.lbkBlackTheme.AutoSize = true;
            this.lbkBlackTheme.Location = new System.Drawing.Point(718, 19);
            this.lbkBlackTheme.Name = "lbkBlackTheme";
            this.lbkBlackTheme.Size = new System.Drawing.Size(70, 15);
            this.lbkBlackTheme.TabIndex = 11;
            this.lbkBlackTheme.TabStop = true;
            this.lbkBlackTheme.Text = "Vision Black";
            this.lbkBlackTheme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkBlackTheme_LinkClicked);
            // 
            // frmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(934, 472);
            this.Controls.Add(this.lbkBlackTheme);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblCerrarSesion);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.frmAdministracion_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogoDos.ResumeLayout(false);
            this.pnlLogoDos.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.LinkLabel lblCerrarSesion;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogoDos;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblAdministracion;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.LinkLabel lbkBlackTheme;
    }
}