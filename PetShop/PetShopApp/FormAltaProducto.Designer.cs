
namespace PetShopApp
{
    partial class FrmAltaProducto
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCanelar = new System.Windows.Forms.Button();
            this.lblTipoProd = new System.Windows.Forms.Label();
            this.cmbTipoProd = new System.Windows.Forms.ComboBox();
            this.lblDetalleTipoProd = new System.Windows.Forms.Label();
            this.cmbDetalleTipoProd = new System.Windows.Forms.ComboBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(16, 69);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(16, 143);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(69, 15);
            this.lblDescrip.TabIndex = 2;
            this.lblDescrip.Text = "Descripcion";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(16, 183);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(36, 15);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(16, 226);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(16, 268);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(40, 15);
            this.lblKg.TabIndex = 5;
            this.lblKg.Text = "Kg./U.";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(102, 61);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 23);
            this.txtMarca.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(102, 135);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(100, 23);
            this.txtDescrip.TabIndex = 8;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(102, 175);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 23);
            this.txtStock.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(102, 218);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(102, 260);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(100, 23);
            this.txtKg.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(5, 407);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 64);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCanelar
            // 
            this.btnCanelar.Location = new System.Drawing.Point(110, 407);
            this.btnCanelar.Name = "btnCanelar";
            this.btnCanelar.Size = new System.Drawing.Size(92, 64);
            this.btnCanelar.TabIndex = 13;
            this.btnCanelar.Text = "Cancelar";
            this.btnCanelar.UseVisualStyleBackColor = true;
            this.btnCanelar.Click += new System.EventHandler(this.btnCanelar_Click);
            // 
            // lblTipoProd
            // 
            this.lblTipoProd.AutoSize = true;
            this.lblTipoProd.Location = new System.Drawing.Point(15, 305);
            this.lblTipoProd.Name = "lblTipoProd";
            this.lblTipoProd.Size = new System.Drawing.Size(82, 15);
            this.lblTipoProd.TabIndex = 14;
            this.lblTipoProd.Text = "Tipo Producto";
            // 
            // cmbTipoProd
            // 
            this.cmbTipoProd.FormattingEnabled = true;
            this.cmbTipoProd.Items.AddRange(new object[] {
            "Alimento",
            "Art. Cuidado Mascota",
            "Cama",
            "Juguete"});
            this.cmbTipoProd.Location = new System.Drawing.Point(102, 297);
            this.cmbTipoProd.Name = "cmbTipoProd";
            this.cmbTipoProd.Size = new System.Drawing.Size(100, 23);
            this.cmbTipoProd.TabIndex = 15;
            this.cmbTipoProd.SelectedIndexChanged += new System.EventHandler(this.cmbTipoProd_SelectedIndexChanged);
            // 
            // lblDetalleTipoProd
            // 
            this.lblDetalleTipoProd.AutoSize = true;
            this.lblDetalleTipoProd.Location = new System.Drawing.Point(15, 352);
            this.lblDetalleTipoProd.Name = "lblDetalleTipoProd";
            this.lblDetalleTipoProd.Size = new System.Drawing.Size(82, 15);
            this.lblDetalleTipoProd.TabIndex = 16;
            this.lblDetalleTipoProd.Text = "Tipo Producto";
            // 
            // cmbDetalleTipoProd
            // 
            this.cmbDetalleTipoProd.FormattingEnabled = true;
            this.cmbDetalleTipoProd.Location = new System.Drawing.Point(102, 344);
            this.cmbDetalleTipoProd.Name = "cmbDetalleTipoProd";
            this.cmbDetalleTipoProd.Size = new System.Drawing.Size(100, 23);
            this.cmbDetalleTipoProd.TabIndex = 17;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(38, 15);
            this.lblMensaje.TabIndex = 18;
            this.lblMensaje.Text = "label1";
            // 
            // FrmAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 483);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.cmbDetalleTipoProd);
            this.Controls.Add(this.lblDetalleTipoProd);
            this.Controls.Add(this.cmbTipoProd);
            this.Controls.Add(this.lblTipoProd);
            this.Controls.Add(this.btnCanelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMarca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCanelar;
        private System.Windows.Forms.Label lblTipoProd;
        private System.Windows.Forms.ComboBox cmbTipoProd;
        private System.Windows.Forms.Label lblDetalleTipoProd;
        private System.Windows.Forms.ComboBox cmbDetalleTipoProd;
        private System.Windows.Forms.Label lblMensaje;
    }
}